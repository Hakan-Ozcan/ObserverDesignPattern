Observer tasarım deseni, nesneler arasında bir bağlantı kurarak bir nesnenin durumu değiştiğinde bağımlı olan diğer nesnelere otomatik olarak haber veren bir tasarım desenidir.
Bu desen, "birçok-tek" bağıntı örneği olarak düşünülebilir. Yani bir nesne, birden fazla başka nesne tarafından izlenir ve durumu değiştiğinde bu izleyicilere bildirim gönderir.
Böylece, nesneler arasındaki bağımlılıklar azalır ve bir nesnenin değişikliklerinden etkilenen diğer nesneleri de kolayca yönetebiliriz.

Observer deseninde ana bileşenler şunlardır:

Gözlemci (Observer) Arayüzü: İzleyici nesnelerin uygulaması gereken arayüzü tanımlar. Genellikle bir "Güncelle" metodu bulunur,
böylece gözlemciye bildirilen değişikliklerle güncellenir.

Somut Gözlemci (Concrete Observer): Gözlemci arayüzünü uygulayan somut sınıflardır. Belirli olayları izlemek ve alınan bildirimlere göre tepki göstermek için kullanılırlar.

Konu (Subject) Soyut Sınıfı: İzlenen nesnelerin soyut sınıfını tanımlar ve gözlemcilerin (izleyicilerin) bu nesneyi nasıl izleyebileceğini belirler.

Somut Konu (Concrete Subject): Konu soyut sınıfını uygulayan somut sınıflardır. İzleyicileri eklemek, kaldırmak ve bildirim göndermek gibi işlemleri gerçekleştirirler.