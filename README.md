# Crud İşlemleri - Entity Framework - CODE FIRST yaklaşımı ile sorun çözümü - SQLite

## Açıklama
SQLite kullanarak basic bir CRUD işlemlerinin gerçekleştiği mini bir proje yapılmıştır. C# ASP.CORE yapısı ile Entity Framework Core kullanarak sıfırdan veritabanını Entity halinde getirip modeleyyip oluşturduk.
Öğrencler listesi olarak ekleme,silme,listeleme ve güncelleme işlemlerine yer verdik.Diğer bir projede bu sefer İlişkisel Veritabanı yapısını kullanarak daha da projemizi geliştireceğiz.

## Başlangıç
SQLite Browser indirilerek proje içindeki .db uzantılı veriyi SQLite Browser'a sürüklemeniz yeterli.Direkt olarak bağlantı işlemleri gerçekleşir. Proje içersinde ki tüm tool işlemleri yüklüdür.
dotnet ef -g diyerek proje içindeki ve yerel cihazdaki tool'ları görebiliriz.Terminal üzerinden yazmak yeterlidir.



## Proje Görselleri
HomeScreen:
![image](https://github.com/dgnyldrm7/CRUD_WithEntityFramworkCore/assets/94688501/35eec52b-2737-4dd2-aa00-21f8216e2331)

AddStudent:
![image](https://github.com/dgnyldrm7/CRUD_WithEntityFramworkCore/assets/94688501/9750f413-c303-4085-94f2-c528eecb24d8)

DeleteScreen:
![image](https://github.com/dgnyldrm7/CRUD_WithEntityFramworkCore/assets/94688501/1f8d0e9b-f3ba-4de4-90c8-45e7f14ab41f)

EditScreen:
![image](https://github.com/dgnyldrm7/CRUD_WithEntityFramworkCore/assets/94688501/b07764ce-c043-413e-85f7-e6be0d8affac)



## Proje Çalışması
Direkt olarak kurulumlar tamamlandıktan sonra Addcourse bölümünde ekleme işlemi direkt olarak gerçekleşmektedir.Alt kısımda StudentList kısmında veritabanından gelen verileri işleme kısmına yer verilmiştir.
Delete butonuna tıklayınca sorgulama ekranında emin misin?Kısmı karşımıza çıkmaktadır. Düzenle kısmında da var olan verileri yenileri ile yenileme imkanı sunulmaktadır.



