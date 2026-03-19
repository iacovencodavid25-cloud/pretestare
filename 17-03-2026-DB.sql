-- lista angajatilor din intreprindere cu stagiul mai mare de 20 de ani
-- denumirea departamentului si nr de angajati in fiecare din ele

create database exersareExamen;
go 

use exersareExamen;
go

create table Departament(
	nr_departament tinyint primary key check(nr_departament > 0 and nr_departament < 20),
	denumire_departament varchar(75) not null,
	sef_departament varchar(50) not null
);
go

create table Angajat(
	nume_prenume nvarchar(75) not null,
	data_dasterii date not null,
	adresa varchar(100) not null,
	telefon char(12) check(telefon like '+373[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	stagiu tinyint check(stagiu > 0 and stagiu < 50) not null,
	nr_departament tinyint check(nr_departament > 0 and nr_departament < 20) foreign key references Departament(nr_departament) not null
);
go

--functie de generare id pentru departament
create function dbo.fn_generare_nr_departament()
returns tinyint
as
begin
	declare @nou_nr tinyint;
	select @nou_nr = isnull(max(nr_departament), 0) + 1
	from Departament;
	return @nou_nr;
end;
go

-- procedura pentru adugarea unui nou departament
create procedure dbo.sp_adauga_departament
	@denumire_departament varchar(75),	@sef_departament varchar(50)
as
begin
	set nocount on;
	declare @nr_departament tinyint;
	set @nr_departament = dbo.fn_generare_nr_departament();
	if @nr_departament >= 20
	begin
		print 'Nu se mai poate adauga departament. Limita maxima a fost atinsa.';
		return;
	end
	insert into Departament(nr_departament, denumire_departament, sef_departament)
	values(@nr_departament, @denumire_departament, @sef_departament);
	print 'Departamentul a fost adaugat cu succes.';
end;
go

-- procedura pentru adaugarea unui nou angajat
create procedure dbo.sp_adauga_angajat
	@nume_prenume nvarchar(75),	@data_nasterii date,@adresa varchar(100),@telefon char(12),@stagiu tinyint,	@nr_departament tinyint
as
begin
	set nocount on;
	if not exists (
		select 1
		from Departament
		where nr_departament = @nr_departament
	)
	begin
		print 'Departamentul introdus nu exista.';
		return;
	end

	insert into Angajat(
		nume_prenume,data_dasterii,adresa,telefon,stagiu,nr_departament
	)
	values(
		@nume_prenume, @data_nasterii,@adresa,@telefon,@stagiu,@nr_departament
	);

	print 'Angajatul a fost adaugat cu succes.';
end;
go


-- adaugam inregistrari in baza de date
exec dbo.sp_adauga_departament 'Resurse Umane', 'Maria Popescu';
exec dbo.sp_adauga_departament 'Contabilitate', 'Ion Rusu';
exec dbo.sp_adauga_departament 'IT', 'Andrei Munteanu';
exec dbo.sp_adauga_departament 'Marketing', 'Elena Ciobanu';
exec dbo.sp_adauga_departament 'Vanzari', 'Victor Grosu';
exec dbo.sp_adauga_departament 'Logistica', 'Natalia Moraru';
exec dbo.sp_adauga_departament 'Achizitii', 'Sergiu Lupan';
exec dbo.sp_adauga_departament 'Juridic', 'Ana Balan';
exec dbo.sp_adauga_departament 'Productie', 'Mihai Sandu';
exec dbo.sp_adauga_departament 'Administratie', 'Tatiana Ceban';
go

exec dbo.sp_adauga_angajat	N'Alexandru Damian','1995-03-12','Chisinau, str. Stefan cel Mare 10','+37369123456',5,1;
exec dbo.sp_adauga_angajat	N'Diana Croitoru','1998-07-25','Balti, str. Independentei 21','+37368111222',3,2;
exec dbo.sp_adauga_angajat	N'Cristian Melnic','1992-11-08','Cahul, str. Pacii 14','+37379122334',8,3;
exec dbo.sp_adauga_angajat	N'Gabriela Rusu','1997-05-19','Orhei, str. Vasile Lupu 7','+37360123456',4,4;
exec dbo.sp_adauga_angajat	N'Ion Cebotari','1990-01-30','Chisinau, str. Alba Iulia 33','+37369111223',10,5;
exec dbo.sp_adauga_angajat N'Mihaela Grosu','1999-09-14','Ungheni, str. Nationala 45','+37368123457',2,6;
exec dbo.sp_adauga_angajat	N'Sergiu Balan','1994-06-11','Soroca, str. Libertatii 9','+37379123458',6,7;
exec dbo.sp_adauga_angajat	N'Natalia Cojocaru','1996-12-03','Edinet, str. Mihai Eminescu 18','+37360123459',5,8;
exec dbo.sp_adauga_angajat	N'Vadim Rotaru','1991-04-27','Hincesti, str. Bucuresti 12','+37369123460',9,9;
exec dbo.sp_adauga_angajat	N'Alina Munteanu','2000-08-16','Comrat, str. Tineretului 5','+37368123461',1,10;
exec dbo.sp_adauga_angajat	N'Alina Munteanu','2000-08-16','Comrat, str. Tineretului 5','+37368123461',24,10;
exec dbo.sp_adauga_angajat N'Alexandru Damian', '1980-03-12', 'Chisinau, str. Stefan cel Mare 10', '+37369123456', 25, 1;
exec dbo.sp_adauga_angajat N'Diana Croitoru', '1978-07-25', 'Balti, str. Independentei 21', '+37368111222', 22, 2;
exec dbo.sp_adauga_angajat N'Cristian Melnic', '1975-11-08', 'Cahul, str. Pacii 14', '+37379122334', 28, 3;
exec dbo.sp_adauga_angajat N'Gabriela Rusu', '1979-05-19', 'Orhei, str. Vasile Lupu 7', '+37360123456', 21, 4;
exec dbo.sp_adauga_angajat N'Ion Cebotari', '1976-01-30', 'Chisinau, str. Alba Iulia 33', '+37369111223', 30, 5;
exec dbo.sp_adauga_angajat N'Mihaela Grosu', '1981-09-14', 'Ungheni, str. Nationala 45', '+37368123457', 24, 6;
go


create view v_Angajat_Dep 
as
	select Departament.nr_departament, denumire_departament, nume_prenume, stagiu 
	from Departament inner join Angajat 
	on Departament.nr_departament = Angajat.nr_departament;
go

select * from v_Angajat_Dep;

-- lista angajatilor din intreprindere cu stagiul mai mare de 20 de ani
select nume_prenume, stagiu 
from v_Angajat_Dep 
where stagiu > 20;

-- denumirea departamentului si nr de angajati in fiecare din ele
select denumire_departament, count(*) as nr_angajati
from v_Angajat_Dep
group by denumire_departament
order by denumire_departament;
