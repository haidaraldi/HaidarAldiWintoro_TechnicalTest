# HaidarAldiWintoro_TechnicalTest

Panduan Untuk Running Aplikasi

1. Clone projek ini dengan Visual Studio dan simpan pada direktori yang anda inginkan
2. Pastikan clone projek berhasil dan semua package sudah direstore secara otomatis
3. Setelah berhasil, lakukan clean dan rebuild pada projek
4. Untuk melakukan running pada bagian A, silakan klik kanan pada projek yang ingin dirunning (Tepat berada dibawah solution) pilih "Set as Startup Project"
5. Setelah dipilih tekan ctrl + f5 atau ke bagian tab Debug klik Start without debugging
6. Aplikasi akan running dan silakan uji coba sesuai keinginan anda
7. Setelah selesai, jika ingin running pada bagian B, silahkan expand projek  lalu copy "TechnicalTest.bak" pada folder database dan simpan pada direktori yang anda inginkan
8. Buka SQL Server Management Studio
9. Klik kanan pada folder databases pilih "Restore Databases"
10. Pada tab General pilih device pada bagian Device lalu klik icon dipojek kanan
11. Klik Add dan cari "TechnicalTest.bak" pada direktori yang anda sudah simpan sebelumnya, lalu klik OK
12. Klik OK
13. Klik OK, lalu database akan direstore.
14. Jika error, silahkan expand kembali projek "bagianB-AplikasiWeb" lalu copy "ScriptDatabase.sql" pada folder database dan simpan pada direktori yang anda inginkan
15. Buka script tersebut pada SQLServer Management Studio lalu jalankan query tersebut
16. Setelah berhasil pada bagian projek "bagianB-AplikasiWeb" klik "appsettings.json" dan silahkan sesuaikan nama server dan password SQL Servernya
17. Untuk melakukan running pada bagian B, silakan klik kanan pada projek "bagianB-AplikasiWeb" pilih "Set as Startup Project"
18. Tekan ctrl + f5 atau ke bagian tab Debug klik Start without debugging
19. Aplikasi akan running dan silakan uji coba sesuai keinginan anda
20. Selesai
