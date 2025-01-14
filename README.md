# ASP.NET Web API - Product Management

Bu proje, ASP.NET Core kullanılarak geliştirilmiş bir ürün yönetim API'sidir. CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirilir ve API, Swagger üzerinde dokümantasyon sunar.

## Özellikler

- Ürünleri listeleme
- Tekil ürün bilgisi alma
- Yeni ürün ekleme
- Ürün bilgilerini güncelleme
- Ürün silme

## Kullanılan Teknolojiler

- ASP.NET Core Web API
- Entity Framework Core
- Swagger UI




## API Endpoint'leri

### 1. Tüm Ürünleri Listeleme
**GET** `/api/Product`

#### Örnek Yanıt:
```json
[
  {
    "id": 1,
    "name": "Ürün A",
    "price": "100 TL"
  },
  {
    "id": 2,
    "name": "Ürün B",
    "price": "200 TL"
  }
]
```

### 2. Belirli Bir Ürünü Getirme
**GET** `/api/Product/{id}`

#### Örnek Yanıt:
```json
{
  "id": 1,
  "name": "Ürün A",
  "price": "100 TL"
}
```

### 3. Yeni Ürün Ekleme
**POST** `/api/Product`

#### Gönderilecek Veri:
```json
{
  "name": "Ürün C",
  "price": "150 TL"
}
```

#### Örnek Yanıt:
```json
[
  {
    "id": 1,
    "name": "Ürün A",
    "price": "100 TL"
  },
  {
    "id": 2,
    "name": "Ürün B",
    "price": "200 TL"
  },
  {
    "id": 3,
    "name": "Ürün C",
    "price": "150 TL"
  }
]
```

### 4. Ürün Güncelleme
**PUT** `/api/Product`

#### Gönderilecek Veri:
```json
{
  "id": 1,
  "name": "Ürün A+",
  "price": "120 TL"
}
```

#### Örnek Yanıt:
```json
[
  {
    "id": 1,
    "name": "Ürün A+",
    "price": "120 TL"
  },
  {
    "id": 2,
    "name": "Ürün B",
    "price": "200 TL"
  }
]
```

### 5. Ürün Silme
**DELETE** `/api/Product/{id}`

#### Örnek Yanıt:
```json
[
  {
    "id": 2,
    "name": "Ürün B",
    "price": "200 TL"
  }
]
```

## Projeyi Çalıştırma

1. Projeyi klonlayın:
```bash
git clone https://github.com/coderVi/WebApi.git
```

2. Bağımlılıkları yükleyin:
```bash
dotnet restore
```

3. Veritabanını güncelleyin:
```bash
dotnet ef database update
```

4. Uygulamayı başlatın:
```bash
dotnet run
```

5. Tarayıcınızda Swagger arayüzüne erişin:
```
http://localhost:<port>/swagger
```

## Notlar
- Fiyat alanı `string` olarak saklanmaktadır, bu nedenle fiyatla ilgili işlemler yapılırken dikkat edilmelidir.
- Geliştirme sırasında veritabanı bağlantı ayarlarını `appsettings.json` dosyasından yapılandırabilirsiniz.

---

Eğer eklememi istediğiniz başka bir şey varsa, lütfen belirtin!
