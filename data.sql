CREATE DATABASE football_clubs
USE footbal_clubs

CREATE TABLE Clubs(
club_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nation_id INT NOT NULL,
club_name VARCHAR(255) NOT NULL,
club_creation_date INT NOT NULL,
club_ceo_name VARCHAR(255) NOT NULL);


CREATE TABLE Nations(
nation_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nation_name VARCHAR(255) NOT NULL);

INSERT INTO Nations(nation_name) VALUES ('Hiszpania');
INSERT INTO Nations(nation_name) VALUES ('Wielka Brytania');
INSERT INTO Nations(nation_name) VALUES ('Polska');
INSERT INTO Nations(nation_name) VALUES ('Niemcy');
INSERT INTO Nations(nation_name) VALUES ('Francja');
INSERT INTO Nations(nation_name) VALUES ('Portugalia');

INSERT INTO Clubs (nation_id, club_name, club_creation_date,club_ceo_name) VALUES (1,'Real Madryt',1902,'Florentino Perez');
INSERT INTO Clubs (nation_id, club_name, club_creation_date,club_ceo_name) VALUES (2,'Manchester United F.C.',1878,'Joel i Avram Glazer');
INSERT INTO Clubs (nation_id, club_name, club_creation_date,club_ceo_name) VALUES (3,'Legia Warszawa',1927,'Dariusz Mioduski');
INSERT INTO Clubs (nation_id, club_name, club_creation_date,club_ceo_name) VALUES (4,'Bayern Monachium',1900,'Herbert Hainer');

ALTER TABLE Clubs ADD constraint fk_clubs_nation_id FOREIGN KEY (nation_id) REFERENCES Nations(nation_id);

CREATE TABLE Players(
player_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
player_name VARCHAR(255) NOT NULL,
player_surname VARCHAR(255) NOT NULL,
player_birthyear INT NOT NULL,
club_id INT,
nation_id INT NOT NULL,
player_image VARBINARY(max));

ALTER TABLE Players ADD constraint fk_players_nation_id FOREIGN KEY (nation_id) REFERENCES Nations(nation_id);
ALTER TABLE Players ADD constraint fk_players_club_id FOREIGN KEY (club_id) REFERENCES Clubs(club_id);

INSERT INTO Players (player_name, player_surname, player_birthyear,club_id,nation_id) VALUES ('Zinedine','Zidane',1972,1,5);
INSERT INTO Players (player_name, player_surname, player_birthyear,club_id,nation_id) VALUES ('David','Beckham',1975,1,2);
INSERT INTO Players (player_name, player_surname, player_birthyear,club_id,nation_id) VALUES ('Wayne','Rooney',1985,2,2);
INSERT INTO Players (player_name, player_surname, player_birthyear,club_id,nation_id) VALUES ('Cristiano','Ronaldo',1985,2,6);
INSERT INTO Players (player_name, player_surname, player_birthyear,club_id,nation_id) VALUES ('Artur','Boruc',1980,3,3);
INSERT INTO Players (player_name, player_surname, player_birthyear,club_id,nation_id) VALUES ('Mateusz','Wieteska',1997,3,3);
INSERT INTO Players (player_name, player_surname, player_birthyear,club_id,nation_id) VALUES ('Robert','Lewandowski',1988,4,3);
INSERT INTO Players (player_name, player_surname, player_birthyear,club_id,nation_id) VALUES ('Manuel','Neuer',1986,4,4);