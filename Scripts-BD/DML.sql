USE Senatur_Tarde;

INSERT INTO TiposUsuario(Titulo)
VALUES('Administrador'),
('Cliente');

INSERT INTO Usuarios(Email,Senha,IdTiposUsuario)
VALUES('admin@admin.com','admin',1),
('cliente@cliente.com','cliente',2);

INSERT INTO Pacotes(NomePacote,Descricao,DataIda,DataVolta,Valor,Ativo,NomeCidade)
VALUES('Viagei To Safe',' O Litoral Norte da Bahia conta com in�meras praias emolduradas por coqueiros, al�m de piscinas naturais de �guas mornas que s�o protegidas por recifes e habitadas por peixes coloridos. Banhos de mar em �guas calmas ou agitadas, mergulho com snorkel, caminhada pela orla e cal�ad�es, passeios de bicicleta, pontos tur�sticos hist�ricos, intera��o com animais e at� baladas est�o entre as atra��es da regi�o. Destacam-se as praias de Guarajuba, Imbassa�','06/08/2020',' 10/08/2020','850.00',1,'Salvador'),
('PARTIU SALVADOR','O Litoral Norte da Bahia conta com in�meras praias emolduradas por coqueiros, al�m de piscinas naturais de �guas mornas que s�o protegidas por recifes e habitadas por peixes coloridos. Banhos de mar em �guas calmas ou agitadas, mergulho com snorkel, caminhada pela orla e cal�ad�es, passeios de bicicleta, pontos tur�sticos hist�ricos, intera��o com animais e at� baladas est�o entre as atra��es da regi�o. Destacam-se as praias de Guarajuba, Imbassa�, Praia do Forte e Costa do Sauipe','14/05/2020','18/05/2020','1826.00',1,'Salvador'),
('to bonito agora',' Localizado no estado de Mato Grosso do Sul e ao sul do Pantanal, Bonito possui centenas de cachoeiras, rios e lagos de �guas cristalinas, al�m de cavernas inundadas, pared�es rochosos e uma infinidade de peixes. Os aventureiros costumam render-se facilmente a esse destino regado por trilhas ecol�gicas, passeios de bote e descidas de rapel pelas in�meras quedas d �gua da regi�o','28/03/2020',' 01/04/2020','1004.00',1,'Bonito');
