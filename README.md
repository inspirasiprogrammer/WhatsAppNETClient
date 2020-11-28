# WhatsApp Client Library for .NET Developer

## Info Rilis

Bisa Anda cek di http://wa-net.coding4ever.net/

## Persyaratan Sistem

* .NET Framework 4.0, 4.5 dan .NET versi terbaru
*  Versi minimal Google Chrome harus versi 87.xx (jadi klo belum sama silahkan diupdate dulu)

Sebelum membuka source code, lakukan proses instalasi

## Instalasi

* Buka project WhatsAppNETClient, kemudian klik kanan solution `WhatsAppNETAPI` -> `Rebuild Solution`.
* Copykan file [chromedriver.exe](https://github.com/WhatsAppNETClient/WhatsAppNETClient/tree/master/libs) yang ada di folder **libs** ke folder **bin\Debug** atau **bin\Release**
* Selesai, Anda bisa langsung menjalankan project.

## Melaporkan Bug atau Error

Secara teknis dalam pengembangan sebuah aplikasi jelas tidak mungkin 100% bebas dari bug. Nah jika Anda menemukan bug atau error pada saat menggunakan library WhatsApp NET Client ini, silahkan Anda laporkan di halaman [https://github.com/WhatsAppNETClient/WhatsAppNETClient/issues](https://github.com/WhatsAppNETClient/WhatsAppNETClient/issues).

Error yang sering terjadi adalah ketika versi google chrome Anda tidak kompatibel dengan versi ChromeDriver (WebDriver for Chrome), sehingga Anda harus mendownload ulang file [chromedriver.exe](https://chromedriver.chromium.org/downloads) yang menyesuaikan dengan versi google chrome Anda.

## Downgrade .NET Framework Contoh Project

WhatsApp NET Client tersedia dalam dua versi yaitu:

1. Versi .NET Framework 4.0 untuk Windows XP, Windows Server 2003, Windows Vista, Windows Server 2008 dan Windows 7.
2. Versi .NET Framework 4.5 untuk windows 7 ke atas.

Secara default contoh project cara menggunakan library WhatsApp NET Client ini dibuat menggunakan .NET Framework 4.5.

Bagi Anda yang ingin membuka project tersebut di .NET Framework 4, ikuti langkah-langkah berikut:

1. Klik kanan project -> properties
   Aktifkan tab Application, kemudian ganti Target framework menjadi .NET Framework 4
2. Hapus library *WebDriver* dan *WhatsAppNETAPI* yang ada di node *References*, kemudian ganti dengan library *WebDriver* dan *WhatsAppNETAPI* yang ada di folder **libs\net40**
3. Build ulang project
4. Selesai