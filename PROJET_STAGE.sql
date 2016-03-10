create database PROJET_STAGE

go
use PROJET_STAGE
go
create table Servicee(
	idService int constraint pk_Servicee primary key,
	nomService varchar(30) constraint ck_Servicee_nomService unique
)
go
create table Compte(
	loginn varchar(20) constraint pk_Compte primary key ,
	pass varchar(14) constraint ck_Compte_pass check (len(pass)between 8 and 14),
	#idService int constraint fk_Compte_#idService foreign key references Servicee(idService)
)
go
create table Infirmier(
	idInfirmier int constraint pk_Infirmier primary key,
	nom varchar(30),
	prenom varchar(30),
	dateNaiss date,
	superviseur int constraint fk_Infirmier_superviseur foreign key references Infirmier(idInfirmier),
	email varchar(30),
	sexe varchar(5) constraint ck_Infirmier_sexe check (sexe in('Homme','Femme')),
	tel varchar(13),
	adresse varchar(70),
	#idService int constraint fk_Infirmier_#idService foreign key references Servicee(idService)
)
go

create table Absence(
	#idInfirmier int constraint fk_Absence_#idInfirmier foreign key references Infirmier(idInfirmier),
	dateAbsence date  ,
	constraint pk_Absence primary key(#idInfirmier,dateAbsence)
)
go

create table Guarde(
	dateGuarde date  ,
	periode int constraint ck_Garde_periode check(periode in(1,2)),
	#idInfirmier int constraint fk_GardeInfirmier_#idInfirmier foreign key references Infirmier(idInfirmier),
	constraint pk_Guarde primary key(dateGuarde,periode,#idInfirmier)
)
go
create table Conge(
	idConge int identity(1,1) constraint pk_Conge primary key ,
	dateDepart date ,
	nbrJours int ,
	#idInfirmier int constraint fk_Conge_idConge foreign key references Infirmier(idInfirmier)
)
go

--insertion de test
go
insert into Servicee values(1,'Informatique');
insert into Servicee values(2,'Biochimie');
go
-------------------
insert into Compte values('badr.kalitouss','azerty12',1)
insert into Compte values('aziza.maiza','123456AZ',1)
insert into Compte values('mohcine.char','AQWZSX12',2)
-------------------
insert into Infirmier values(1,'ARADI','ARADI','1980-04-09',1,'aradi.mehdi@gmail.com','Homme','0676767676','sl jdida',2)
insert into Infirmier values(2,'KBABO','Abdelhamid','1982-04-09',1,'kbabo.abdo@gmail.com','Homme','0676767676','sl jdida',2)
insert into Infirmier values(3,'IBOURK','Abdelilah','1983-03-09',1,'aradi.mehdi@gmail.com','Homme','0676767676','sl jdida',2)
-------------------
insert into Conge values('2015-03-30' ,10,1)
insert into conge values('2012-12-03',22,1)
insert into conge values('2013-11-24',22,2)
-------------------
insert into Guarde values ('2013-11-24',1,1)
insert into Guarde values ('2013-01-02',1,1)
insert into Guarde values ('2013-01-21',1,1)
select * from Guarde
select * from Infirmier
delete from Guarde where dateGuarde='2013-01-02' and periode=1 and #idInfirmier=1
-------------------

--****************************** FUNCTIONS
go
create function InfirmierAUneGuarde(@IdInf int,@dateG date,@per int)
returns bit
as
begin
	declare @res bit
	if(select count(Guarde.dateGuarde) as nbr_garde
		from Guarde  ,Infirmier
		where Guarde.#idInfirmier= Infirmier.idInfirmier
		and Infirmier.idInfirmier=@IdInf
		and Guarde.dateGuarde= @dateG
		and Guarde.periode = @per)>0
		begin
			set @res ='true'
		end
	else
	begin
		set @res='false'
	end
	return @res
end
go
---------------------------------
create function InfirmierAUneAbsence(@idInf int , @dateAbsence date)
returns bit
as
	begin
		declare @res bit ;
		if(
			select count(Absence.dateAbsence)
			from Infirmier ,Absence
			where Infirmier.idInfirmier = Absence.#idInfirmier
			and Infirmier.idInfirmier =@idInf
			and Absence.dateAbsence=@dateAbsence
			)>0
			begin
				set @res = 'true' ;
			end
		else
			begin
				set @res = 'false' ;
			end
		return @res
	end
go

--****************************** PROCéDURES STOCKéS
create proc AficherInfirmier(@idServ int ,@date date ,@peride int)
as
	select distinct dbo.InfirmierAUneGuarde(Infirmier.idInfirmier,@date,@peride) as [Select.] , Infirmier.idInfirmier,Infirmier.nom,Infirmier.prenom
	from Infirmier
	where #idService=@idServ
go
--exec AficherInfirmier 1,'2015-04-01',1
--------------------------------
alter proc AfficherInfirmierAbsence(@dateAbsence date ,@idService int)
as
	begin
		select dbo.InfirmierAUneAbsence(Infirmier.idInfirmier,@dateAbsence) as [Absent(e)] ,Infirmier.idInfirmier, Infirmier.nom,Infirmier.prenom
		from Infirmier
		where Infirmier.#idService=@idService
	end
go
--exec  AfficherInfirmierAbsence '2015-04-04',1
--****************************** TIGGER(DéCLENCHEURS)
create trigger Regles_d_ajout_dune_Guarde
on Guarde instead of insert
as
begin
	--Existance de la guarde a inserer
	declare @dateGuarde date ; set @dateGuarde  =(select dateGuarde from inserted)
	declare @periode int ;	 set @periode   =(select periode from inserted)
	declare @idInf int ; set @idInf =(select #idInfirmier from inserted )
	if(not exists (select * from Guarde where dateGuarde=@dateGuarde and periode =@periode and #idInfirmier=@idInf))
		--*****cas de n'exist pas
		begin
			declare @dateDep date ; set @dateDep=(
													select top 1 dateDepart 
													from conge 
													where #idInfirmier =@idInf 
													order by dateDepart desc
												 )
			declare @nbrJours int;set @nbrJours =(
												select top 1 nbrJours
												from Conge
												where #idInfirmier = @idInf
												order by dateDepart desc
												 )
			declare @dateFinal date;set @dateFinal = dateadd(day,@nbrJours,@dateDep)
			if(@dateGuarde >= @dateDep and @dateGuarde <= @dateFinal)
				begin
					declare @msg varchar(max) ; set @msg ='[Erreur d insertion]';
					RAISERROR (15600,-1,-1, @msg);
				end
			else
				begin
					insert into Guarde values (@dateGuarde,@periode,@idInf)
				end
		end
		--*****Fin de cas (n'exist pas)
end
----------------
go
create trigger Regle_dAjout_dUneAbsence
on Absence instead of insert
as
	begin
		declare @idInf int ;set @idInf=(select #idInfirmier from inserted)
		declare @dateAbsence date; set @dateAbsence=(select dateAbsence from inserted)
		if( not exists (select * from Absence where #idInfirmier=@idInf and dateAbsence=@dateAbsence))
		begin
			insert into Absence values (@idInf,@dateAbsence)
		end
	end
go
--********************************

-------------------















































































































































































































































































































































































