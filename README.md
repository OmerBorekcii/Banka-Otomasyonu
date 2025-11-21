🏦 Banka Otomasyonu (Console App) :

Bu proje, C# programlama dili kullanılarak geliştirilmiş, konsol tabanlı basit bir bankacılık simülasyonudur. 

Kullanıcıların temel finansal işlemleri gerçekleştirmesine olanak tanır ve hatalı girişlere karşı güvenli bir yapı sunar.

🚀 Özellikler :

Uygulama aşağıdaki temel fonksiyonları içerir:

Para Yatırma: Hesabınıza güvenli bir şekilde bakiye ekler.

Para Çekme: Hesabınızdan para çekmenizi sağlar (Yetersiz bakiye kontrolü mevcuttur).

Bakiye Görüntüleme: Anlık bakiyenizi ekrana yansıtır.

Giriş Kontrolü (Validation):
Kullanıcı sayı yerine harf girerse program çökmez, uyarı verir.
Negatif tutar girişleri engellenmiştir.
Bakiyeden fazla para çekilmesi engellenmiştir.

🛠️ Kullanılan Teknolojiler :

Dil: C# (.NET)

Tür: Konsol Uygulaması (Console Application)

Kavramlar: switch-case, while döngüleri, ref parametreleri, TryParse metodu.

💻 Kurulum ve Çalıştırma :

Projeyi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

Bu projeyi bilgisayarınıza indirin veya klonlayın.

Projeyi Visual Studio, Visual Studio Code veya herhangi bir C# IDE'si ile açın.

Terminal veya konsol ekranında proje dizinine gelin.

Aşağıdaki komutu kullanarak projeyi çalıştırın:

dotnet run

📂 Kod Yapısı :

Proje içerisindeki metodların görevleri şunlardır:

Main: Programın ana döngüsünü (sonsuz döngü) ve menü seçim işlemlerini yönetir.

para_yatirma: ref anahtar kelimesi ile ana bakiyeyi günceller.

para_cekme: Bakiye kontrolü yapar ve yeterli bakiye varsa ref ile ana bakiyeyi düşürür.

bakiye_goruntule: Mevcut bakiyeyi kullanıcıya gösterir.

Cikis: Uygulamayı güvenli bir şekilde sonlandırır (Environment.Exit(0)).

📸 Örnek Kullanım

<img width="488" height="288" alt="image" src="https://github.com/user-attachments/assets/7a7e4889-c512-466d-a92c-300cdbcf4ca1" />


Bu proje eğitim amaçlı geliştirilmiştir.
