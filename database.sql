/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 5.7.15-log : Database - esemka_airlines
*********************************************************************
*/


/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`esemka_airlines` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `esemka_airlines`;

/*Table structure for table `airplane` */

DROP TABLE IF EXISTS `airplane`;

CREATE TABLE `airplane` (
  `airplane_code` varchar(25) NOT NULL,
  `airplane_type` varchar(255) NOT NULL,
  `airplane_totalseat` int(11) NOT NULL,
  `airplane_seatperrow` int(11) NOT NULL,
  `airplane_numrow` int(11) NOT NULL,
  PRIMARY KEY (`airplane_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `airplane` */

insert  into `airplane`(`airplane_code`,`airplane_type`,`airplane_totalseat`,`airplane_seatperrow`,`airplane_numrow`) values ('DNR-1','Boeing E22',300,10,30),('DX-011','Airbus E10X',30,3,10);

/*Table structure for table `airport` */

DROP TABLE IF EXISTS `airport`;

CREATE TABLE `airport` (
  `airport_code` varchar(3) NOT NULL,
  `airport_name` varchar(255) NOT NULL,
  `airport_country` varchar(255) NOT NULL,
  `airport_city` varchar(255) NOT NULL,
  `airport_timezone` varchar(255) NOT NULL,
  PRIMARY KEY (`airport_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `airport` */

insert  into `airport`(`airport_code`,`airport_name`,`airport_country`,`airport_city`,`airport_timezone`) values ('APC','Alaska Airport','United States of America','Alaska','Alaskan Standard Time'),('DAC','Denpasar International Airport','Indonesia','Denpasar','SE Asia Standard Time'),('LAX','Los Angeles International Airport','United States of America','Los Angeles','Central America Standard Time');

/*Table structure for table `flight_boarding` */

DROP TABLE IF EXISTS `flight_boarding`;

CREATE TABLE `flight_boarding` (
  `boarding_id` varchar(25) NOT NULL,
  `boarding_ticketcode` varchar(25) NOT NULL,
  `boarding_date` datetime NOT NULL,
  PRIMARY KEY (`boarding_id`),
  KEY `boarding_ticketcode` (`boarding_ticketcode`),
  CONSTRAINT `flight_boarding_ibfk_1` FOREIGN KEY (`boarding_ticketcode`) REFERENCES `flight_ticket` (`ticket_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `flight_boarding` */

/*Table structure for table `flight_booking` */

DROP TABLE IF EXISTS `flight_booking`;

CREATE TABLE `flight_booking` (
  `booking_code` varchar(25) NOT NULL,
  `booking_flightcode` varchar(25) NOT NULL,
  `booking_returnflight` varchar(25) DEFAULT NULL,
  `booking_amount` int(11) NOT NULL,
  `booking_entrydate` datetime NOT NULL,
  PRIMARY KEY (`booking_code`),
  KEY `booking_flightcode` (`booking_flightcode`),
  CONSTRAINT `flight_booking_ibfk_1` FOREIGN KEY (`booking_flightcode`) REFERENCES `flight_schedule` (`flight_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `flight_booking` */

insert  into `flight_booking`(`booking_code`,`booking_flightcode`,`booking_returnflight`,`booking_amount`,`booking_entrydate`) values ('BK001','BD001',NULL,1,'2017-04-12 10:39:55'),('BK002','BD001',NULL,2,'2017-04-12 11:34:40'),('BK003','BD001',NULL,1,'2017-04-16 09:06:30'),('BK004','BD002',NULL,1,'2017-04-16 12:22:29'),('BK005','BD003',NULL,1,'2017-04-16 12:28:02');

/*Table structure for table `flight_schedule` */

DROP TABLE IF EXISTS `flight_schedule`;

CREATE TABLE `flight_schedule` (
  `flight_code` varchar(25) NOT NULL,
  `flight_origin` varchar(3) NOT NULL,
  `flight_destination` varchar(3) NOT NULL,
  `flight_departure` datetime NOT NULL,
  `flight_arrival` datetime NOT NULL,
  `flight_duration` varchar(50) NOT NULL,
  `flight_airplane` varchar(25) NOT NULL,
  `flight_price` int(11) NOT NULL,
  PRIMARY KEY (`flight_code`),
  KEY `flight_destination` (`flight_destination`),
  KEY `flight_origin` (`flight_origin`),
  KEY `flight_airplane` (`flight_airplane`),
  CONSTRAINT `flight_schedule_ibfk_1` FOREIGN KEY (`flight_destination`) REFERENCES `airport` (`airport_code`),
  CONSTRAINT `flight_schedule_ibfk_2` FOREIGN KEY (`flight_origin`) REFERENCES `airport` (`airport_code`),
  CONSTRAINT `flight_schedule_ibfk_3` FOREIGN KEY (`flight_airplane`) REFERENCES `airplane` (`airplane_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `flight_schedule` */

insert  into `flight_schedule`(`flight_code`,`flight_origin`,`flight_destination`,`flight_departure`,`flight_arrival`,`flight_duration`,`flight_airplane`,`flight_price`) values ('AP22','APC','LAX','2017-04-04 10:40:41','2017-04-04 11:40:41','-0 01:00:00.000000','DX-011',100000),('AX-001','APC','DAC','2017-04-04 21:48:48','2017-04-04 22:48:54','1','DNR-1',50000),('BD001','APC','DAC','2017-04-12 10:01:14','2017-04-12 12:01:14','-0 02:00:00.000000','DNR-1',50000),('BD002','DAC','LAX','2017-04-16 09:14:16','2017-04-16 11:14:16','-0 02:00:00.000000','DNR-1',2000000),('BD003','LAX','DAC','2017-04-17 10:14:42','2017-04-17 12:14:42','-0 02:00:00.000000','DX-011',2500000);

/*Table structure for table `flight_ticket` */

DROP TABLE IF EXISTS `flight_ticket`;

CREATE TABLE `flight_ticket` (
  `ticket_code` varchar(25) NOT NULL,
  `ticket_bookingcode` varchar(25) NOT NULL,
  `ticket_passengercode` varchar(25) NOT NULL,
  `ticket_seatrow` varchar(5) NOT NULL,
  `ticket_seatnumber` varchar(5) NOT NULL,
  PRIMARY KEY (`ticket_code`),
  KEY `ticket_bookingcode` (`ticket_bookingcode`),
  KEY `ticket_passengercode` (`ticket_passengercode`),
  CONSTRAINT `flight_ticket_ibfk_1` FOREIGN KEY (`ticket_bookingcode`) REFERENCES `flight_booking` (`booking_code`),
  CONSTRAINT `flight_ticket_ibfk_2` FOREIGN KEY (`ticket_passengercode`) REFERENCES `passenger` (`passenger_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `flight_ticket` */

insert  into `flight_ticket`(`ticket_code`,`ticket_bookingcode`,`ticket_passengercode`,`ticket_seatrow`,`ticket_seatnumber`) values ('BD001-A01','BK001','A32','A','01'),('BD001-C01','BK002','PE001','C','01'),('BD001-C02','BK002','A32','C','02'),('BD001-G07','BK003','A32','G','07'),('BD002-B01','BK004','A32','B','01'),('BD003-A01','BK005','A32','A','01');

/*Table structure for table `passenger` */

DROP TABLE IF EXISTS `passenger`;

CREATE TABLE `passenger` (
  `passenger_code` varchar(25) NOT NULL,
  `passenger_firstname` varchar(100) NOT NULL,
  `passenger_lastname` varchar(100) NOT NULL,
  `passenger_gender` varchar(10) NOT NULL,
  `passenger_address` varchar(255) NOT NULL,
  `passenger_email` varchar(50) DEFAULT NULL,
  `passenger_phone` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`passenger_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `passenger` */

insert  into `passenger`(`passenger_code`,`passenger_firstname`,`passenger_lastname`,`passenger_gender`,`passenger_address`,`passenger_email`,`passenger_phone`) values ('A32','Dian','Yuliana','female','Jl. Sukagalih','dian_yuliana@gmail.com',896858621),('PE001','Gema','Wardian','male','Jl. Sukagalih Gg.H.Gozali No.74','gema_wardian@hotmail.com',89685896232);

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) NOT NULL,
  `user_password` varchar(50) NOT NULL,
  `user_role` varchar(10) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `user` */

insert  into `user`(`user_id`,`user_name`,`user_password`,`user_role`) values (1,'admin','admin','admin'),(2,'schedule','schedule','schedule'),(3,'booking','booking','booking'),(4,'boarding','boarding','boarding');

/* Procedure structure for procedure `getSeatAmount` */

/*!50003 DROP PROCEDURE IF EXISTS  `getSeatAmount` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `getSeatAmount`(IN flightID VARCHAR(255))
BEGIN
SELECT flight_booking.`booking_flightcode`, 
	SUM(flight_booking.`booking_amount`) AS 'booking_total' , 
	airplane.`airplane_totalseat` , 
	airplane.`airplane_totalseat`-SUM(flight_booking.`booking_amount`) AS 'flight_seatleft'
FROM flight_booking, airplane, flight_schedule 
WHERE flight_booking.`booking_flightcode` = flightID
 AND flight_schedule.`flight_airplane` = airplane.`airplane_code` 
 AND flight_booking.`booking_flightcode` = flight_schedule.`flight_code`;
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
