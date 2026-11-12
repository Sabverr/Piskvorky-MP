#import "template.typ": thesis

#show: thesis(
    name: "Počítačová hra \"Piškvorky\"",
  major: "Informační technologie",
  class: "ITB4",
  year: 2026,
  author: "Dominik Tašlmár",
  abstract-cs: [
  Práce se zabývá návrhem a realizací počítačové hry Piškvorky pro dva hráče na jednom počítači. Aplikace je vytvořena v jazyce C\# v prostředí Microsoft Visual Studio s grafickým uživatelským rozhraním a využívá objektově orientovaný návrh. Hrací deska má volitelný rozměr a program po každém tahu automaticky vyhodnocuje souvislou řadu pěti stejných symbolů ve vodorovném, svislém i úhlopříčném směru, a spolehlivě tak rozpozná výhru či remízu. Hra dále nabízí časomíru, přehled skóre, vrácení tahu zpět, uložení rozehrané partie do souboru a trvalé uchovávání statistik výher v žebříčku. Neplatné tahy jsou blokovány a chyby při práci se soubory jsou ošetřeny. Vývoj probíhal průběžně na platformě GitHub se správou verzí. Výsledkem je funkční a přehledně strukturovaná aplikace, která splňuje všechny body zadání.
],
  abstract-en: [
  This thesis deals with the design and implementation of a computer version of the game Tic-Tac-Toe for two players on a single computer. The application is written in C\# in Microsoft Visual Studio with a graphical user interface and follows object-oriented design principles. The board size is configurable, and after each move the program automatically checks for an unbroken line of five identical symbols horizontally, vertically or diagonally, reliably detecting a win or a draw. The game also provides a timer, a score overview, an undo function, saving of an unfinished game to a file, and permanent storage of win statistics in a leaderboard. Invalid moves are blocked and file-handling errors are handled. Development was carried out incrementally using version control on GitHub. The result is a functional and clearly structured application that fulfils all requirements of the assignment.
],
  keywords-cs: [
    maturitní práce, C\#, .NET, piškvorky, 
  ],
  keywords-en: [
    graduation thesis, C\#, .NET, tic-tac-toe
  ],
  acknowledgements: [
    Děkuji - za cenné připomínky a rady, které mi poskytl při vypracování maturitní práce.
  ],
  assignment: [
        #image("assets/Zadani.jpg")
  ],
  declaration: [
  Prohlašuji, že jsem tuto práci vypracoval samostatně a uvedl v ní všechny prameny, literaturu a ostatní zdroje, které jsem použil. Při tvorbě práce jsem využil nástroje umělé inteligence, které mi sloužily jako pomocný nástroj. Veškerý obsah jsem před použitím sám zkontroloval a upravil a za výsledný text i program nesu plnou odpovědnost.
],
  date: "10. listopadu 2026",
  dictionary: (
    (
      key: "html",
      short: "HTML",
      long: "HyperText Markup Language",
    ),
  ),
  body: [
    = Úvod

    Toto téma jsem si zvolil proto, že piškvorky patří mezi hry, které zná téměř každý. Pravidla jsou jednoduchá, ale za jejich jednoduchostí se skrývá zajímavá logika. Chtěl jsem si vyzkoušet, jak se ze hry na papíře stane plnohodnotná počítačová aplikace. Zároveň jsem nechtěl nic graficky náročného.
    
    Cílem práce je vytvořit spolehlivou a přehledně strukturovanou aplikaci v jazyce C\# ve vývojovém prostředí Microsoft Visual Studio s grafickým uživatelským rozhraním. Důraz bude na správnosti detekce výhry, ukládání výher do souboru, ošetřování veškerých chyb a grafické zobrazení aplikace.

    Pro realizaci projektu, je potřeba umět tvorbu grafického rozhraní v prostředí .NET, práci se soubory včetně ošetření chyb a použití objektově orientovaného programování. Vývoj budu řídit postupně po menších krocích a každou dokončenou část budu průběžně ukládat do repozitáře na platformě GitHub, aby byla vidět celá historie vývoje. Stěžejní pro projekt je především správné navržení reprezentace hrací desky a spolehlivého algoritmu pro vyhodnocení výhry, na kterých stojí celá hra.

  = Teoretická Část
  
  ]
)