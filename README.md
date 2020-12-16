# IRF_Project

Tételek: 1. C XML feldolgozás (fájlból, vagy webszolgáltatásból)
	 2. B Kifejtett setter ág használata, értékadásra értelemszerű funkciók hívása
	 3. A Írás CSV fájlba
	 4. D Timer használata

Timer: 	A program elindítása után 5 perccel bezárja azt. A hátralévő időt egy labelről lehet leolvasni a jobb
       	felső sarokban. A label alatt van egy gomb "Reset" felirattal, amivel újra lehet indítani a számlálót.
	Ha számláló eléri a nullát, a program bezárja magát.

Xml beolvasás: 	Három darab lokális Xml fájlt lehet  betölteni egy BindingListbe, ami egy DataGridViewban jelenik meg. Az első 
		autókról tárol adatokat(márka, típus, évjárat, szín),a második emberekről tárol adatokat(kor, vezetéknév, keresztnév, e-mail cím),
 		a harmadik pedig egy üzletbenlévő termékek adatait tárolja(termék neve, beszerzési ára, eladási ára, mértékegysége).
		Az xml-eket külön gombokkal lehet beolvasni, és ha egy xml többedjére van megnyitva, akkor az eddig megnyitott adatokat törli,
		hogy ne ismétlődjenek azok.

CSV írás: 	Mindegyik xml-nek megvan a saját mentés gombja. Ezekre kattintva lementi az adott xml-hez tartozó BindingList tartalmát UTF-8 formátumban