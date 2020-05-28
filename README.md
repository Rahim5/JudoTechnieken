# JudoTechnieken
Het idee was om een api te maken dat mij zou helpen tijdens de judo examens. Het is niet zo gemakkelijk om alle technieken van elke gordel te onthouden
dus dacht ik het een goed idee zou zijn om een overzicht te hebben van wat ik nodig heb.

TECHNIEKENCONTROLLER
[GET REQUESTS]
+ api/v1/tecnieken/ ==> Alle technieken opvragen
+ api/v1/technieken/{id} ==> Techniek met bepaald id opvragen
QUERIES: naam | type (beenworp,schouderworp,heupworp)  | moeilijkheidsgraad (makkelijk,gemiddeld, moeilijk) | pagina | sorteer | richting (asc,desc)

[POST REQUESTS]
+ api/v1/technieken ==> FromBody techniek toevoegen

[DELETE REQUESTS]
+ api/v1/technieken/{id} ==> Techniek met bepaald id verwijderen

[PUT REQUESTS]
+ api/v1/technieken/ ==> FromBody techniek aanpassen


De andere controllers hebben identieke requests, alleen hebben ze geen queries zoals de main TechniekenController.

BEVEILIGING: Indien men naar https://localhost:44377/api/token een POST REQUEST doet, dan krijgen we een JWT-token van de server. Als we dan deze in 
de header meesturen met een GET-REQUEST, krijgen we toegang tot de beveiligde delen van de api. Maar deze heb ik uitgeschakeld omdat het niet werkt met de
angular client.

Deze gegevens moet je meesturen in de POST-REQUEST om een token te krijgen:
"Email": "InventoryAdmin@abc.com",
"Password": "$admin@2017"

____________________________________________________CLIENT___________________________________________________________

+Blauwe 'KRIJG ALLE TECHNIEKEN' button om de eerste 10 technieken in de tabel te zien.
+Techniek id input veld, waarin alleen nummers boven 0 worden getoond. Elke nummer wordt apart getoond in de tabel. Youtube video werkt niet voor een of andere reden.
 Ik heb alles gedaan zoals het moet, maar de url wil gewoon niet accepteren.
+Blauwe 'ZOEK TECHNIEK' button, deze werkt niet, geen idee waarom. Console.log verschijnt wel met de juiste waarde.
+Rode 'VERWIJDER TECHNIEK' button samen met een techniek id input veld om een specifiek techniek te verwijderen.
+Twee filters [Type] en [Moeilijkheidsgraad]. Deze werken zoals het moet.
+Tabel met overzicht van technieken
+Tweede tabel bedoeld om technieken aan te vullen/aanpassen samen met POST en UPDATE button.
+Input veld naast UPDATE button ==> dit is een fout, deze button heeft geen enkele nut.
+LOGIN button werkt niet, want kon de jwt-token niet (opslagen en) doorsturen via angular naar de server.

___________________________________________________3rd Party API_______________________________________________________

Bedoeling was om automatisch video's van youtube te halen voor de technieken. Zodat men kon zien hoe een techniek werd uitgevoerd.

Dit is hoe het eruit ziet: https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=1&q=${naam}&key=AIzaSyAELPrFpHnuvoz0ou7W4XSVMKVecnWZoFI
[maxResults]: Het aantal video's dat men vindt. Dit heb ik op 1 gezet, want ik wou maar 1 video per techniek.
[q]=&{naam}: q is hier de zoekterm, dus dit moet gelijk zijn aan de naam van de techniek, die ik meegeef als parameter.
[key]: Dit is de api-key om er gebruik van te maken.

In de html waren er problemen om de video te laten zien. Angular doet moeilijke met de url van de video's. Ik heb geprobeerd om met SafeResourceUrl te werken, maar dit is niet gelukt



