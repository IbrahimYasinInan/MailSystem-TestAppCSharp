# 📧 MailSystem-TestAppCSharp - Mail Modülü

Bu proje, C# ve .NET Framework kullanarak geliştirilmiş bir e-posta sisteminin temel işlevlerini test etmeyi amaçlayan bir uygulamadır. "3- Kaynak Kodlar/mail" klasörü, bu uygulamanın e-posta gönderme ve alma işlemlerini gerçekleştiren ana modülün kaynak kodlarını içermektedir.

## 🚀 Proje Amacı

Bu uygulama, SMTP ve IMAP/POP3 protokollerini kullanarak e-posta gönderme ve alma işlemlerini gerçekleştiren bir test uygulamasıdır. Geliştiriciler için e-posta sistemlerinin entegrasyonu ve test edilmesi konusunda bir örnek teşkil etmektedir.

## 🛠️ Kullanılan Teknolojiler

- C#
- .NET Framework
- SMTP (E-posta gönderimi için)
- IMAP/POP3 (E-posta alımı için)

## 📂 Klasör Yapısı

```
MailSystem-TestAppCSharp/
├── 1- Setup Files/
├── 2- Screenshots/
├── 3- Source Codes/
│   └── mail/
│       ├── MailSender.cs
│       ├── MailReceiver.cs
│       └── ...
└── ...
```

- **MailSender.cs**: E-posta gönderme işlemlerini gerçekleştiren sınıf.
- **MailReceiver.cs**: E-posta alma işlemlerini gerçekleştiren sınıf.
- **...**: Diğer yardımcı sınıflar ve konfigürasyon dosyaları.

## ⚙️ Kurulum ve Çalıştırma

1. Bu repository'yi bilgisayarınıza klonlayın:

```bash
git clone https://github.com/IbrahimYasinInan/MailSystem-TestAppCSharp.git
```

2. Proje klasörüne gidin:

```bash
cd MailSystem-TestAppCSharp/3- Kaynak Kodlar/mail
```

3. Visual Studio veya tercih ettiğiniz bir C# IDE'si ile projeyi açın.
4. Gerekli NuGet paketlerini yükleyin.
5. `MailSender.cs` ve `MailReceiver.cs` dosyalarında gerekli SMTP ve IMAP/POP3 sunucu ayarlarını yapılandırın.
6. Projeyi derleyin ve çalıştırın.

## 📧 Kullanım

- **E-posta Gönderme**: `MailSender` sınıfını kullanarak SMTP protokolü üzerinden e-posta gönderebilirsiniz.
- **E-posta Alma**: `MailReceiver` sınıfını kullanarak IMAP veya POP3 protokolü üzerinden e-posta alabilirsiniz.

**Örnek Kullanım:**

```csharp
var mailSender = new MailSender("smtp.sunucu.com", "kullanici@domain.com", "parola");
mailSender.Send("alici@domain.com", "Konu", "Mesaj içeriği");

var mailReceiver = new MailReceiver("imap.sunucu.com", "kullanici@domain.com", "parola");
var emails = mailReceiver.Receive();
```

## 📄 Lisans

Bu proje [MIT Lisansı](https://opensource.org/licenses/MIT) ile lisanslanmıştır.

