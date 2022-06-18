# MiniShopApp
 
Proje çalışmaları devam etmektedir şuan son halinde değildir. Bu yüzden bazı kısımlarda error alabilirsiniz
Girilen Projede MiniShopApp.WebUI dosyası içinde appsetting.json içindeki mailgiriniz ve şifregiriniz kısmına mail ve şifrelerinizi girdiğinizde mail gönderme onaylama işlemleri gerçekleşmektedir.

Projeyi Çalıştırmak için yapılması gerekenler
MiniShopApp.WebUI katmanında appsetting.json klasörünün içinde mail adresi ve şifresi giriniz aksi takdirde kayıt olma işlemlerinde mail gönderme işlemi sağlanamayacaktır.

Ayrıca Kullanılan Ödeme Sistemi demo ödeme sistemidir Iyzico developer sayfasından alınmıştır. Kendiniz hesap açarak ödemeleri kontrol edebilirsiniz bunun için ise MiniShopApp.WebUI katmanında Card Controller kısmında PaymentProcess içindeki secretkey ve apikey leri kendi açtığınız hesap ile değiştirmeniz gerekmektedir.

Ödeme işlemi gerçekleştirirken Default card özellikleri olan
 
 //paymentCard.CardNumber = "5528790000000008";
 //paymentCard.ExpireMonth = "12";
 //paymentCard.ExpireYear = "2030";
 //paymentCard.Cvc = "123";

bu bilgiler kullanılmalıdır.
