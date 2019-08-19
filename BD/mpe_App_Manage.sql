CREATE DATABASE IF NOT EXISTS FGM_pastor_db;

CREATE TABLE IF NOT EXISTS `formations` (
  `codeFormation` VARCHAR(60) NOT NULL,
  `nomInstitus` VARCHAR(60) NOT NULL,
  `typeFormation` VARCHAR(60) NOT NULL,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codeFormation` (`codeFormation`)
) ENGINE=INNODB DEFAULT CHARSET=utf8;





CREATE TABLE IF NOT EXISTS `membre` (
  `mleMembre` VARCHAR(60) NOT NULL,
  `nomMembre` VARCHAR(60) NOT NULL,
  `prenomMembre` VARCHAR(60) NOT NULL,
  `dateNaissMembre` DATE NOT NULL,
  `lieuNaissMembre` VARCHAR(60) NOT NULL,
  `nomPereMembre` VARCHAR(60) NOT NULL,
   sexePersonne ENUM('F','M') DEFAULT 'M',
  `prenomPereMembre` VARCHAR(60) NOT NULL,
   telephoneMembre VARCHAR(60),
   email VARCHAR(60),
  `nomMereMembre` VARCHAR(60) NOT NULL,
  `prenomMereMembre` VARCHAR(60) NOT NULL,
  `dateConversion` DATE DEFAULT NULL,
  `nbreEnfant` INT(11) DEFAULT 0,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
   isDelete INT(1),
  PRIMARY KEY (`mleMembre`),
  UNIQUE KEY `id` (`id`)
) ENGINE=INNODB DEFAULT CHARSET=utf8;





DROP TABLE IF EXISTS `domaineAppel`;
CREATE TABLE IF NOT EXISTS `domaineAppel` (
  `codeDomaineAppel` VARCHAR(60) NOT NULL,
  `libelleDomaineAppel` VARCHAR(60) NOT NULL,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`codedomaineAppel`),
  UNIQUE KEY `id` (`id`)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



DROP TABLE IF EXISTS `missionnaire`;
CREATE TABLE IF NOT EXISTS `missionnaire` (
  `mleMissionnaire` VARCHAR(60) NOT NULL,
  `professionAvantEcoleBible` VARCHAR(60) NOT NULL,
  `positionAProbation` VARCHAR(60) NOT NULL,
  `photoProfil` TEXT NULL ,
  `disponibiliteMissionnaire` TINYINT(1) DEFAULT NULL,
  `raisonIndispoMissionnaire` TEXT DEFAULT NULL,
   missionMleMembre VARCHAR(60) NOT NULL,
   isDelete INT(1),
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  CONSTRAINT pk_missionnaire PRIMARY KEY (`mleMissionnaire`),
  UNIQUE KEY `id` (`id`),
  CONSTRAINT fk_missionnaire FOREIGN KEY(missionMleMembre) REFERENCES membre(mleMembre)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



DROP TABLE IF EXISTS `avoirDomaineAppel`;
CREATE TABLE IF NOT EXISTS `avoirDomaineAppel`(
  `numDomaineAppel` VARCHAR(60) NOT NULL,
  `mleMissionnaire` VARCHAR(60) NOT NULL,
  `codedomaineAppel` VARCHAR(60) NOT NULL,
  `date_debut` DATE NOT NULL,
  `date_fin` DATE DEFAULT NULL,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`numDomaineAppel`),
  UNIQUE KEY `id` (`id`),
  CONSTRAINT `fk_avoirdomaine1` FOREIGN KEY (`mleMissionnaire`) REFERENCES missionnaire(mleMissionnaire),
  CONSTRAINT fk_avoirdomaine2 FOREIGN KEY (`codeDomaineAppel`) REFERENCES domaineAppel(codeDomaineAppel)
) ENGINE=INNODB DEFAULT CHARSET=utf8;


CREATE TABLE typeDivisionAdmin(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
libelleDivAdmin VARCHAR(60) NOT NULL
)ENGINE=INNODB DEFAULT CHARSET=utf8;




CREATE TABLE IF NOT EXISTS `divisionAdministrative` (
  `codeDivAdmin` VARCHAR(60) NOT NULL,
  `libelleDivAdmin` VARCHAR(60) NOT NULL,
  `typeDivAdmin` INT NOT NULL,
   codeDivAdminParent VARCHAR(60) NOT NULL DEFAULT 'empty',
   isDelete INT(1) NOT NULL DEFAULT 0,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`codeDivAdmin`),
  UNIQUE KEY `id` (`id`),
  CONSTRAINT fk_divisionAdminParent FOREIGN KEY(codeDivAdminParent) REFERENCES divisionAdministrative(`codeDivAdmin`),
  CONSTRAINT fk_divisionAdmin FOREIGN KEY(typeDivAdmin) REFERENCES typeDivisionAdmin(`id`)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



CREATE TABLE IF NOT EXISTS `faireFormation` (
  `reffFormation` VARCHAR(60) NOT NULL,
  `codeFormationFaite` VARCHAR(60) NOT NULL,
  `mleMembreForm` VARCHAR(60) NOT NULL,
  `date_graduation` DATE NOT NULL,
  `qualification` VARCHAR(60) NOT NULL,
  `diplomeSeculaire` VARCHAR(60) NOT NULL,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`reffFormation`),
  UNIQUE KEY `id` (`id`),
  CONSTRAINT fk_faire_formation FOREIGN KEY(`codeFormationFaite`) REFERENCES formations(`codeFormation`),
  CONSTRAINT fk_membre_faire_formation FOREIGN KEY(`mleMembreForm`) REFERENCES membre(`mleMembre`)
) ENGINE=INNODB DEFAULT CHARSET=utf8;


CREATE TABLE IF NOT EXISTS `statutmatrimonial` (
  `libelleStatut` VARCHAR(60) NOT NULL,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



CREATE TABLE IF NOT EXISTS `Station` (
 
   photoStation TEXT,
   codeDivAdminParent VARCHAR(60) NOT NULL DEFAULT 'empty',
   isDelete INT(1) NOT NULL DEFAULT 0,
  `id` INT NOT NULL AUTO_INCREMENT,
   PRIMARY KEY (`codeStation`),
   UNIQUE KEY `id` (`id`),
   CONSTRAINT fk_divisionAdminParent FOREIGN KEY(codeDivAdminParent) REFERENCES divisionAdministrative(`codeDivAdmin`)
  )ENGINE=INNODB DEFAULT CHARSET=utf8;


DROP TABLE IF EXISTS `avoirstatutmatrimonial`;
CREATE TABLE IF NOT EXISTS `avoirstatutmatrimonial` (
  `numAvoirStatutMatri` VARCHAR(60) NOT NULL,
   mleMembreAvoirStatutmatri VARCHAR(60) NOT NULL,
  `codeStatutMatri` INT NOT NULL,
  `dateDebutStatutMatri` DATE NOT NULL,
  `dateFinStatutMatri` DATE DEFAULT NULL,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`numAvoirStatutMatri`),
  UNIQUE KEY `id` (`id`),
  CONSTRAINT fk_Membre_mle_avoirStatut FOREIGN KEY (mleMembreAvoirStatutMatri) REFERENCES membre(mleMembre),
  CONSTRAINT fk_statutMatri_code FOREIGN KEY  (`codeStatutMatri`) REFERENCES statutmatrimonial(id)
) ENGINE=INNODB DEFAULT CHARSET=utf8;




CREATE TABLE IF NOT EXISTS `transfererMembreStations` (
  `refferenceTransfertStation` VARCHAR(60) NOT NULL,
  `codeStationTransfert` VARCHAR(60) NOT NULL,
  `mleMembreTransfert` VARCHAR(60) NOT NULL,
  `dateTransfert` DATE NOT NULL,
  `dateDepart` DATE DEFAULT NULL,
  `positionOccuper` VARCHAR(60) NOT NULL,
   statusTranfert VARCHAR(60) NOT NULL DEFAULT 'Encours',
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`refferenceTransfertStation`),
  UNIQUE KEY `id` (`id`),
  CONSTRAINT fk_station_de_transfert FOREIGN KEY (codeStationTransfert) REFERENCES station(codeStation),
  CONSTRAINT fk_Membre_transferer FOREIGN KEY (mleMembreTransfert) REFERENCES membre(mleMembre)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



CREATE TABLE IF NOT EXISTS `MembreEpouserMembre` (
  `reffMariage` VARCHAR(60) NOT NULL,
   mleMembreEpoux VARCHAR(60) NOT NULL,
  `mleMembreEpouse` VARCHAR(60) NOT NULL,
  `dateMariage` DATE,
   statutMariage VARCHAR(60) NOT NULL DEFAULT 'Encours',
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`reffMariage`),
  UNIQUE KEY `id` (`id`),
  CONSTRAINT fk_Membre_mariage_epoux FOREIGN KEY (mleMembreEpoux) REFERENCES membre(mleMembre),
  CONSTRAINT fk_Membre_mariage_epouse FOREIGN KEY (mleMembreEpouse) REFERENCES membre(mleMembre)
) ENGINE=INNODB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `MembreEnfanterMembre` (
  `reffMariage` VARCHAR(60) NOT NULL,
   mleMembreEnfant VARCHAR(60) NOT NULL,
  `mleMembreGeniteur` VARCHAR(60) NOT NULL,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`reffMariage`),
  UNIQUE KEY `id` (`id`),
  CONSTRAINT fk_Membre_mariage_enfanter FOREIGN KEY (mleMembreEnfant) REFERENCES membre(mleMembre),
  CONSTRAINT fk_Membre_mariage_geniteur FOREIGN KEY (mleMembreGeniteur) REFERENCES membre(mleMembre)
) ENGINE=INNODB DEFAULT CHARSET=utf8;


CREATE TABLE IF NOT EXISTS `message` (
  `refferenceMessage` VARCHAR(60) NOT NULL,
  `messageTitle` VARCHAR(75) NOT NULL,
  `messageContent` TEXT NOT NULL,
  `mleSendermessage` VARCHAR(12) NOT NULL,
   MessageType VARCHAR(60) NOT NULL DEFAULT 'private',
  `dateEnvoie` DATE NOT NULL,
   id INT(11) NOT NULL AUTO_INCREMENT,
   UNIQUE KEY id(id),
  PRIMARY KEY (`refferenceMessage`),
  CONSTRAINT fk_messageSender FOREIGN KEY(mleSendermessage) REFERENCES membre(mleMembre)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



CREATE TABLE IF NOT EXISTS `membreRecevoirMessage`(
   receiveIdMessage INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
   membreMleReceiver VARCHAR(60) NOT NULL,
   typeOfReception VARCHAR(60) NOT NULL DEFAULT 'private',
   messageReff VARCHAR(60) NOT NULL,
  CONSTRAINT fk_message_Recevoir_code FOREIGN KEY(messageReff) REFERENCES message(refferenceMessage),
  CONSTRAINT fk_Recevoir_code_Mle FOREIGN KEY(membreMleReceiver) REFERENCES membre(mleMembre)
) ENGINE=INNODB DEFAULT CHARSET=utf8;
