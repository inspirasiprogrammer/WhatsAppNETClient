# WhatsApp Client Library for .NET Developer

## Info Rilis

Bisa Anda cek di http://wa-net.coding4ever.net/

## Persyaratan Sistem

* .NET Framework 4.0, 4.5 dan .NET versi terbaru
*  Versi minimal Google Chrome harus versi 83.xx (jadi klo belum sama silahkan diupdate dulu)

Sebelum membuka source code, lakukan proses instalasi

## Instalasi

* Copykan file [chromedriver.exe](https://github.com/WhatsAppNETClient/WhatsAppNETClient/tree/master/libs) yang ada di folder **libs** ke folder **bin\Debug** atau **bin\Release**
* Jika folder **bin\Debug** atau **bin\Release** belum ada, silahkan lakukan proses build project terlebih dulu.

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