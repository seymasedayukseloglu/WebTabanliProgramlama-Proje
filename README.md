<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Blossom Boutique Projesi</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 20px;
            background-color: #f4f4f9;
        }
        h1, h2, h3 {
            color: #333;
        }
        h2 {
            margin-top: 40px;
        }
        p {
            font-size: 1rem;
            color: #666;
        }
        ul {
            list-style-type: none;
            padding-left: 0;
        }
        li {
            margin-bottom: 10px;
        }
        .page-section {
            margin-bottom: 40px;
        }
        .technologies {
            font-style: italic;
        }
        .features, .technologies {
            margin-left: 20px;
        }
        .separator {
            border-top: 1px solid #ccc;
            margin-top: 20px;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <h1>Blossom Boutique Projesi</h1>
    <div class="page-section">
        <h2>Proje Hakkında:</h2>
        <p>Blossom Boutique, çiçek ve çiçek buketi satışı için tasarlanmış modern bir web platformudur. Kullanıcılar, farklı kategorilerdeki çiçekleri inceleyebilir, kendi buketlerini oluşturabilir ve hızlı bir şekilde sipariş verebilir. Bu proje, çiçek alışverişini daha keyifli ve kolay hale getirmek amacıyla geliştirilmiştir.</p>
    </div>
    <div class="separator"></div>
    <div class="page-section">
        <h2>Sayfalar</h2>
        <h3>1. Admin Paneli Sayfası</h3>
        <p><strong>Genel Açıklama:</strong> Admin Paneli sayfası, site yönetimi için kullanılan bir paneldir. Admin kullanıcıları bu sayfadan ürün ekleyebilir, mevcut ürünleri yönetebilir, kullanıcıları kontrol edebilir ve site ayarlarına erişebilirler.</p>
        <ul class="features">
            <li><strong>Admin Girişi:</strong> Admin kullanıcılarının sisteme giriş yapabilmesi için bir form.</li>
            <li><strong>Ürün Yönetimi:</strong> Adminler, yeni ürünler ekleyebilir, var olan ürünleri düzenleyebilir ve silebilir.</li>
            <li><strong>Kullanıcı Yönetimi:</strong> Adminler, kullanıcıların bilgilerini görüntüleyebilir ve düzenleyebilir.</li>
        </ul>
        <p class="technologies"><strong>Kullanılan Teknolojiler:</strong> ASP.NET MVC, HTML/CSS</p>
        <div class="separator"></div>
        <h3>2. Shop Sayfası</h3>
        <p><strong>Genel Açıklama:</strong> Shop sayfası, kullanıcıların ürünleri görüntüleyebildiği, filtreleme ve sıralama gibi işlemleri gerçekleştirebildiği, ayrıca ürün detaylarına ulaşabildiği bir sayfadır. Kullanıcılar bu sayfa üzerinden alışverişe başlayabilirler.</p>
        <ul class="features">
            <li><strong>Ürün Listesi:</strong> Ürünler kart formatında gösterilir. Her kartta ürün resminin yanı sıra isim, açıklama ve fiyat bilgisi bulunur.</li>
            <li><strong>Filtreleme ve Arama:</strong> Kategori Filtreleme, Fiyat Aralığı Filtreleme, Stok Durumu, Minimum Değerlendirme gibi seçenekler.</li>
            <li><strong>Admin Yetkileri:</strong> Adminler, ürün ekleme ve kullanıcı yönetimi bağlantılarına erişebilir.</li>
            <li><strong>Mobil Uygulama İndirimi:</strong> Sayfanın alt kısmında QR kod ile mobil uygulama indirme bağlantısı.</li>
        </ul>
        <p class="technologies"><strong>Kullanılan Teknolojiler:</strong> HTML/CSS, ASP.NET, Session Kontrolü</p>
        <div class="separator"></div>
        <h3>3. About Us Sayfası</h3>
        <p><strong>Genel Açıklama:</strong> About Us sayfası, ziyaretçilere mağaza hakkında bilgi verir. Mağaza misyonu, vizyonu ve sunduğu hizmetler hakkında detaylı bilgiler içerir.</p>
        <ul class="features">
            <li><strong>Misyon ve Vizyon:</strong> Mağazanın hedefleri ve sunduğu hizmetler.</li>
            <li><strong>Takım Bilgileri:</strong> Şirketin kurucuları veya önemli çalışanlarının tanıtımı.</li>
            <li><strong>İletişim Bilgileri:</strong> Mağaza adresi, telefon numarası ve sosyal medya hesapları.</li>
        </ul>
        <p class="technologies"><strong>Kullanılan Teknolojiler:</strong> HTML/CSS, JavaScript</p>
        <div class="separator"></div>
        <h3>4. Contact Sayfası</h3>
        <p><strong>Genel Açıklama:</strong> Contact sayfası, ziyaretçilerin mağaza ile iletişim kurabileceği bir sayfadır. Formlar aracılığıyla soru, öneri veya şikayetlerini gönderebilirler.</p>
        <ul class="features">
            <li><strong>İletişim Formu:</strong> Ad, e-posta, konu ve mesaj alanları içerir.</li>
            <li><strong>Harita:</strong> Mağaza lokasyonunun harita üzerinde gösterimi.</li>
            <li><strong>İletişim Bilgileri:</strong> Telefon, e-posta ve adres bilgileri.</li>
        </ul>
        <p class="technologies"><strong>Kullanılan Teknolojiler:</strong> HTML/CSS, JavaScript</p>
        <div class="separator"></div>
        <h3>5. Login Sayfası</h3>
        <p><strong>Genel Açıklama:</strong> Login sayfası, kullanıcıların hesaplarına giriş yapabilmesi için gerekli olan sayfadır.</p>
        <ul class="features">
            <li><strong>Giriş Formu:</strong> Kullanıcı adı ve şifre ile giriş yapılabilir.</li>
            <li><strong>Hesap Oluşturma Bağlantısı:</strong> Hesabı olmayan kullanıcılar için kayıt olma linki.</li>
            <li><strong>Şifreyi Unuttum Bağlantısı:</strong> Şifre sıfırlama işlemi için yönlendirme.</li>
        </ul>
        <p class="technologies"><strong>Kullanılan Teknolojiler:</strong> HTML/CSS, ASP.NET</p>
        <div class="separator"></div>
        <h3>6. Home Sayfası</h3>
        <p><strong>Genel Özellikler:</strong> Modern ve şık bir tasarıma sahip ana sayfa, kullanıcı dostu özellikler sunar.</p>
        <ul class="features">
            <li><strong>Header:</strong> Kullanıcıyı karşılayan duyuru mesajı.</li>
            <li><strong>Logo:</strong> Blossom Boutique logosu, hover efektiyle renk değiştirir.</li>
            <li><strong>Navigasyon Menüsü:</strong> Sayfalar arasında geçiş yapılabilmesi için Home, Shop, About Us ve Contact bağlantıları içerir.</li>
            <li><strong>Hero Section:</strong> Otomatik oynayan video ve hoş geldiniz mesajı.</li>
            <li><strong>Shop Section:</strong> Ürünler tanıtılır.</li>
            <li><strong>Footer:</strong> QR kod ile uygulama indirme bağlantısı.</li>
        </ul>
        <p class="technologies"><strong>Kullanılan Teknolojiler:</strong> HTML5, CSS3, JavaScript</p>
        <div class="separator"></div>
    </div>
</body>
</html>
