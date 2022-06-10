using MySql.Data.MySqlClient;
using System;

namespace QuizCross
{
    class CreateDb
    {
        private string stringaConnMySql = "Server=localhost;Uid=root;Pwd=''";
        private string stringaConn = "Server=localhost;Database=quizcross;Uid=root;Pwd=''";
        
        public void CreaDb()
        {
            MySqlConnection conn = new MySqlConnection(stringaConnMySql);
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            conn.Open();
            com.CommandText = "CREATE DATABASE QuizCross";
            try
            {
                // non query perchè non interrogo il database , lo creo e basta
                com.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            conn.Close();
        }

        public void CreaTabelle()
        {
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            conn.Open();
            com.CommandText =
                "CREATE TABLE domanda(id_domanda int(11) NOT NULL,	testo varchar(80) NOT NULL, materia varchar(30) NOT NULL, PRIMARY KEY (id_domanda));" +
                "CREATE TABLE risposta(id_risposta int(11) NOT NULL,testo varchar(50) NOT NULL, domanda int(11), corretta tinyint(4) NOT NULL, PRIMARY KEY (id_risposta));" +
                "CREATE TABLE utente(username varchar(20) NOT NULL,	avatar varchar(20) NOT NULL, giocate int(4) NOT NULL, vittorie int(4) NOT NULL, PRIMARY KEY (username));" +
                "CREATE TABLE avatar(nome varchar(20) NOT NULL, PRIMARY KEY (nome));" +
                "ALTER TABLE risposta ADD CONSTRAINT fk_domanda FOREIGN KEY(domanda) REFERENCES domanda (id_domanda) ON DELETE CASCADE ON UPDATE CASCADE;" +
                "ALTER TABLE utente ADD CONSTRAINT fk_avatar FOREIGN KEY(avatar) REFERENCES avatar (nome) ON DELETE CASCADE ON UPDATE CASCADE;";
                      
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            /* non serve
            com.CommandText =
                "CREATE VIEW ClientiConFatture AS " +
                "SELECT Clienti.cod, Clienti.nome, Clienti.piva, Fatture.importoFattura " +
                "FROM Clienti INNER JOIN Fatture ON Clienti.cod = Fatture.cod " +
                "ORDER BY Clienti.nome;";*/
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            conn.Close();
        }

        public void PopolaTabelle()
        {
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            conn.Open();
            com.CommandText =

                //Geografia
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(1,'Capitale della Grecia?', 'Geografia');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(2,'Fiume piu lungo di Italia?', 'Geografia');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(5,'In che continente si trova il Nepal?', 'Geografia');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(11,'Quale tra questi stati non fa parte dell Unione Europea?', 'Geografia');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(10,'Qual è lo stato più grande al mondo?', 'Geografia');" +

                //Storia 
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(3,'Quanti furono i re di Roma?', 'Storia');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(4,'Anno di creazione del Regno di Italia?', 'Storia');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(8,'In che anno iniziò la Guerra in Jugoslavia?', 'Storia');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(12,'Quando finì la guerra del Vietnam?', 'Storia');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(13,'Quale tra questi stati non partecipò mai alle due Guerre Mondiali?', 'Storia');" +


                //Cinema
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(6,'In che anno uscì La vita è Bella di Benigni?', 'Cinema');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(7,'Come si chiamava il compagno di Terence Hill?', 'Cinema');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(9,'Con che film Di Caprio vinse il Oscar?', 'Cinema');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(14,'Quale tra questi film non è di Checco Zalone?', 'Cinema');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(15,'Come si chiamava il padre di Christian De Sica?', 'Cinema');" +


                //Sport
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(16,'In quanti si gioca nel rugby pù diffuso?', 'Sport');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(17,'Qual è l altro nome del calcio a 5?', 'Sport');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(18,'Da quali sport è formato il triathlon?', 'Sport');" +

                //Musica
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(19,'Chi era il catante dei Queen?', 'Musica');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(20,'Chi compose il Nabucco?', 'Musica');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(21,'Come faceva di nome Mozart?', 'Musica');" +

                //Vip
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(22,'Con chi ha fatto un figlio Belen Rodriguez?', 'Vip');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(23,'Chi conduce 4 ristoranti con Alessandro Borghese?', 'Vip');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(24,'A quale religione appartiene Tom Cruise?', 'Vip');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(25,'Chi è la compagna di Matteo Salvini?', 'Vip');" +

                //Cultura Generale
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(26,'Come si chiamano le 5 dita dei piedi?', 'Cultura Generale');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(27,'Qual è il record del mondo di risluzione del cubo di rubik?', 'Cultura Generale');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(28,'Da cosa deriva il nome Fedora?', 'Cultura Generale');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(29,'I pesci hanno sete?', 'Cultura Generale');" +

                //Informatica
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(30,'Chi ha prodotto il Macintosh?', 'Informatica');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(31,'Come si chiamava il co-fondatore di Apple?', 'Informatica');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(32,'Qual è il linguaggio di programmazione più usato?', 'Informatica');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(33,'Qual è il linguaggio di programmazione di excel?', 'Informatica');" +

                //Scienze
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(34,'Qual tra questi è un mammifero?', 'Scienze');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(35,'Quali tra questi non è un gas nobile?', 'Scienze');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(36,'Qual è il pianeta più piccolo del sistema solare?', 'Scienze');" +
                "INSERT INTO domanda (id_domanda,testo,materia) VALUES(37,'Come si chiama la teoria enunciata da Einstein', 'Scienze');" +

            //Risposte

            //Geografia
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(5,'Adige', 2, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(6,'Po', 2, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(7,'Tevere', 2, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(8,'Arno', 2, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(1,'Atene', 1, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(2,'Roma', 1, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(3,'Salonicco', 1, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(4,'Budapest', 1, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(17,'Africa', 5, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(18,'Oceania', 5, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(19,'Europa', 5, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(20,'Asia', 5, 1);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(38,'Brasile', 10, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(39,'Cina', 10, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(40,'India', 10, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(41,'Russia', 10, 1);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(42,'Croazia', 11, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(43,'Malta', 11, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(44,'Svizzera', 11, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(45,'Romania', 11, 0);" +

                //Storia

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(9,'5', 3, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(10,'7', 3, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(11,'8', 3, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(12,'6', 3, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(13,'1861', 4, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(14,'1859', 4, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(15,'1863', 4, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(16,'1871', 4, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(46,'1975', 12, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(47,'1972', 12, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(48,'1977', 12, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(49,'1974', 12, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(50,'Portogallo', 13, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(51,'Svizzera', 13, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(52,'Italia', 13, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(53,'Austria', 13, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(30,'1992', 8, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(31,'1988', 8, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(32,'1994', 8, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(33,'1991', 8, 1);" +

                //Cinema

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(21,'1996', 6, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(22,'1993', 6, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(23,'1997', 6, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(24,'1999', 6, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(25,'Bud Spencer', 7, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(26,'Alessandro Gassman', 7, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(27,'John Wayne', 7, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(29,'Vittorio De Sica', 7, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(34,'The Wolf of Walt Street', 9, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(35,'Revenant', 9, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(36,'Django', 9, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(37,'Titanic', 9, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(54,'Quo Vado', 14, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(55,'Sole a catinelle', 14, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(56,'Cado dalle nubi', 14, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(57,'Belli di papa', 14, 1);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(58,'Vittorio', 15, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(59,'Luca', 15, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(60,'Sandro', 15, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(86,'Alessandro', 15, 0);" +

                //Sport

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(62,'13', 16, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(63,'15', 16, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(64,'11', 16, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(65,'17', 16, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(66,'Pallacalcio', 17, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(67,'Calcio fiorentino', 17, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(68,'Calcio a 7', 17, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(69,'Futsal', 17, 1);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(70,'Calcio,Corsa,Bici', 18, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(71,'Nuoto,Corsa,Bici', 18, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(72,'Sci,Corsa,Bici', 18, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(73,'Nuoto,Corsa,Golf', 18, 0);" +

                //Musica

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(74,'Freddie Mercury', 19, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(75,'Louis Armstrong', 19, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(76,'Lady Gaga', 19, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(77,'Bono', 19, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(78,'Vivaldi', 20, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(79,'Puccini', 20, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(80,'Verdi', 20, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(81,'Bach', 20, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(82,'Louis', 21, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(83,'Wolfang Amadeus', 21, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(84,'Joseph', 21, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(85,'Karl', 21, 0);" +

                //vip

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(87,'Stefano De Martino', 22, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(88,'Andrea Iannone', 22, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(89,'Marco Boriello', 22, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(90,'Fabrizio Corona', 22, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(91,'Maurizio Meluzzo', 23, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(92,'Alessandro Borghi', 23, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(93,'Alessandro Borghese', 23, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(94,'Carlo Cracco', 23, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(95,'Scientologi', 24, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(96,'Cattolico', 24, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(97,'Satanista', 24, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(98,'Testimoni di Geova', 24, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(99,'Francesca Clerici', 25, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(100,'Isabella Sandrini', 25, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(101,'Francesca Isoardi', 25, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(102,'Isabella Isoardi', 25, 1);" +

                 
                //cultura genreale

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(103,'Alluce-Illice-Trillice-Pondolo-Mellino', 26, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(104,'Alluce-Illice-Trillice-Pondolo-Mignolo', 26, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(105,'Alluce-Illice-Trillice-Pondolo-Mignolino', 26, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(106,'Pollicione-Illice-Trillice-Pondolo-Mellino', 26, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(107,'3,22', 27, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(108,'3,47', 27, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(109,'3,46', 27, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(110,'3,45', 27, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(111,'Marc Fedor', 28, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(112,'Borsalino', 28, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(113,'Borsellino', 28, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(114,'John Fedora', 28, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(115,'No', 29, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(116,'Non si sa', 29, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(117,'Si', 29, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(118,'Dipende se sono di acqua dolce o salata', 29, 0);" +

                //Informatica

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(119,'Apple', 30, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(120, 'IBM', 30, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(121,'Lenovo', 30, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(122,'Asus', 30, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(123,'Steve Jobs', 31, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(124,'Steve Wozniak', 31, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(125,'Tim Berners-Lee', 31, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(126,'C++', 31, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(127,'Phyton', 32, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(128,'Java', 32, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(129,'C', 32, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(130,'Assembly', 32, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(131,'C#', 33, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(132,'Visual Basic', 33, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(133,'Php', 33, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(134,'Phyton', 33, 0);" +

                //Scienze

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(135,'Delfino', 34, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(136,'Piccione', 34, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(137,'Pesce palla', 34, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(138,'Cavalluccio marino', 34, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(139,'Elio', 35, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(140,'Cadmio', 35, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(141,'Argon', 35, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(142,'Neon', 35, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(143,'Marte', 36, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(144,'Saturno', 36, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(145,'Plutone', 36, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(146,'Venere', 36, 0);" +

                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(147,'Relatività', 37, 1);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(148,'Degli universi paralleli', 37, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(149,'Delle Stringhe', 37, 0);" +
                "INSERT INTO risposta (id_risposta,testo,domanda, corretta) VALUES(150,'Dei buchi neri', 37, 0);" +

                "INSERT INTO avatar (nome) VALUES('uomo');" +
                "INSERT INTO avatar (nome) VALUES('donna');";

            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            conn.Close();
        }

        public void DropDb()
        {
            
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            conn.Open();
            com.CommandText = "DROP DATABASE quizcross";
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            conn.Close();

        } 
    }
}

