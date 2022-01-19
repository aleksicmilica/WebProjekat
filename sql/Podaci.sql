insert into Bioskopi (Naziv) VALUES ('Cine grand');
INSERT into Bioskopi (Naziv) VALUES ('Cineplexx');

Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Kings Man','akcija,avantura,komedija',131,CONVERT(datetime2,'2021-12-13 00:00:00'),CONVERT(datetime2,'2022-5-13 00:00:00'),290,5);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Matrix','akcija,naucna fantastika',148,CONVERT(datetime2,'2021-12-23'),CONVERT(datetime2,'2022-3-20'),290,5);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Spajdermen:Put bez povrtaka','akcija,naucna fantastika',146,CONVERT(datetime2,'2021-12-16'),CONVERT(datetime2,'2022-2-13'),290,5);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Gucijevi','drama,krimi,triler',158,CONVERT(datetime2,'2021-11-25'),CONVERT(datetime2,'2022-2-15'),390,5);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Dune','akcija,drama,naucna fantastike',155,CONVERT(datetime2,'2021-10-21'),CONVERT(datetime2,'2022-5-13'),390,6);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Matrix','akcija,naucna fantastika',148,CONVERT(datetime2,'2021-12-23'),CONVERT(datetime2,'2022-3-20'),290,6);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Spajdermen:Put bez povrtaka','akcija,naucna fantastika',146,CONVERT(datetime2,'2021-12-16'),CONVERT(datetime2,'2021-2-13'),290,6);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Gucijevi','drama,krimi,triler',158,CONVERT(datetime2,'2021-11-25'),CONVERT(datetime2,'2022-2-15'),390,6);
INSERT into Filmovi (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES('Nije lose biti covek','drama',104,CONVERT(datetime2,'2021-10-20'),CONVERT(datetime2,'2021-1-15'),290,5);
INSERT into Filmovi (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES('Nije lose biti covek','drama',104,CONVERT(datetime2,'2021-10-15'),CONVERT(datetime2,'2021-1-10'),290,6);

INSERT into Sale (Naziv,BrRedova,BrSedistaPoRedu,bioskopId) VALUES('Sala 1',10,10,5);
INSERT into Sale (Naziv,BrRedova,BrSedistaPoRedu,bioskopId) VALUES('Sala 2',7,5,5);
INSERT into Sale (Naziv,BrRedova,BrSedistaPoRedu,bioskopId) VALUES('Sala A',8,7,6);
INSERT into Sale (Naziv,BrRedova,BrSedistaPoRedu,bioskopId) VALUES('Sala B',5,10,6);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'16:40' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-23 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-23 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-23 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-23 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-23 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-23 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-23 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (23,CONVERT(datetime2,'2021-12-23 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-23 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-23 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-23 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-23 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-23 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-23 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-23 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (22,CONVERT(datetime2,'2021-12-23 10:00' ),8);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-24 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-24 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-24 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-24 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-24 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-24 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-24 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (23,CONVERT(datetime2,'2021-12-24 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-24 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-24 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-24 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-24 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-24 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-24 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (22,CONVERT(datetime2,'2021-12-24 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (22,CONVERT(datetime2,'2021-12-24 10:00' ),8);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-25 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-25 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-25 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-25 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-25 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-25 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-25 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (23,CONVERT(datetime2,'2021-12-25 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-25 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-25 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-25 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-25 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-25 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-25 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-25 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (22,CONVERT(datetime2,'2021-12-25 10:00' ),8);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-19 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-19 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-19 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-19 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-19 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-19 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-19 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (23,CONVERT(datetime2,'2021-12-19 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-19 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-19 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-19 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-19 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-19 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-19 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-19 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (22,CONVERT(datetime2,'2021-12-19 10:00' ),8);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-18 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (16,CONVERT(datetime2,'2021-12-18 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-18 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-18 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (17,CONVERT(datetime2,'2021-12-18 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-18 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (18,CONVERT(datetime2,'2021-12-18 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (23,CONVERT(datetime2,'2021-12-18 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-18 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (19,CONVERT(datetime2,'2021-12-18 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-18 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-18 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-18 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-18 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (21,CONVERT(datetime2,'2021-12-18 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (22,CONVERT(datetime2,'2021-12-18 10:00' ),8); 

Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Kings Man','akcija,avantura,komedija',131,CONVERT(datetime2,'2021-12-13 00:00:00'),CONVERT(datetime2,'2022-5-13 00:00:00'),290,5);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Matrix','akcija,naucna fantastika',148,CONVERT(datetime2,'2021-12-23'),CONVERT(datetime2,'2022-3-20'),290,5);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Spajdermen:Put bez povrtaka','akcija,naucna fantastika',146,CONVERT(datetime2,'2021-12-16'),CONVERT(datetime2,'2022-2-13'),290,5);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Gucijevi','drama,krimi,triler',158,CONVERT(datetime2,'2021-11-25'),CONVERT(datetime2,'2022-2-15'),390,5);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Dune','akcija,drama,naucna fantastike',155,CONVERT(datetime2,'2021-10-21'),CONVERT(datetime2,'2022-5-13'),390,6);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Matrix','akcija,naucna fantastika',148,CONVERT(datetime2,'2021-12-23'),CONVERT(datetime2,'2022-3-20'),290,6);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Spajdermen:Put bez povrtaka','akcija,naucna fantastika',146,CONVERT(datetime2,'2021-12-16'),CONVERT(datetime2,'2021-2-13'),290,6);
Insert into [dbo].[Filmovi] (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES ('Gucijevi','drama,krimi,triler',158,CONVERT(datetime2,'2021-11-25'),CONVERT(datetime2,'2022-2-15'),390,6);
INSERT into Filmovi (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES('Nije lose biti covek','drama',104,CONVERT(datetime2,'2021-10-20'),CONVERT(datetime2,'2021-1-15'),290,5);
INSERT into Filmovi (naziv,zanr,trajanje,datumKraja,datumPocetka,Cena,bioskopId) VALUES('Nije lose biti covek','drama',104,CONVERT(datetime2,'2021-10-15'),CONVERT(datetime2,'2021-01-10'),290,6);

update Filmovi set datumKraja=CONVERT(datetime2,'2022-5-13 00:00:00'),datumPocetka=CONVERT(datetime2,'2021-12-13 00:00:00') where id=25;
update Filmovi set datumKraja=CONVERT(datetime2,'2022-3-20'),datumPocetka=CONVERT(datetime2,'2021-12-23') where id=26;
update Filmovi set datumKraja=CONVERT(datetime2,'2022-2-13'),datumPocetka=CONVERT(datetime2,'2021-12-16') where id=27;
update Filmovi set datumKraja=CONVERT(datetime2,'2022-2-15'),datumPocetka=CONVERT(datetime2,'2021-11-25') where id=28;
update Filmovi set datumKraja=CONVERT(datetime2,'2022-5-13'),datumPocetka=CONVERT(datetime2,'2021-10-21') where id=29;
update Filmovi set datumKraja=CONVERT(datetime2,'2022-3-20'),datumPocetka=CONVERT(datetime2,'2021-12-23') where id=30;
update Filmovi set datumKraja=CONVERT(datetime2,'2022-2-15'),datumPocetka=CONVERT(datetime2,'2021-11-25') where id=32;


INSERT into Projkecije (filmId,vreme,salaId) VALUES (25,CONVERT(datetime2,'2021-12-23 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (25,CONVERT(datetime2,'2021-12-23 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (26,CONVERT(datetime2,'2021-12-23 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (26,CONVERT(datetime2,'2021-12-23 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-23 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-23 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-23 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (33,CONVERT(datetime2,'2021-12-23 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-23 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-23 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-23 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-23 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-23 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-23 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-23 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (32,CONVERT(datetime2,'2021-12-23 10:00' ),8);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (25,CONVERT(datetime2,'2021-12-24 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (25,CONVERT(datetime2,'2021-12-24 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-24 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-24 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-24 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-24 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-24 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (33,CONVERT(datetime2,'2021-12-24 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-24 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-24 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-24 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-24 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-24 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-24 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (32,CONVERT(datetime2,'2021-12-24 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (32,CONVERT(datetime2,'2021-12-24 10:00' ),8);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (26,CONVERT(datetime2,'2021-12-25 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (26,CONVERT(datetime2,'2021-12-25 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-25 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-25 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-25 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-25 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-25 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (33,CONVERT(datetime2,'2021-12-25 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-25 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-25 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-25 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-25 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-25 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-25 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-25 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (32,CONVERT(datetime2,'2021-12-25 10:00' ),8);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (26,CONVERT(datetime2,'2021-12-19 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (26,CONVERT(datetime2,'2021-12-19 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-19 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-19 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-19 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-19 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-19 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (33,CONVERT(datetime2,'2021-12-19 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-19 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-19 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (20,CONVERT(datetime2,'2021-12-19 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-19 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-19 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-19 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-19 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (32,CONVERT(datetime2,'2021-12-19 10:00' ),8);

INSERT into Projkecije (filmId,vreme,salaId) VALUES (26,CONVERT(datetime2,'2021-12-18 19:30' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (26,CONVERT(datetime2,'2021-12-18 22:20' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-18 15:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-18 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (27,CONVERT(datetime2,'2021-12-18 22:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-18 17:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (28,CONVERT(datetime2,'2021-12-18 12:00' ),5);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (33,CONVERT(datetime2,'2021-12-18 10:00' ),6);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-18 19:30' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (29,CONVERT(datetime2,'2021-12-18 22:20' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-18 15:00' ),8);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (30,CONVERT(datetime2,'2021-12-18 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-18 22:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-18 17:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (31,CONVERT(datetime2,'2021-12-18 12:00' ),7);
INSERT into Projkecije (filmId,vreme,salaId) VALUES (32,CONVERT(datetime2,'2021-12-18 10:00' ),8);

update sale set BrRedova=4,BrSedistaPoRedu=10 where id =5;