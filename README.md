# siguria_projekti_gr32

Programi ka per detyre gjetjen e frekuences se shkronjave ne menyre qe te behet zevendesimi i tyre me shkronjat me te perdorura ne gjuhen Angleze varesisht prej frekuences se gjetur, me qellim qe te gjindet plaintexti per codin e Cezarit.

Programin e kam zhvilluar ne dy format per gjetjen e frekuences se shkronjave, pra ne Console Application dhe ne Desktop Application.
**Tek Console App**, se pari kam kerku prej user qe te shtyp nje tekst, pastaj nga ai text permes string.Replace() kam zevendesuar shenjat e pikesimit dhe hapesirat me nje string.Empty,  ne menyre qe te llogaritet vetem frekuenca e shkronjave, pasiqe shenjat e pikesimit nuk kane shume rendesi per gjetjen e plaintext-it.
Numerimin e shkronjave qe gjenden ne tekst e kam bere permes nje while loop e cila ekzekutohet nese gjatesia e tekstit eshte me e madhe se 0, perndryshe jo.
Ne While Loop e kam deklaru ni variabel countOfChar = 0 me ane te se ciles do te bej numerimin e shkronjave. Shkronjat i marrim permes anetarit te pare te tekstit[0] (ose shkronjes se pare te tekstit) pasiqe e  dijme qe stringu eshte nje varg i karaktereve, dhe vazdhdojme tutje tek shkronjat tjera permes for loop, pas cdo anetari te marre teksti ne
heren e ardhshme do te hyje ne for loop me nje anetar me pak per shkak te ketij rreshti te kodit : _inputText = inputText.Replace(inputText[0].ToString(), string.Empty);_,
numri i shkronjave do te rritet per 1 nese ato perseriten.

**Tek Desktop App**


