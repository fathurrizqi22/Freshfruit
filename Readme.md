# Fresh Fruit
aplikasi ini mensimulasi kan terhadap pegambilan buah dari keranjang, list buah dan batas pengambilan.

## Fungsionalitas
- user dapat memilih buah mana yang ingin ditambahkan kedalam keranjang.

### Tugas
1. Apa fungsi BucketventListener?
 
   Berfungsi menampilkan pesan dari fungsi `void OnSucced()` dan `void OnFailed` ketika gagal atau berhasil.   


2. Buatlah class diagramnya

3. Berilah pembahasan alur atau logika pemrogramannya.
   
    Saat button add diklik fungsi `public void addFruit` dipanggil dan mengecek apakah bucket kosong atau penuh. Jika penuh maka fungsi `bucketIsOverload` akan dipanggli
    dan menampilkan message ops keranjang buah sedang penuh dan jika tidak penuh maka akan memanggil fungsi `ths.insert(fruti)` lalu buah akan dapat ditambahkan ke keranjang dan
    menampilkan messasge yeay berhasil ditambahkan

