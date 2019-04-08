# Dokumentáció

- MVC

 [netes rajzoló folyamat ábrákhoz](www.asciidraw.com)

ALT GR + 7 
```
 +------------------------------+    +---------------------------+
 | Internet böngésző            |    | ASP.NET MVC webalkalmazás |
 |------------------------------|    |---------------------------|
 |                              |    |                           |
 | +-------------------------+  |http|  +------------+           |
 | |  HTML állomány a válasz |  |+-->|+->Útválasztás |+----+     |
 | |                         |  |    |  +------------+     v     |
 | |                         |<-+<--+| +--------+ +------------+ |
 | |                         |  |    | |Layout  | |            | |
 | |                         |  |    <-++       | | Controller
 | |                         |  |    | |View    <-+ + Action   | |
 | +-------------------------+  |    | |        | |            | |
 |                              |    | +--------+ +------------+ |
 +------------------------------+    +---------------------------+
```

## Az étterem projekt leírása (specifikáció)
- Képernyőképek
- képernyőképeket (egyelőre) nem készítünk, mert az MVC template-ek elkészítik nekünk a képernyőket, azt nem tudjuk egyszerűen befolyásolni. Így amit kapunk azt fogjuk használni.

## Szereplők akik adatokat használnak
  ## vendég
  ## Érdeklődő
  ## Étlap
  ## Példa étlap

   - Pizzák
 ------
  - Margarita pizza 200 Ft
  mozzarella sajt, pizzaszósz
  - Hawaii pizza    300 Ft
  sonka, ananász, mozzarella sajt, pizzaszósz
    - Italok
------
  - Ásványvíz 100 Ft (3dl)
  - Cola      120 Ft (3dl)

## FORGATÓKÖNYVEK

 - Érdeklődő eldönti, hogy akar-e nálunk enni?
 - Érdeklődő elkéri az étlapot és megnézi, hogy mit lehet nálunk enni, mennyiért.