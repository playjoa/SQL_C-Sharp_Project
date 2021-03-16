/*

Projeto de João Milone
Linguagem MySQL
Implementado com C# 
Desenvolvido no Visual Studios

Configuracoes para o MySQL:
Server: localhost
Username: root
Password: 12345
Database: highscoresTable

--------------------------------

Usuarios:
joao@hotmail.com
jogador@hotmail.com

--------------------------------

Usuarios que são DEV
rockstar@hotmail.com
ubisoft@hotmail.com
santamonica@hotmail.com

Senha Inicial para todos os usuarios pré cadastrados: 
12345

*/

DROP DATABASE IF EXISTS highscoresTable;
CREATE DATABASE highscoresTable;
USE highscoresTable;

CREATE TABLE IF NOT EXISTS Usuario 
(
	idUser INT UNSIGNED NOT NULL AUTO_INCREMENT,
	email TEXT NOT NULL,
	senha TEXT NOT NULL,
	nomeUser TEXT NOT NULL,
	descUser TEXT NOT NULL,
	data_nasc TEXT NOT NULL,	
	sexo TEXT NOT NULL,

	PRIMARY KEY (idUser)
);

CREATE TABLE IF NOT EXISTS Developer
(
	idDev INT UNSIGNED NOT NULL AUTO_INCREMENT,
	idUser INT UNSIGNED NOT NULL,
	
	PRIMARY KEY (idDev),
	FOREIGN KEY(idUser) REFERENCES Usuario (idUser) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Jogo
(
	idJogo INT UNSIGNED NOT NULL AUTO_INCREMENT,
	idDev INT UNSIGNED NOT NULL,
	nomeJogo TEXT NOT NULL,
	descJogo TEXT NOT NULL,
	dataLancamento TEXT,

	PRIMARY KEY (idJogo),
	FOREIGN KEY(idDev) REFERENCES Developer (idDev) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS JogaJogo
(
	idJogo INT UNSIGNED NOT NULL,
	idUser INT UNSIGNED NOT NULL,
	valorScore INT UNSIGNED NOT NULL,
	
	FOREIGN KEY(idJogo) REFERENCES Jogo (idJogo) ON DELETE CASCADE,
	FOREIGN KEY(idUser) REFERENCES Usuario (idUser) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS AvaliaJogo
(
	idJogo INT UNSIGNED NOT NULL,
	idUser INT UNSIGNED NOT NULL,
	notaAvaliacao INT UNSIGNED NOT NULL,
	comentario TEXT NOT NULL,

	FOREIGN KEY(idJogo) REFERENCES Jogo (idJogo) ON DELETE CASCADE,
	FOREIGN KEY(idUser) REFERENCES Usuario (idUser) ON DELETE CASCADE	
);



# Inserindo Usuarios
INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUE (0, 'joao@hotmail.com', '12345', 'Playjoa', 'Jogador de Games', '11/05/1997', 'Masculino');
INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUE (0, 'rockstar@hotmail.com', '12345', 'RockStar Games', 'Desenvolvedora do GTA', '11/05/1997', 'Masculino');
INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUE (0, 'ubisoft@hotmail.com', '12345', 'Ubisoft France', 'Desenvolvedora de jogos bugados!', '11/05/1997', 'Masculino');
INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUE (0, 'santamonica@hotmail.com', '12345', 'Santa Monica Studios', 'Desenvolvedora do GOD OF WAR', '11/05/1997', 'Masculino');
INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUE (0, 'jogador@hotmail.com', '12345', 'Gamer de PC', 'Tento bater todos os recordes', '11/05/1997', 'Masculino');


# Inserindo DEVELOPERS
INSERT INTO Developer (idDev, idUser) VALUE (0, 2);
INSERT INTO Developer (idDev, idUser) VALUE (0, 3);
INSERT INTO Developer (idDev, idUser) VALUE (0, 4);

# Inserindo Jogos
INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUE (0, 1, 'GTA 5', 'Viva uma vida tranquila em LosAngeles!', '11/05/2013');
INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUE (0, 1, 'Red Dead 2', 'Sobreviva no velho Oeste!', '11/05/2018');
INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUE (0, 1, 'Max Payne 3', 'Busque Vinganca em Sao Paulo!', '11/05/2009');
INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUE (0, 2, 'Far Cry 1', 'Uma ilha misteriosa cheia de perigos!', '11/05/2002');
INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUE (0, 2, 'Far Cry 2', 'Uma savana cheia de perigos!', '11/05/2005');
INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUE (0, 2, 'Far Cry 3', 'Devolta a uma ilha com mais coisas perigosas ainda!', '11/05/2013');
INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUE (0, 3, 'God of War', 'Kratos grita garoto 3 vezes a cada 10 minutos', '11/05/2019');

# Inserindo SCORES
INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUE (1, 1, 5678);
INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUE (1, 2, 981);
INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUE (1, 3, 9281);
INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUE (1, 4, 873);
INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUE (1, 5, 10);


# Inserindo Avaliacoes
INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUE (1, 1, 5, 'Muito divertido! Recomendo!');
INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUE (1, 2, 4, 'Tem alguns bugs mas recomendo!');
INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUE (1, 3, 1, 'Poderia ter sido melhor!');
INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUE (1, 4, 2, 'Nao rodou, arrumem isso!');
INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUE (1, 5, 3, 'Poderia ter sido uma obra prima!!');


SELECT u.nomeUser FROM Usuario u INNER JOIN Developer d ON u.idUser = d.idUser;

SELECT u.nomeUser FROM Usuario u INNER JOIN Developer d ON u.idUser = d.idUser INNER JOIN Jogo j ON j.idDev = d.idDev WHERE j.idJogo = '1';

SELECT u.nomeUser FROM Usuario u INNER JOIN JogaJogo j ON u.idUser = j.idUser WHERE j.valorScore = '';

SELECT u.nomeUser, a.notaAvaliacao, a.comentario FROM Usuario u INNER JOIN AvaliaJogo a ON u.idUser = a.idUser WHERE a.idJogo = 0;

SELECT u.nomeUser FROM Usuario u INNER JOIN JogaJogo j ON u.idUser = j.idUser WHERE j.valorScore = '';

SELECT * FROM usuario WHERE email = '1';

SELECT nomeJogo FROM Jogo;

SELECT idUser, nomeUser FROM Usuario WHERE  email ='joao@hotmail.com' AND senha = '123';

SELECT AVG(notaAvaliacao) 'media' FROM AvaliaJogo WHERE idJogo  ='1';

UPDATE Usuario SET email = '', nomeUser = '', descUser = '', sexo = '', data_nasc = ''  WHERE idUser='';

SELECT MAX(valorScore) 'maiorScore' FROM JogaJogo WHERE idJogo  ='1';

SELECT * FROM JogaJogo WHERE idJogo = 1;

SELECT Count(*) FROM JogaJogo WHERE idJogo = 3;
