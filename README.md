# UniversiteOtomasyon

--> Projenin Amacı
   Bu proje, üniversite düzeyinde öğrenci, öğretim üyesi, ders ve not takibini dijital ortamda sağlamak amacıyla geliştirilmiştir. WinForms tabanlı arayüz ve SQL Server    veritabanı kullanılarak öğretim elemanlarının öğrenci bilgilerini, dersleri ve notları sistemde  işlemelerini sağlar.


(-)Kullanılan Teknolojiler
   - Programlama Dili: C# (.NET Framework)
   - Arayüz: Windows Forms (WinForms)
   - Veritabanı: SQL Server Express 
   - Bağlantı: ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)
   - Geliştirme Ortamı: Visual Studio 2022
     

(-) Veritabanı Tabloları ve İlişkiler
      -Ogrenci:
        OgrenciID (PK), AdSoyad, Bolum, Sinif
     
      -OgretimUyesi:
        OgretimUyesiID (PK), AdSoyad, Unvan
      
      -Ders:
        DersID (PK), DersAdi, Kredi, OgretimUyesiID (FK)
      
      -NotGiris:
        NotID (PK), Vize, Final, Ortalama, OgrenciID (FK), DersID (FK)
        

 (-) Formlar ve İşlevleri
       -> AnaForm
          - Buttonlar kullanarak  diger sayfalara yonlendirir.
 
      -> OgrenciForm
          - Öğrenci ekleme, güncelleme ve listeleme işlemleri yapılır.
          - Kullanılan alanlar: OgrenciID, AdSoyad, Bolum, Sinif
          
      -> OgretimUyesiForm
          - Öğretim üyeleri eklenebilir ve bilgileri güncellenebilir.
          - Kullanılan alanlar: OgretimUyesiID, AdSoyad, Unvan

      -> DersForm
          - Ders tanımlamaları yapılır ve öğretim üyesiyle ilişkilendirilir.
          - Alanlar: DersAdi, Kredi, OgretimUyesiID

      -> NotGirisForm
          - Öğrenciye ders atama ve not girişi yapılır.
          - Vize, final ve ortalama hesaplamaları yapılır.

