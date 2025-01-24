# Blossom Boutique

**Proje Hakkında:**

Blossom Boutique, çiçek ve çiçek buketi satışı için tasarlanmış modern bir web platformudur. Kullanıcılar, farklı kategorilerdeki çiçekleri inceleyebilir, kendi buketlerini oluşturabilir ve hızlı bir şekilde sipariş verebilir. Bu proje, çiçek alışverişini daha keyifli ve kolay hale getirmek amacıyla geliştirilmiştir.

---

## Sayfalar

### 1. Admin Paneli Sayfası

**Genel Açıklama:**

Admin Paneli sayfası, site yönetimi için kullanılan bir paneldir. Admin kullanıcıları bu sayfadan ürün ekleyebilir, mevcut ürünleri yönetebilir, kullanıcıları kontrol edebilir ve site ayarlarına erişebilirler.

**İçerik ve Özellikler:**
- **Admin Girişi:** Admin kullanıcılarının sisteme giriş yapabilmesi için bir form.
- **Ürün Yönetimi:** Adminler, yeni ürünler ekleyebilir, var olan ürünleri düzenleyebilir ve silebilir.
- **Kullanıcı Yönetimi:** Adminler, kullanıcıların bilgilerini görüntüleyebilir ve düzenleyebilir.

**Kullanılan Teknolojiler:**
- ASP.NET MVC: Backend yapısı.
- HTML/CSS: Tasarım ve frontend kısmı.

---

### 2. Shop Sayfası

**Genel Açıklama:**

Shop sayfası, kullanıcıların ürünleri görüntüleyebildiği, filtreleme ve sıralama gibi işlemleri gerçekleştirebildiği, ayrıca ürün detaylarına ulaşabildiği bir sayfadır. Kullanıcılar bu sayfa üzerinden alışverişe başlayabilirler.

**İçerik ve Özellikler:**
- **Ürün Listesi:** Tüm ürünler kart formatında gösterilir. Her bir kart şu bilgileri içerir:
  - Ürün Resmi
  - Ürün İsmi
  - Açıklama
  - Fiyat
  - "Buy Now" (Satın Al) Butonu
- **Filtreleme ve Arama:**
  - Kategori Filtreleme
  - Fiyat Aralığı Filtreleme
  - Stok Durumu
  - Minimum Değerlendirme
  - Koku Seçimi
- **Admin Yetkileri:** Admin kullanıcıları, ürün ekleme ve kullanıcı yönetimi bağlantılarına erişebilir.
- **Mobil Uygulama İndirimi:** Sayfanın alt kısmında QR kod ile mobil uygulama indirme bağlantısı yer alır.

**Kullanılan Teknolojiler:**
- HTML/CSS: Sayfanın temel yapısı ve tasarımı.
- ASP.NET: Model ve backend entegrasyonu.
- Session Kontrolü: Kullanıcı rolü yönetimi.

---

### 3. About Us Sayfası

**Genel Açıklama:**

About Us (Hakkımızda) sayfası, ziyaretçilere mağaza hakkında bilgi verir. Mağaza misyonu, vizyonu ve sunduğu hizmetler hakkında detaylı bilgiler içerir.

**İçerik ve Özellikler:**
- **Misyon ve Vizyon:** Mağazanın hedefleri ve sunduğu hizmetler.
- **Takım Bilgileri:** Şirketin kurucuları veya önemli çalışanlarının tanıtımı.
- **İletişim Bilgileri:** Mağaza adresi, telefon numarası ve sosyal medya hesapları.

**Kullanılan Teknolojiler:**
- HTML/CSS: Sayfa düzeni ve görsel tasarım.
- JavaScript: Sayfa animasyonları ve etkileşimli öğeler.

---

### 4. Contact Sayfası

**Genel Açıklama:**

Contact sayfası, ziyaretçilerin mağaza ile iletişim kurabileceği bir sayfadır. Formlar aracılığıyla soru, öneri veya şikayetlerini gönderebilirler.

**İçerik ve Özellikler:**
- **İletişim Formu:** Ad, e-posta, konu ve mesaj alanları içerir.
- **Harita:** Mağaza lokasyonunun harita üzerinde gösterimi.
- **İletişim Bilgileri:** Telefon, e-posta ve adres bilgileri.

**Kullanılan Teknolojiler:**
- HTML/CSS: Form tasarımı ve sayfa düzeni.
- JavaScript: Form doğrulama ve harita entegrasyonu.

---

### 5. Login Sayfası

**Genel Açıklama:**

Login sayfası, kullanıcıların hesaplarına giriş yapabilmesi için gerekli olan sayfadır.

**İçerik ve Özellikler:**
- **Giriş Formu:** Kullanıcı adı ve şifre ile giriş yapılabilir.
- **Hesap Oluşturma Bağlantısı:** Hesabı olmayan kullanıcılar için kayıt olma linki.
- **Şifreyi Unuttum Bağlantısı:** Şifre sıfırlama işlemi için yönlendirme.

**Kullanılan Teknolojiler:**
- HTML/CSS: Form ve sayfa tasarımı.
- ASP.NET: Kullanıcı doğrulama ve session yönetimi.
