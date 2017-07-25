drop table korisnik
drop table uplata
drop table pohadja
drop table ucenik
drop table kurs
drop table nastavnik
drop table skola

create database Projekat_c#

Create Table Korisnik
	(Id_Korisnik	Int IDENTITY Primary Key not null,
	 Ime			Varchar(15) Not Null,
	 Prezime		Varchar(25) Not null,
	 KorIme			Varchar(25) not null,
	 Sifra			Varchar(25) NOT null,
	 TipKorisnika	Varchar(25) Not null)
	 
Create Table Ucenik
	(Id_Ucenik		Int IDENTITY Primary Key not null,
	 Ime			Varchar(15) Not Null,
	 Prezime		Varchar(25) Not null,
	 BrTelefona		Varchar(15),
	 Jmbg			Varchar(15) NOT null,
	 Adresa			Varchar(35) Not null)
	 
Create Table Nastavnik
	(Id_Nastavnik	Int IDENTITY Primary Key not null,
	 Ime			Varchar(15) Not Null,
	 Prezime		Varchar(25) Not null,
	 BrTelefona		Varchar(15),
	 Jmbg			Varchar(15) NOT null,
	 Adresa			Varchar(35) Not null)

Create Table Kurs
	(Id_Kurs		Int IDENTITY Primary Key not null,
	 Naziv			Varchar(25) Not null,
	 Jezik			Varchar(15) Not Null,
	 NivoJezika		Varchar(15) Not null,
	 Cena			money Not null,
	 Id_Nastavnik	Int 
		Foreign Key References Nastavnik(Id_Nastavnik))
	 
Create Table Skola
	(Id_Skola		Int Identity primary key not null,
	 Naziv			Varchar(35) Not Null,
	 Adresa			Varchar(35) Not null,
	 BrTelefona		Varchar(15) not null,
	 Email			Varchar(30) NOT null,
	 AdresaSajta	Varchar(35) not null,
	 Pib			Varchar(15) not null,
	 MaticniBr		Varchar(25) not null,
	 brZiroRacuna	Varchar(25) Not null)
	
Create Table Pohadja
	(Id_Kurs		Int not null
		Foreign Key References Kurs(Id_Kurs),
	 Id_Ucenik		Int not null
		Foreign Key References Ucenik(Id_Ucenik))
	 
Create Table Uplata
	(Id_Uplata		Int Identity primary key not null,
	 Iznos			Money Not Null,
	 Id_Ucenik		Int 
		Foreign Key References Ucenik(Id_Ucenik),
	 Id_Kurs		Int 
		Foreign Key References Kurs(Id_Kurs),
	 Datum			Date Not null,
	 Valuta			Varchar(10) Not null)