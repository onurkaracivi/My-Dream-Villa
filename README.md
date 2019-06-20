# My-Dream-Villa
My Dream Villa
Proje taslak dökümanına "MyDreamVillaProjeDökümanı.pdf" isimli dosyadan erişebilirsiniz.
Release içine kod ziplenerek konmuştur.
-DB dosyaları klasörde mevcut, localDB'den çalıştırmak için;
Query ekranına 
USE master; GO; CREATE DATABASE [DBNAME]  ON   (   FILENAME = '[C:\DBFILE.mdf]') LOG ON  (    FILENAME = '[C:\DBLOGFILElog.ldf]') FOR ATTACH; GO;
