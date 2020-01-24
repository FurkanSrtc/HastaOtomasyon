Create database KlinikDB

use KlinikDB

Create Table Hasta (
H_ID int identity(1,1) primary key,
H_AD varchar(50),
H_SOYAD varchar(50),
H_DTARIH date,
H_TC char(11),
H_TEL varchar(13),
H_ADRES nvarchar(255),
H_CID tinyint
)

create table Cinsiyet (
C_ID tinyint primary key,
Cinsiyet varchar(15),
)

create table Personel(
P_ID int identity(1,1) primary key,
P_AD varchar(50),
P_SOYAD varchar(50),
P_DTARIH date,
P_TC char(11),
P_TEL varchar(13),
P_ADRES varchar(255),
P_EMAIL varchar(50),
P_SIFRE nvarchar(50),
P_CID tinyint
)

create table Hizmet(
H_ID int identity(1,1) primary key,
H_AD varchar(50)
)

create table Randevu(
R_ID int identity(1,1) primary key,
R_PERSONELID int,
R_HASTAID int,
R_HIZMETID int,
R_DURUMID tinyint,
R_TARIH smalldatetime,
R_ACIKLAMA varchar(500)
)

create table RDurum(
D_ID tinyint primary key,
D_AD varchar(50)
)

create table RSonuc(
S_ID int identity(1,1) primary key,
S_RANDEVUID int,
S_TURID tinyint,
S_ACIKLAMA varchar(500),

)

create table RSTur(
T_ID tinyint primary key,
T_AD varchar(50),

)


Alter table Hasta add constraint FK_Hasta_Cinsiyet_CID
Foreign Key (H_CID) references Cinsiyet(C_ID)

Alter table Personel add constraint FK_Personel_Cinsiyet_CID
Foreign Key (P_CID) references Cinsiyet(C_ID)

Alter table Randevu add constraint FK_Randevu_Personel_PersonelID
Foreign Key (R_PERSONELID) references Personel(P_ID)

Alter table Randevu add constraint FK_Randevu_Hizmet_HizmetID
Foreign Key (R_HIZMETID) references Hizmet(H_ID)

Alter table Randevu add constraint FK_Randevu_Hasta_HastaID
Foreign Key (R_HASTAID) references Hasta(H_ID)

Alter table Randevu add constraint FK_Randevu_RDurum_DurumID
Foreign Key (R_DURUMID) references RDURUM(D_ID)

Alter table RSonuc add constraint FK_RSonuc_Randevu_RandevuID
Foreign Key (S_RANDEVUID) references Randevu(R_ID)

Alter table RSonuc add constraint FK_RSonuc_RSTur_TurID
Foreign Key (S_TURID) references RSTur(T_ID)