USE Senatur_Tarde;

INSERT INTO TiposUsuario(Titulo)
VALUES('Administrador'),
('Cliente');

INSERT INTO Usuarios(Email,Senha,IdTiposUsuario)
VALUES('admin@admin.com','admin',1),
('cliente@cliente.com','cliente',2);

INSERT INTO Pacotes(NomePacote,Descricao,DataIda,DataVolta,Valor,Ativo,NomeCidade)
VALUES('Viagei To Safe',' O Litoral Norte da Bahia conta com inúmeras praias emolduradas por coqueiros, além de piscinas naturais de águas mornas que são protegidas por recifes e habitadas por peixes coloridos. Banhos de mar em águas calmas ou agitadas, mergulho com snorkel, caminhada pela orla e calçadões, passeios de bicicleta, pontos turísticos históricos, interação com animais e até baladas estão entre as atrações da região. Destacam-se as praias de Guarajuba, Imbassaí','06/08/2020',' 10/08/2020','850.00',1,'Salvador'),
('PARTIU SALVADOR','O Litoral Norte da Bahia conta com inúmeras praias emolduradas por coqueiros, além de piscinas naturais de águas mornas que são protegidas por recifes e habitadas por peixes coloridos. Banhos de mar em águas calmas ou agitadas, mergulho com snorkel, caminhada pela orla e calçadões, passeios de bicicleta, pontos turísticos históricos, interação com animais e até baladas estão entre as atrações da região. Destacam-se as praias de Guarajuba, Imbassaí, Praia do Forte e Costa do Sauipe','14/05/2020','18/05/2020','1826.00',1,'Salvador'),
('to bonito agora',' Localizado no estado de Mato Grosso do Sul e ao sul do Pantanal, Bonito possui centenas de cachoeiras, rios e lagos de águas cristalinas, além de cavernas inundadas, paredões rochosos e uma infinidade de peixes. Os aventureiros costumam render-se facilmente a esse destino regado por trilhas ecológicas, passeios de bote e descidas de rapel pelas inúmeras quedas d água da região','28/03/2020',' 01/04/2020','1004.00',1,'Bonito');
