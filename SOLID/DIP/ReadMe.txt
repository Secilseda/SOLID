

SOLID Principles
1.)SOLID yazılım prensipleri; geliştirilen yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını sağlayan, kod tekrarını önleyen ve Robert C. Martin tarafından öne sürülen prensipler bütünüdür.

2)5 Bölüme ayrılır bunlar;
	2.1)Single Responsibility Principles:Bir Sınıfın sadece bir görevi olsun.Bir sınıfına birden fazla iş yüklenmemesini ön görür.

	2.2)Open & Close Principle:Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir. Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.

	2.3)Liskov Subtituon Princible: Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan Altsınıflarda oluşan nesneler (kalıtım)üst sınıflardan oluşan nesneler ile yer değiştirebilir olmalıdır.

	2.4)Interface Segragation Pricible: Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız

	3.5)Dependency  İnversion Principle:Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.

Bu projede her bir prensip için klasörler açıyoruz. 

DIP(Dependency  İnversion Principle)örneğinde sınıflar arası bağlılığı kaldırmak adına her nesne için yeni bir sınıf açıyoruz.Bu açtığımız sınıflar ana sınıf dediğimiz "IProduct" Sınıfımızdan kalıtım alıyor. Bu ana sınıfın içerisinde her sınıfın kullanabileceği bir methot oluşturuyoruz.ConCreat klasöründe ise sınıflarımız var sınıflarımızın içerisinde kalıtım aldıkları sınıfın methodu var bu methot bu sınıflar içerisinde hareket kazanıyor. Son olarak Restaurant sınııfmızda ana sınıfımızdan kalıtım almak yerine ana sınıfımızı liste yönetemi ile çekiyoruz.Foreach ile her bir product'ın içeirsinde dolaşıp gerekli birleştirmeyi yapıyoruz. Geri dönüş olarak talimatı döndürüyoruz.

ISP(Interface Segragation Pricible)Örneğimizde anlatılmak istenilen her sınıf yalnızca bir ana sınıftan türemez. Sınıflar arası özelliklerin değişiklik kazanacağından dolayı birden fazla interface'ımiz olabilir.

LSP(Liskov Subtituon Princible)Her şeklin kendi alan hesaplamasına sahip olduğundan emin oluyoruz. Dörtgen sınıfın  base yapısına sahip shape adında genel bir soyut class oluşturuyoruz.Böylelikle altsınıflarda oluşan nesneler üst sınıflardan oluşan nesneler ile yer değiştirebilir olmalıdır.

OCP(Open & Close)Örneğimizde tek bir arayüzde birden çok sınıf tanımlayıp, gerekli işlemleri yine bu arayüzde yapabilirdik. Yalnız bu örnek SOLID prensibine ters düşmüş olurdu.Biz bu örenkte bir ana sınıf oluşrutup sınıflarımızı tek tek açmış olduk ki SOLID Prensibine ters düşmemek için.
SRP(Single Responsibility Principles)Bir Sınıfın sadece bir görevi olsun.Bir sınıfına birden fazla iş yüklenmemesini ön görürdü hatırlarsanız.SRP'nin istediği gibi 2 classa bölerek. Bu prensibe uymuş olduk.

