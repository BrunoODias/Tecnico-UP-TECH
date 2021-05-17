CREATE DATABASE DesafioRiachuello;
USE DesafioRiachuello;

CREATE TABLE Usuarios(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	UserName NVARCHAR(30) NOT NULL,
	Password NVARCHAR(500) NOT NULL,
	BirthDate DATETIME NOT NULL
);


--Senha Hash é: BRUNO123
INSERT INTO Usuarios(Name,Email,UserName,Password,BirthDate)
VALUES
('Bruno César Oliveira Dias', 'BrunoCesarODias@gmail.com', 'UserBruno1', '3d9e44e271744307e48ec38eb478184bac726b35fc10bab43c94c033480b7cbb', '27-09-2001'),
('Bruno 2', 'BrunoCesarODias2@gmail.com', 'UserBruno2', '3d9e44e271744307e48ec38eb478184bac726b35fc10bab43c94c033480b7cbb', '27-09-2001'),
('Bruno 3', 'BrunoCesarODias3@gmail.com', 'UserBruno3', '3d9e44e271744307e48ec38eb478184bac726b35fc10bab43c94c033480b7cbb', '27-09-2001'),
('Bruno 4', 'BrunoCesarODias4@gmail.com', 'UserBruno4', '3d9e44e271744307e48ec38eb478184bac726b35fc10bab43c94c033480b7cbb', '27-09-2001')

CREATE TABLE Favorites(
	IdUser INT FOREIGN KEY REFERENCES Usuarios(Id),
	Code NVARCHAR(200) NOT NULL,
	Name NVARCHAR(100) NOT NULL,
	Gender NVARCHAR(50) NOT NULL
)