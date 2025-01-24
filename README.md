<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Blossom Boutique - README</title>
</head>
<body>
    <h1>Blossom Boutique</h1>

    <h3>Proje Hakkında:</h3>
    <p>Blossom Boutique, çiçek ve çiçek buketi satışı için tasarlanmış modern bir web platformudur. Kullanıcılar, farklı kategorilerdeki çiçekleri inceleyebilir, kendi buketlerini oluşturabilir ve hızlı bir şekilde sipariş verebilir. Bu proje, çiçek alışverişini daha keyifli ve kolay hale getirmek amacıyla geliştirilmiştir.</p>

    <hr>

    <h2>Sayfalar</h2>

    <h3>1. Admin Paneli Sayfası</h3>
    <h4>Genel Açıklama:</h4>
    <p>Admin Paneli sayfası, site yönetimi için kullanılan bir paneldir. Admin kullanıcıları bu sayfadan ürün ekleyebilir, mevcut ürünleri yönetebilir, kullanıcıları kontrol edebilir ve site ayarlarına erişebilirler.</p>
    <h4>İçerik ve Özellikler:</h4>
    <ul>
        <li><strong>Admin Girişi:</strong> Admin kullanıcılarının sisteme giriş yapabilmesi için bir form.</li>
        <li><strong>Ürün Yönetimi:</strong> Adminler, yeni ürünler ekleyebilir, var olan ürünleri düzenleyebilir ve silebilir.</li>
        <li><strong>Kullanıcı Yönetimi:</strong> Adminler, kullanıcıların bilgilerini görüntüleyebilir ve düzenleyebilir.</li>
    </ul>
    <h4>Kullanılan Teknolojiler:</h4>
    <ul>
        <li>ASP.NET MVC: Backend yapısı.</li>
        <li>HTML/CSS: Tasarım ve frontend kısmı.</li>
    </ul>

    <hr>

    <h3>2. Shop Sayfası</h3>
    <h4>Genel Açıklama:</h4>
    <p>Shop sayfası, kullanıcıların ürünleri görüntüleyebildiği, filtreleme ve sıralama gibi işlemleri gerçekleştirebildiği, ayrıca ürün detaylarına ulaşabildiği bir sayfadır. Kullanıcılar bu sayfa üzerinden alışverişe başlayabilirler.</p>
    <h4>İçerik ve Özellikler:</h4>
    <ul>
        <li><strong>Ürün Listesi:</strong> Tüm ürünler kart formatında gösterilir. Her bir kart şu bilgileri içerir:
            <ul>
                <li>Ürün Resmi</li>
                <li>Ürün İsmi</li>
                <li>Açıklama</li>
                <li>Fiyat</li>
                <li>"Buy Now" (Satın Al) Butonu</li>
            </ul>
        </li>
        <li><strong>Filtreleme ve Arama:</strong>
            <ul>
                <li>Kategori Filtreleme</li>
                <li>Fiyat Aralığı Filtreleme</li>
                <li>Stok Durumu</li>
                <li>Minimum Değerlendirme</li>
                <li>Koku Seçimi</li>
            </ul>
        </li>
        <li><strong>Admin Yetkileri:</strong> Admin kullanıcıları, ürün ekleme ve kullanıcı yönetimi bağlantılarına erişebilir.</li>
        <li><strong>Mobil Uygulama İndirimi:</strong> Sayfanın alt kısmında QR kod ile mobil uygulama indirme bağlantısı yer alır.</li>
    </ul>
    <h4>Kullanılan Teknolojiler:</h4>
    <ul>
        <li>HTML/CSS: Sayfanın temel yapısı ve tasarımı.</li>
        <li>ASP.NET: Model ve backend entegrasyonu.</li>
        <li>Session Kontrolü: Kullanıcı rolü yönetimi.</li>
    </ul>

    <hr>

    <h3>3. About Us Sayfası</h3>
    <h4>Genel Açıklama:</h4>
    <p>About Us (Hakkımızda) sayfası, ziyaretçilere mağaza hakkında bilgi verir. Mağaza misyonu, vizyonu ve sunduğu hizmetler hakkında detaylı bilgiler içerir.</p>
    <h4>İçerik ve Özellikler:</h4>
    <ul>
        <li><strong>Misyon ve Vizyon:</strong> Mağazanın hedefleri ve sunduğu hizmetler.</li>
        <li><strong>Takım Bilgileri:</strong> Şirketin kurucuları veya önemli çalışanlarının tanıtımı.</li>
        <li><strong>İletişim Bilgileri:</strong> Mağaza adresi, telefon numarası ve sosyal medya hesapları.</li>
    </ul>
    <h4>Kullanılan Teknolojiler:</h4>
    <ul>
        <li>HTML/CSS: Sayfa düzeni ve görsel tasarım.</li>
        <li>JavaScript: Sayfa animasyonları ve etkileşimli öğeler.</li>
    </ul>

    <hr>

    <h3>4. Contact Sayfası</h3>
    <h4>Genel Açıklama:</h4>
    <p>Contact sayfası, ziyaretçilerin mağaza ile iletişim kurabileceği bir sayfadır. Formlar aracılığıyla soru, öneri veya şikayetlerini gönderebilirler.</p>
    <h4>İçerik ve Özellikler:</h4>
    <ul>
        <li><strong>İletişim Formu:</strong> Ad, e-posta, konu ve mesaj alanları içerir.</li>
        <li><strong>Harita:</strong> Mağaza lokasyonunun harita üzerinde gösterimi.</li>
        <li><strong>İletişim Bilgileri:</strong> Telefon, e-posta ve adres bilgileri.</li>
    </ul>
    <h4>Kullanılan Teknolojiler:</h4>
    <ul>
        <li>HTML/CSS: Form tasarımı ve sayfa düzeni.</li>
        <li>JavaScript: Form doğrulama ve harita entegrasyonu.</li>
    </ul>

    <hr>

    <h3>5. Login Sayfası</h3>
    <h4>Genel Açıklama:</h4>
    <p>Login sayfası, kullanıcıların hesaplarına giriş yapabilmesi için gerekli olan sayfadır.</p>
    <h4>İçerik ve Özellikler:</h4>
    <ul>
        <li><strong>Giriş Formu:</strong> Kullanıcı adı ve şifre ile giriş yapılabilir.</li>
        <li><strong>Hesap Oluşturma Bağlantısı:</strong> Hesabı olmayan kullanıcılar için kayıt olma linki.</li>
        <li><strong>Şifreyi Unuttum Bağlantısı:</strong> Şifre sıfırlama işlemi için yönlendirme.</li>
    </ul>
    <h4>Kullanılan Teknolojiler:</h4>
    <ul>
        <li>HTML/CSS: Form ve sayfa tasarımı.</li>
        <li>ASP.NET: Kullanıcı doğrulama ve session yönetimi.</li>
    </ul>
</body>
</html>
