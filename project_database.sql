-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: book_exchange_db
-- ------------------------------------------------------
-- Server version	8.0.43

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin_login`
--

DROP TABLE IF EXISTS `admin_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin_login` (
  `Admin_ID` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY (`Admin_ID`),
  UNIQUE KEY `Email_UNIQUE` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin_login`
--

LOCK TABLES `admin_login` WRITE;
/*!40000 ALTER TABLE `admin_login` DISABLE KEYS */;
INSERT INTO `admin_login` VALUES (1,'admin1@mynwu.ac.za','admin1@2025'),(2,'admin2@mynwu.ac.za','admin2@2025'),(3,'admin3@mynwu.ac.za','admin3@2025');
/*!40000 ALTER TABLE `admin_login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `applicant`
--

DROP TABLE IF EXISTS `applicant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applicant` (
  `Applicant_ID` int NOT NULL AUTO_INCREMENT,
  `Student_Num` char(8) DEFAULT NULL,
  `First_Name` varchar(15) DEFAULT NULL,
  `Last_Name` varchar(15) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Campus_ID` int DEFAULT NULL,
  PRIMARY KEY (`Applicant_ID`),
  KEY `FK_Applicant_Campus_idx` (`Campus_ID`),
  CONSTRAINT `FK_Applicant_Campus` FOREIGN KEY (`Campus_ID`) REFERENCES `campus` (`Campus_ID`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicant`
--

LOCK TABLES `applicant` WRITE;
/*!40000 ALTER TABLE `applicant` DISABLE KEYS */;
INSERT INTO `applicant` VALUES (1,'32145678','Thabo','Nkosi','thabo.nkosi@student.nwu.ac.za',1),(2,'87654321','Emily','Smit','emily.smith@mynwu.ac.za',2),(3,'45678912','Mohammed','Khan','mohammed.khan@student.nwu.ac.za',3),(4,'65432198','Lerato','Dlamini','lerato.dlamini@mynwu.ac.za',1),(5,'50333755','Vivicia','Freemantle','viviciaf@gmail.com',2);
/*!40000 ALTER TABLE `applicant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `applicant_login`
--

DROP TABLE IF EXISTS `applicant_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applicant_login` (
  `App_Login_ID` int NOT NULL AUTO_INCREMENT,
  `Applicant_ID` int NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY (`App_Login_ID`),
  UNIQUE KEY `Email_UNIQUE` (`Email`),
  KEY `FK1_idx` (`Applicant_ID`),
  CONSTRAINT `FK1` FOREIGN KEY (`Applicant_ID`) REFERENCES `applicant` (`Applicant_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicant_login`
--

LOCK TABLES `applicant_login` WRITE;
/*!40000 ALTER TABLE `applicant_login` DISABLE KEYS */;
INSERT INTO `applicant_login` VALUES (1,1,'thabo.nkosi@student.nwu.ac.za','Thabo#2025!'),(2,2,'emily.smith@student.nwu.ac.za','EmilyS1234!'),(3,3,'mohammed.khan@student.nwu.ac.za','MohamKhan11@'),(4,4,'lerato.dlamini@student.nwu.ac.za','Dlamini558#'),(6,5,'viviciaf@gmail.com','Viv20050209!');
/*!40000 ALTER TABLE `applicant_login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `Book_ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) DEFAULT NULL,
  `Author_FName` varchar(15) DEFAULT NULL,
  `Author_LName` varchar(15) DEFAULT NULL,
  `Edition` int DEFAULT NULL,
  `Year_Published` int DEFAULT NULL,
  `Book_Condition` int DEFAULT NULL,
  `Campus_ID` int DEFAULT NULL,
  PRIMARY KEY (`Book_ID`),
  KEY `FK_Book_Campus_idx` (`Campus_ID`),
  CONSTRAINT `FK_Book_Campus` FOREIGN KEY (`Campus_ID`) REFERENCES `campus` (`Campus_ID`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'Database Systems','Ramez','Elmasri',7,2015,1,1),(2,'Operating Systems Concepts','Abraham','Silver',9,2018,3,1),(3,'Java Programming','Herbert','Wiaan',11,2019,4,2),(4,'Accounting Principles','Jerry','Eben',13,2020,5,3),(5,'Business Management','Stephen','Robbins',8,2017,2,2);
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campus`
--

DROP TABLE IF EXISTS `campus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campus` (
  `Campus_ID` int NOT NULL AUTO_INCREMENT,
  `Campus_Name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Campus_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci MAX_ROWS=3 KEY_BLOCK_SIZE=1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campus`
--

LOCK TABLES `campus` WRITE;
/*!40000 ALTER TABLE `campus` DISABLE KEYS */;
INSERT INTO `campus` VALUES (1,'Potchefstroom'),(2,'Mahikeng'),(3,'Vaal Triangle');
/*!40000 ALTER TABLE `campus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donate_books`
--

DROP TABLE IF EXISTS `donate_books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donate_books` (
  `Donation_ID` int NOT NULL AUTO_INCREMENT,
  `Donor_ID` int NOT NULL,
  `Book_ID` int NOT NULL,
  `Donation_Date` date DEFAULT NULL,
  PRIMARY KEY (`Donation_ID`),
  KEY `FK_Donate_Donor_idx` (`Donor_ID`),
  KEY `FK_Donate_Books_idx` (`Book_ID`),
  CONSTRAINT `FK_Donate_Books` FOREIGN KEY (`Book_ID`) REFERENCES `books` (`Book_ID`) ON DELETE CASCADE,
  CONSTRAINT `FK_Donate_Donor` FOREIGN KEY (`Donor_ID`) REFERENCES `donor` (`Donor_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donate_books`
--

LOCK TABLES `donate_books` WRITE;
/*!40000 ALTER TABLE `donate_books` DISABLE KEYS */;
INSERT INTO `donate_books` VALUES (1,1,1,'2024-01-15'),(2,2,3,'2024-02-20'),(3,3,4,'2024-03-05'),(4,4,2,'2023-04-10'),(5,1,5,'2025-05-12');
/*!40000 ALTER TABLE `donate_books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donor`
--

DROP TABLE IF EXISTS `donor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donor` (
  `Donor_ID` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(50) DEFAULT NULL,
  `Donor_Type_ID` int NOT NULL,
  `Name` varchar(30) DEFAULT NULL,
  `SP_Number` varchar(10) DEFAULT NULL,
  `Campus_ID` int DEFAULT NULL,
  PRIMARY KEY (`Donor_ID`),
  KEY `FK_Donor_Campus_idx` (`Campus_ID`),
  KEY `FK_Donor_DType_idx` (`Donor_Type_ID`),
  CONSTRAINT `FK_Donor_Campus` FOREIGN KEY (`Campus_ID`) REFERENCES `campus` (`Campus_ID`) ON DELETE SET NULL,
  CONSTRAINT `FK_Donor_DType` FOREIGN KEY (`Donor_Type_ID`) REFERENCES `donor_type` (`Donor_Type_ID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donor`
--

LOCK TABLES `donor` WRITE;
/*!40000 ALTER TABLE `donor` DISABLE KEYS */;
INSERT INTO `donor` VALUES (1,'john.doe@mynwu.ac.za',1,'John Doe','23456789',1),(2,'sarah.m@student.nwu.ac.za',1,'Sarah Mokoena','34567890',2),(3,'bookclub@nwu.org',2,'NWU Book Club','0112345678',1),(4,'techorg@outlook.com',2,'Tech Outreach Org','0119876543',3);
/*!40000 ALTER TABLE `donor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donor_login`
--

DROP TABLE IF EXISTS `donor_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donor_login` (
  `Donor_Login_ID` int NOT NULL AUTO_INCREMENT,
  `Donor_ID` int NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY (`Donor_Login_ID`),
  UNIQUE KEY `Email_UNIQUE` (`Email`),
  KEY `FK2_idx` (`Donor_ID`),
  CONSTRAINT `FK2` FOREIGN KEY (`Donor_ID`) REFERENCES `donor` (`Donor_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donor_login`
--

LOCK TABLES `donor_login` WRITE;
/*!40000 ALTER TABLE `donor_login` DISABLE KEYS */;
INSERT INTO `donor_login` VALUES (1,1,'john.doe@mynwu.ac.za','12345678'),(2,2,'sarah.m@student.nwu.ac.za','SarahM1234'),(3,3,'bookclub@nwu.org','BookClub2025'),(4,4,'techorg@outlook.com','TechOrg@NWU');
/*!40000 ALTER TABLE `donor_login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donor_type`
--

DROP TABLE IF EXISTS `donor_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donor_type` (
  `Donor_Type_ID` int NOT NULL AUTO_INCREMENT,
  `Type_Name` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`Donor_Type_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci MAX_ROWS=2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donor_type`
--

LOCK TABLES `donor_type` WRITE;
/*!40000 ALTER TABLE `donor_type` DISABLE KEYS */;
INSERT INTO `donor_type` VALUES (1,'Individual'),(2,'Organization');
/*!40000 ALTER TABLE `donor_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `issue_books`
--

DROP TABLE IF EXISTS `issue_books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `issue_books` (
  `Issued_ID` int NOT NULL AUTO_INCREMENT,
  `Applicant_ID` int NOT NULL,
  `Book_ID` int NOT NULL,
  `Date_Issued` date DEFAULT NULL,
  PRIMARY KEY (`Issued_ID`),
  KEY `FK_Issue_Applicant_idx` (`Applicant_ID`),
  KEY `FK_Issue_Books_idx` (`Book_ID`),
  CONSTRAINT `FK_Issue_Applicant` FOREIGN KEY (`Applicant_ID`) REFERENCES `applicant` (`Applicant_ID`) ON DELETE CASCADE,
  CONSTRAINT `FK_Issue_Books` FOREIGN KEY (`Book_ID`) REFERENCES `books` (`Book_ID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `issue_books`
--

LOCK TABLES `issue_books` WRITE;
/*!40000 ALTER TABLE `issue_books` DISABLE KEYS */;
INSERT INTO `issue_books` VALUES (1,1,1,'2025-06-01'),(2,2,3,'2025-06-10'),(3,3,4,'2025-06-25'),(4,4,2,'2025-07-01');
/*!40000 ALTER TABLE `issue_books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'book_exchange_db'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-08  9:19:33
