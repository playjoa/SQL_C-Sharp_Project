REM   Script: Projeto Banco de Dados 1 - Joao Milone
REM   Base traduzida do MysSQL para SQL Live (João Milone)

CREATE TABLE Usuario  
( 
	idUser NUMBER(5) CONSTRAINT Usuario_pk PRIMARY KEY, 
	email VARCHAR2(30), 
	senha VARCHAR2(30), 
	nomeUser VARCHAR2(30), 
	descUser VARCHAR2(350), 
	data_nasc VARCHAR2(30),	 
	sexo VARCHAR2(30) 
);

CREATE TABLE Developer 
( 
	idDev NUMBER(5) CONSTRAINT Developer_pk PRIMARY KEY, 
	idUser NUMBER(5) CONSTRAINT Usuario_fk REFERENCES Usuario(idUser)	 
);

CREATE TABLE Jogo 
( 
	idJogo  NUMBER(5) CONSTRAINT Jogo_pk PRIMARY KEY, 
	idDev  NUMBER(5) CONSTRAINT Developer_fk REFERENCES Developer(idDev), 
	nomeJogo VARCHAR2(30), 
	descJogo VARCHAR2(350), 
	dataLancamento VARCHAR2(30) 
);

CREATE TABLE JogaJogo 
( 
	idJogo NUMBER(5) CONSTRAINT JogaJogo_fk REFERENCES Jogo(idJogo), 
	idUser NUMBER(5) CONSTRAINT UsuarioJoga_fk REFERENCES Usuario(idUser), 
	valorScore  NUMBER(10) 
);

CREATE TABLE AvaliaJogo 
( 
	idJogo NUMBER(5) CONSTRAINT AvaliaJogo_fk REFERENCES Jogo(idJogo), 
	idUser NUMBER(5) CONSTRAINT UsuarioAvalia_fk REFERENCES Usuario(idUser), 
	notaAvaliacao  NUMBER(1), 
	comentario VARCHAR2(350) 
);

INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUES (1, 'joao@hotmail.com', '12345', 'Playjoa', 'Jogador de Games', '11/05/1997', 'Masculino');

INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUES (2, 'rockstar@hotmail.com', '12345', 'RockStar Games', 'Desenvolvedora do GTA', '11/05/1997', 'Masculino');

INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUES (3, 'ubisoft@hotmail.com', '12345', 'Ubisoft France', 'Desenvolvedora de jogos bugados!', '11/05/1997', 'Masculino');

INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUES (4, 'santamonica@hotmail.com', '12345', 'Santa Monica Studios', 'Desenvolvedora do GOD OF WAR', '11/05/1997', 'Masculino');

INSERT INTO Usuario (idUser, email, senha, nomeUser, descUser, data_nasc, sexo) VALUES (5, 'jogador@hotmail.com', '12345', 'Gamer de PC', 'Tento bater todos os recordes', '11/05/1997', 'Masculino');

INSERT INTO Developer (idDev, idUser) VALUES (1, 2);

INSERT INTO Developer (idDev, idUser) VALUES (2, 3);

INSERT INTO Developer (idDev, idUser) VALUES (3, 4);

INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUES (1, 1, 'GTA 5', 'Viva uma vida tranquila em LosAngeles!', '11/05/2013');

INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUES (2, 1, 'Red Dead 2', 'Sobreviva no velho Oeste!', '11/05/2018');

INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUES (3, 1, 'Max Payne 3', 'Busque Vinganca em Sao Paulo!', '11/05/2009');

INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUES (4, 2, 'Far Cry 1', 'Uma ilha misteriosa cheia de perigos!', '11/05/2002');

INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUES (5, 2, 'Far Cry 2', 'Uma savana cheia de perigos!', '11/05/2005');

INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUES (6, 2, 'Far Cry 3', 'Devolta a uma ilha com mais coisas perigosas ainda!', '11/05/2013');

INSERT INTO Jogo (idJogo, idDev, nomeJogo, descJogo, dataLancamento) VALUES (7, 3, 'God of War', 'Kratos grita garoto 3 vezes a cada 10 minutos', '11/05/2019');

INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUES (1, 1, 5678);

INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUES (1, 2, 981);

INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUES (1, 3, 9281);

INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUES (1, 4, 873);

INSERT INTO JogaJogo (idJogo, idUser, valorScore) VALUES (1, 5, 10);

INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUES (1, 1, 5, 'Muito divertido! Recomendo!');

INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUES (1, 2, 4, 'Tem alguns bugs mas recomendo!');

INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUES (1, 3, 1, 'Poderia ter sido melhor!');

INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUES (1, 4, 2, 'Nao rodou, arrumem isso!');

INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUES (1, 5, 3, 'Poderia ter sido uma obra prima!!');

SELECT u.nomeUser FROM Usuario u INNER JOIN Developer d ON u.idUser = d.idUser;

SELECT u.nomeUser FROM Usuario u INNER JOIN Developer d ON u.idUser = d.idUser INNER JOIN Jogo j ON j.idDev = d.idDev WHERE j.idJogo = '1';

SELECT u.nomeUser FROM Usuario u INNER JOIN JogaJogo j ON u.idUser = j.idUser WHERE j.valorScore = '';

SELECT u.nomeUser, a.notaAvaliacao, a.comentario FROM Usuario u INNER JOIN AvaliaJogo a ON u.idUser = a.idUser WHERE a.idJogo = 0;

SELECT u.nomeUser FROM Usuario u INNER JOIN JogaJogo j ON u.idUser = j.idUser WHERE j.valorScore = '';

SELECT * FROM usuario WHERE email = '1';

SELECT nomeJogo FROM Jogo;

SELECT idUser, nomeUser FROM Usuario WHERE  email ='joao@hotmail.com' AND senha = '12345';

SELECT AVG(notaAvaliacao) FROM AvaliaJogo WHERE idJogo  ='1';

SELECT MAX(valorScore) FROM JogaJogo WHERE idJogo  ='1';

SELECT * FROM JogaJogo WHERE idJogo = 1;

SELECT Count(*) FROM JogaJogo WHERE idJogo = 3;

