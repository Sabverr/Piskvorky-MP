Piškvorky je desktopová aplikace vytvořená v programovacím jazyce C# s využitím Windows Forms. Aplikace umožňuje hru dvou hráčů na jednom počítači.

Hráči se střídají v umisťování symbolů X a O na hrací plochu. Cílem hry je vytvořit souvislou řadu alespoň pěti stejných symbolů v horizontálním, vertikálním nebo diagonálním směru.
Použité technologie

Programovací jazyk: C#
Vývojové prostředí: Microsoft Visual Studio
Grafické rozhraní: Windows Forms
Správa verzí: Git a GitHub

Datové struktury

Symbol.cs
Výčtový typ Symbol obsahuje hodnoty None, X a O. Hodnota None představuje prázdné políčko.

Board.cs
Třída Board reprezentuje hrací plochu pomocí dvourozměrného pole Symbol[,]. Umožňuje vytvářet desky různých velikostí, kontrolovat platnost tahů a zjišťovat zaplnění hrací plochy.

Player.cs
Třída Player obsahuje jméno hráče a jeho přiřazený symbol.

Game.cs
Třída Game řídí průběh hry. Zajišťuje střídání hráčů, vyhodnocování výherních kombinací a kontrolu remízy.
Algoritmus vyhodnocování výhry

Po každém platném tahu se kontrolují čtyři základní směry:
    Horizontální
    Vertikální
    Diagonální zleva nahoře doprava dolů
    Diagonální zprava nahoře doleva dolů

V každém směru se postupně počítají sousední políčka se stejným symbolem na obou stranách posledního tahu.
Pokud počet souvislých symbolů dosáhne alespoň pěti, hra skončí vítězstvím aktuálního hráče.
Pokud je hrací plocha zaplněna a žádný hráč nevytvořil výherní kombinaci, hra skončí remízou.

Grafické rozhraní
Hlavní menu obsahuje možnost spuštění a ukončení aplikace. Před zahájením hry si uživatel zvolí velikost hrací plochy, minimálně 5 × 5.

Hrací plocha se dynamicky vytváří pomocí komponenty TableLayoutPanel. Jednotlivá políčka představují tlačítka, která reagují na kliknutí hráče.

Struktura projektu
Projekt využívá objektově orientované programování a odděluje herní logiku od grafického uživatelského rozhraní.
