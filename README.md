Biyometrik Sağlık Takibi
"Biyometrik Sağlık Takibi", C# kullanarak geliştirilmiş bir Windows Forms uygulamasıdır. Bu uygulama, kullanıcıların biyometrik sağlık verilerini toplar, analiz eder ve görsel olarak sunar. Ayrıca, elde edilen veriler veri tabanına kaydedilerek sağlık takibi sağlar.

Özellikler

Veri Toplama:

Trombosit, Diyabet, Şeker, Alyuvar ve Tansiyon değerlerini toplar.
Kullanıcıdan bu verileri alır ve çeşitli hesaplamalar yapar.

Görsel Geri Bildirim:

Her veri türü için ilerleme çubukları (ProgressBar) kullanılır.
İlerleme çubuklarının rengi, verinin durumuna göre değişir (Kırmızı ve Yeşil).

Sonuç Hesaplama:

Her veri türü için belirli hesaplamalar yapar ve sonuçları kullanıcıya gösterir.
Sonuçlar, değerlerin ortalaması ve belirli formüller kullanılarak hesaplanır.

Veri Tabanı Kaydı:

Kullanıcı verileri ve hesaplanan sonuçlar SQL veri tabanına kaydedilir.
Kaydedilen veriler, ileride inceleme ve analiz için kullanılabilir.

Kullanım

Proje Dosyalarını İndirin:

https://github.com/AlITOKMAK35/Biyometrik-Saglik-Takibi

Proje Klasörüne Geçin:


cd Biyometrik-Saglik-Takibi

Projeyi Açın ve Çalıştırın:

Visual Studio'da BiyometrikSaglikTakibi.sln dosyasını açın.
F5 tuşuna basarak projeyi çalıştırın.

Kullanım:

Uygulama açıldığında, biyometrik verileri ilgili alanlara girin.
Verileri girdikten sonra İşlem Başlat butonuna tıklayın.
İlerleme çubukları dolacak ve sonuçlar hesaplanacaktır.
Sonuçlar ekranda görüntülenir ve veri tabanına kaydedilir.

Teknolojiler

Dil: C#
Platform: Windows Forms
Veritabanı: SQL Server
IDE: Visual Studio

Kod Yapısı
Form1: Ana form, kullanıcı arayüzü ve işlem yönetimini içerir.
Timer: Her biyometrik veri türü için ilerleme çubuğunu ve hesaplamayı yönetir.
SQL Veritabanı: Kullanıcı verilerini saklar ve günceller.

Katkıda Bulunma
Katkıda bulunmak isteyenler:

Fork yapın ve kendi kopyanızı oluşturun.
Yeni bir branch oluşturun.
Değişikliklerinizi yapın ve commit yapın.
Push yapın ve bir pull request oluşturun.

İletişim

Sorular veya geri bildirimler için iletişim:

E-posta: alitokmak3535@gmail.com

GitHub: AlITOKMAK35 - https://github.com/AlITOKMAK35 -
