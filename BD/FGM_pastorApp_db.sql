CREATE DATABASE IF NOT EXISTS FGM_pastor_db;

USE FGM_pastor_db;
/**
*creation de la region 
*/

CREATE TABLE IF NOT EXISTS fgm_area (
  `areaCode` VARCHAR(60) NOT NULL,
  `areaName` VARCHAR(60) NOT NULL,
   isDelete INT(1) NOT NULL DEFAULT 0,
   PRIMARY KEY (`areaCode`)
) ENGINE=INNODB DEFAULT CHARSET=utf8;


CREATE TABLE IF NOT EXISTS fgm_district (
   districtCode VARCHAR(60) NOT NULL,
  `districtName` VARCHAR(60) NOT NULL,
  `codeArea` VARCHAR(60)  NOT NULL ,
   isDelete INT(1) NOT NULL DEFAULT 0,
   PRIMARY KEY (`districtCode`),
   CONSTRAINT fk_area_key FOREIGN KEY (codeArea) REFERENCES fgm_area(areaCode)
) ENGINE=INNODB DEFAULT CHARSET=utf8;

CREATE TABLE IF  NOT EXISTS fgm_church(
	stationCode VARCHAR(60)  NOT NULL PRIMARY KEY,
	stationName VARCHAR(60) NOT NULL,
	stationPicture TEXT,
	stationSlogang VARCHAR(100) NOT NULL,
	districtParentReff VARCHAR(60) NOT NULL,
	isBaseArea INT(1) NOT NULL DEFAULT 0,
	isBaseDistrict INT(1) NOT NULL DEFAULT 0,
	isDelete INT(1) NOT NULL DEFAULT 0,
	CONSTRAINT fk_parent_district FOREIGN KEY (districtParentReff) REFERENCES fgm_district(districtCode)
)ENGINE=INNODB DEFAULT CHARSET=utf8;



  
  
  CREATE TABLE IF NOT EXISTS `fgm_pastor` (
  matriculePastor VARCHAR(60) NOT NULL,
  `pastorName` VARCHAR(60) NOT NULL,
  `pastorSurname` VARCHAR(60) NOT NULL,
  `pastorBirthdayDate` DATE NOT NULL,
  `birthdayPlace` VARCHAR(60) NOT NULL,
  `pastorFatherName` VARCHAR(60) NOT NULL,
   pastorMotherName VARCHAR(60) NOT NULL,
   pastorSexe ENUM('F','M') DEFAULT 'M',
   pastorPhone VARCHAR(60),
   pastorEmail VARCHAR(60),
  `dateConversion` DATE DEFAULT NULL,
  `workBeforeBibleSchool` VARCHAR(60) NOT NULL,
  `rankProbation` VARCHAR(60) NOT NULL,
   areaOfCalling VARCHAR(100) NOT NULL,
   nberYearArea INT NOT NULL DEFAULT 0,
   nbreYearDistrict INT NOT NULL DEFAULT 0,
   martialSituation VARCHAR(60) NOT NULL,
   nationality VARCHAR(60) NOT NULL ,
   pastorAdresse VARCHAR(100) NOT NULL,
  `photoProfil` TEXT NULL ,
  `isActif` TINYINT(1) DEFAULT 1,
  `raisonIndispoMissionnaire` TEXT DEFAULT NULL,
   isDelete INT(1),
  PRIMARY KEY (`matriculePastor`)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



CREATE TABLE IF NOT EXISTS fgm_area_supervisor (
   id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
   pastorAreaSupervisorCode VARCHAR(60) NOT NULL,
   SuperviceArea VARCHAR(60) NOT NULL,
   nominationDate DATE,
   CONSTRAINT fk_pastor_k FOREIGN KEY (pastorAreaSupervisorCode) REFERENCES fgm_pastor(matriculePastor),
   CONSTRAINT fk_area_code FOREIGN KEY (SuperviceArea) REFERENCES fgm_area(areaCode)
) ENGINE=INNODB DEFAULT CHARSET=utf8;


CREATE TABLE IF NOT EXISTS fgm_district_supervisor (
   id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
   pastorDistrictSupervisorCode VARCHAR(60) NOT NULL,
   SuperviceDistrict VARCHAR(60) NOT NULL,
   nominationDate DATE,
   CONSTRAINT fk_pastor_supervisor FOREIGN KEY (pastorDistrictSupervisorCode) REFERENCES fgm_pastor(matriculePastor),
   CONSTRAINT fk_district_code FOREIGN KEY (SuperviceDistrict) REFERENCES fgm_district(districtCode)
) ENGINE=INNODB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `fgm_trainning` (
  `trainningCode` VARCHAR(60) NOT NULL,
  `institutName` VARCHAR(60) NOT NULL,
  `typeFormation` VARCHAR(60) NOT NULL,
   trainningPastorMatricule VARCHAR(60) NOT NULL,
  PRIMARY KEY (`trainningCode`),
  CONSTRAINT fk_pastor_trainnig FOREIGN KEY(trainningPastorMatricule) REFERENCES fgm_pastor(matriculePastor)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



CREATE TABLE IF NOT EXISTS `fgm_ordination` (
   id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
   pastorConcernCode VARCHAR(60) NOT NULL,
   ordinationDate DATE,
  CONSTRAINT fk_pastor_ordination  FOREIGN KEY (pastorConcernCode) REFERENCES fgm_pastor(matriculePastor)
) ENGINE=INNODB DEFAULT CHARSET=utf8;






CREATE TABLE IF NOT EXISTS fgm_pastor_transfer (
  `codeStationTransfer` VARCHAR(60) NOT NULL,
  `mleTransferedPastor` VARCHAR(60) NOT NULL,
  `dateTransfert` DATE NOT NULL,
  `startDate` DATE DEFAULT NULL,
  `OccupationPosition` VARCHAR(60) NOT NULL,
   statusTranfert VARCHAR(60) NOT NULL DEFAULT 'Encours',
  `id` INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  CONSTRAINT fk_station_de_transfert FOREIGN KEY (codeStationTransfer) REFERENCES fgm_church(stationCode),
  CONSTRAINT fk_pastor_transfered FOREIGN KEY (mleTransferedPastor) REFERENCES fgm_pastor(matriculePastor)
) ENGINE=INNODB DEFAULT CHARSET=utf8;



CREATE TABLE IF NOT EXISTS `fgm_FamilyMember` (
  `matriculeMember` VARCHAR(60) NOT NULL,
  `memberName` VARCHAR(60) NOT NULL,
  `memberSurname` VARCHAR(60) NOT NULL,
  `memberBirthdayDate` DATE NOT NULL,
  `memberbirthdayPlace` VARCHAR(60) NOT NULL,
  `memberFatherName` VARCHAR(60) NOT NULL,
   memberMotherName VARCHAR(60) NOT NULL,
   memberSexe ENUM('F','M') DEFAULT 'M',
   memberPhone VARCHAR(130),
   memberEmail VARCHAR(60),
  `memberConversionDate` DATE DEFAULT NULL,
  `memberProfession` VARCHAR(60) NOT NULL,
  `typeOfFamilyMember` VARCHAR(60) NOT NULL,
   mlePastorLink VARCHAR(60) NOT NULL,
   statutLink VARCHAR(60) NOT NULL DEFAULT 'Encours',
  PRIMARY KEY (`matriculeMember`),
  CONSTRAINT fk_pastor_link FOREIGN KEY (mlePastorLink) REFERENCES fgm_pastor(matriculePastor)
) ENGINE=INNODB DEFAULT CHARSET=utf8;

