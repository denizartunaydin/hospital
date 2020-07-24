
CREATE DATABASE /*!32312 IF NOT EXISTS*/`hospital` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `hospital`;

/*Table structure for table `doktorlar` */

DROP TABLE IF EXISTS `doktorlar`;

CREATE TABLE `doktorlar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tc_kimlik` varchar(11) NOT NULL,
  `adi` varchar(50) NOT NULL,
  `soyadi` varchar(100) NOT NULL,
  `cinsiyet` varchar(10) NOT NULL,
  `tel` varchar(15) NOT NULL,
  `unvan` varchar(10) NOT NULL,
  `uzmanlik` varchar(150) NOT NULL,
  `ucret` double NOT NULL,
  `deneme` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `tc_kimlik` (`tc_kimlik`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `doktorlar` */

insert  into `doktorlar`(`id`,`tc_kimlik`,`adi`,`soyadi`,`cinsiyet`,`tel`,`unvan`,`uzmanlik`,`ucret`,`deneme`) values (1,'11111111111','DENEME','DENEME','ERKEK','1111111111','DOÇ DR.','ACİL TIP',1000,NULL),(2,'11111111112','DENEME','DENEME','KADIN','1111111111','DOÇ DR.','İÇ HASTALIKLARI',100,NULL),(3,'18226719286','DENİZ','ARTUN','ERKEK','111111111','DOÇ DR.','KALP VE DAMAR CERRAHİSİ',1500,NULL);

/*Table structure for table `hasta_sikayetleri` */

DROP TABLE IF EXISTS `hasta_sikayetleri`;

CREATE TABLE `hasta_sikayetleri` (
  `hasta_id` double NOT NULL,
  `sikayet` varchar(500) DEFAULT NULL,
  `hikayesi` varchar(500) DEFAULT NULL,
  `mua_bulgu` varchar(500) DEFAULT NULL,
  `on_tani` varchar(500) DEFAULT NULL,
  `tani` varchar(500) DEFAULT NULL,
  `yapilan_islem` varchar(500) DEFAULT NULL,
  `onerilen_tedavi` varchar(500) DEFAULT NULL,
  `kullan_ilac` varchar(500) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Data for the table `hasta_sikayetleri` */

insert  into `hasta_sikayetleri`(`hasta_id`,`sikayet`,`hikayesi`,`mua_bulgu`,`on_tani`,`tani`,`yapilan_islem`,`onerilen_tedavi`,`kullan_ilac`) values (2,'dhdf','dfhdfh','dfhdfh','dfhdfh','dfhdfh','dfhdfh','dfhdfh','dfhfdh'),(4,'Kalp çarpintisi','Vize final sinavlari','Çok heyecanli','Deli','Biraz sakin olmali','Serum','Artuna gitme','Artunu isirmak'),(3,'drgf','','','dfg','','','fgh','');

/*Table structure for table `hastalar` */

DROP TABLE IF EXISTS `hastalar`;

CREATE TABLE `hastalar` (
  `id` double NOT NULL AUTO_INCREMENT,
  `tc_kimlik` varchar(11) NOT NULL,
  `seri` varchar(10) NOT NULL,
  `no` varchar(10) NOT NULL,
  `adi` varchar(100) NOT NULL,
  `soyadi` varchar(100) NOT NULL,
  `baba_adi` varchar(100) NOT NULL,
  `anne_adi` varchar(100) NOT NULL,
  `dogum_yeri` varchar(100) NOT NULL,
  `dogum_tarihi` varchar(15) NOT NULL,
  `medeni_durum` varchar(20) NOT NULL,
  `dini` varchar(50) NOT NULL,
  `kan_grubu` varchar(5) NOT NULL,
  `ot_il` varchar(100) NOT NULL,
  `ot_ilce` varchar(100) NOT NULL,
  `mahalle` varchar(100) NOT NULL,
  `cilt_no` varchar(20) NOT NULL,
  `aile_sira_no` varchar(20) NOT NULL,
  `sira_no` varchar(10) NOT NULL,
  `cinsiyet` varchar(10) NOT NULL,
  `tel` varchar(15) NOT NULL,
  `adres` varchar(500) NOT NULL,
  PRIMARY KEY (`id`,`tc_kimlik`),
  UNIQUE KEY `tc_kimlik` (`tc_kimlik`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `hastalar` */

insert  into `hastalar`(`id`,`tc_kimlik`,`seri`,`no`,`adi`,`soyadi`,`baba_adi`,`anne_adi`,`dogum_yeri`,`dogum_tarihi`,`medeni_durum`,`dini`,`kan_grubu`,`ot_il`,`ot_ilce`,`mahalle`,`cilt_no`,`aile_sira_no`,`sira_no`,`cinsiyet`,`tel`,`adres`) values (2,'21474836471','123','FDSG','G','SG','SDFG','SDF','F','08.09.1977','SDG','SFG','GF','BİTLİS','sdfg','DG','G','G','17','ERKEK','AFGX','gsdfgsdfg'),(3,'11111111111','GF','DFSG','SFG','SFG','DSG','DSFG','DFSG','DSFG','SFG','SFG','DFSG','ADIYAMAN','sdgf','FG','GDFSG','DSFG','DFSG','ERKEK','DSFG','dfsgdfsg');

/*Table structure for table `klinikler` */

DROP TABLE IF EXISTS `klinikler`;

CREATE TABLE `klinikler` (
  `id` double NOT NULL AUTO_INCREMENT,
  `klinik_isim` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

/*Data for the table `klinikler` */

insert  into `klinikler`(`id`,`klinik_isim`) values (1,'ACİL TIP'),(2,'ADLİ TIP'),(3,'AĞIZ, YÜZ VE ÇENE CERRAHİSİ'),(4,'AİLE HEKİMLİĞİ'),(5,'ANESTEZİYOLOJİ VE REANİMASYON'),(6,'BEYİN VE SİNİR CERRAHİSİ'),(7,'ÇOCUK CERRAHİSİ'),(8,'ÇOCUK SAĞLIĞI VE HASTALIKLARI'),(9,'DERİ VE ZÜHREVİ HASTALIKLARI'),(10,'ENFEKSİYON HASTALIKLARI'),(11,'FİZİKSEL TIP VE REHABİLİTASYON'),(12,'GENEL CERRAHİ'),(13,'GÖĞÜS CERRAHİSİ'),(14,'GÖZ HASTALIKLARI'),(15,'İÇ HASTALIKLARI'),(16,'KADIN HASTALIKLARI VE DOĞUM'),(17,'KALP VE DAMAR CERRAHİSİ'),(18,'KARDİYOLOJİ'),(19,'KULAK BURUN BOĞAZ HASTALIKLARI'),(20,'NÖROLOJİ'),(21,'ORTOPEDİ VE TRAVMATOLOJİ'),(22,'RUH SAĞLIĞI VE HASTALIKLARI'),(23,'ÜROLOJİ'),(24,'RADYOLOJİ');

/*Table structure for table `kullanicilar` */

DROP TABLE IF EXISTS `kullanicilar`;

CREATE TABLE `kullanicilar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `isim` varchar(100) NOT NULL,
  `kullanici_adi` varchar(10) NOT NULL,
  `sifre` varchar(30) NOT NULL,
  `gorevi` varchar(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `kullanicilar` */

insert  into `kullanicilar`(`id`,`isim`,`kullanici_adi`,`sifre`,`gorevi`) values (1,'Admin Admin','admin','1','1'),(4,'Sekreter','sekreter','1','3'),(5,'Doktor','doktor','1','0');

/*Table structure for table `randevular` */

DROP TABLE IF EXISTS `randevular`;

CREATE TABLE `randevular` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tc` varchar(11) DEFAULT NULL,
  `klinik_adi` varchar(150) DEFAULT NULL,
  `doktor_adi` varchar(100) DEFAULT NULL,
  `tarih` date DEFAULT NULL,
  `saat` varchar(10) DEFAULT NULL,
  `mua_tur` varchar(20) DEFAULT NULL,
  `islem` double DEFAULT '0',
  `durum` varchar(10) DEFAULT 'Bekliyor',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

/*Data for the table `randevular` */

insert  into `randevular`(`id`,`tc`,`klinik_adi`,`doktor_adi`,`tarih`,`saat`,`mua_tur`,`islem`,`durum`) values (7,'21474836471','GÖZ HASTALIKLARI','','2017-05-09','15:30','Muayene',2,'Bitti'),(8,'11111111111','ACIL TIP','DENEME DENEME','2020-06-10','12:00','Muayene',1,'Bitti'),(6,'18226719286','GÖZ HASTALIKLARI','DOÇ DR. DENEME DENEME','2019-09-21','10:00','Kontrol Muayenesi',0,'Bekliyor'),(13,'21474836471','ACİL TIP','DENEME DENEME','2017-05-09','09:00','Reçete Muayenesi',2,'Bitti'),(16,'39275215420','KALP VE DAMAR CERRAHISI','DENIZ ARTUN','2019-10-03','17:00','Kontrol Muayenesi',2,'Bitti'),(17,'11111111111','ACIL TIP','DENEME DENEME','2019-10-23','09:30','Muayene',2,'Bitti'),(18,'11111111111','ACIL TIP','DENEME DENEME','2020-03-24','09:30','Kontrol Muayenesi',1,'Bekliyor'),(20,'11111111111','ACIL TIP','DENEME DENEME','2020-07-23','10:00','Muayene',1,'Bekliyor');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
