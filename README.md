##Genel Git Komutları sırası ile

1- git clone https://github.com/burakzdmr/mvc-odev-2.git

2- git add * (değişiklikleri githuba pushlamak için adım:1)
   git commit -m "buraya commitinizde neler yaptınız onu açıklarsınız" (adım:2)
   git push  (push komutunu çalıştırmadan önceki herşey hala localinizde, pushu çalıştırdıngınızda ilgili değişikliği uzak repoya pushlarsınız, burada bahsedilen uzak repo şuan için github) (adım : 3)


-------------------------------------------------------------

Note, User için ayrı view klasörleri ve bunların altında ilgili sayfalar eklendi. ödevde istenen değişiklikler bu sayfalar altında yapılabilir.

--------------------------------------------------------------

Uygulamada build aldıgınızda şuna benzer pathler oluşucak :

https://localhost:7010/Note/NoteAdd
https://localhost:7010/Note/NoteList
https://localhost:7010/Note/NoteEdit
https://localhost:7010/User/UserList
https://localhost:7010/User/UserEdit

(bu pathlerin; view klasörü altından beslendiği ve aynı isimde controllerlara ihtiyacı oldugu unutulmamalı : (HomeController , UserController vs...))

