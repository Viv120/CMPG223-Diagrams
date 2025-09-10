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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-10 11:42:05
