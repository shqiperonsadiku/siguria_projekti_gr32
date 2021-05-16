# Siguria e te dhenave GRUPI 32
# Sulmimi i kodit te Cezarit duke mesuar frekuencen e shkronjave nga ndonje tekst file.
Programi ka per detyre gjetjen e frekuences se shkronjave ne menyre qe te behet zevendesimi i tyre me shkronjat me te perdorura ne gjuhen Angleze varesisht prej frekuences se gjetur, me qellim qe te gjindet plaintexti per codin e Cezarit.

Programin e kam zhvilluar ne dy variante, pra ne: 
# Console Application
# Desktop Application

**Tek Console App** 
Se pari kam kerku prej user qe te shtyp nje tekst, pastaj nga ai text permes string.Replace() kam zevendesuar shenjat e pikesimit dhe hapesirat me nje string.Empty,  ne menyre qe te llogaritet vetem frekuenca e shkronjave, pasiqe shenjat e pikesimit nuk kane shume rendesi per gjetjen e plaintext-it.
Numerimin e shkronjave qe gjenden ne tekst e kam bere permes nje while loop e cila ekzekutohet nese gjatesia e tekstit eshte me e madhe se 0, perndryshe jo.
Ne While Loop e kam deklaru ni variabel countOfChar = 0 me ane te se ciles do te bej numerimin e shkronjave. Shkronjat i marrim permes anetarit te pare te tekstit[0] (ose shkronjes se pare te tekstit) pasiqe e  dijme qe stringu eshte nje varg i karaktereve, dhe vazdhdojme tutje tek shkronjat tjera permes for loop, pas cdo anetari te marre, teksti ne heren e ardhshme do te hyje ne for loop me nje anetar me pak per shkak te ketij rreshti te kodit : _inputText = inputText.Replace(inputText[0].ToString(), string.Empty);_,
numri i shkronjave do te rritet per 1 nese ato perseriten. 

**Tek Desktop App**
Ne fillim te ofrohet mundesia te besh load nje file nga PC i juaj, ose mund ta shkruash tekstin te cilin do ta dekriptosh permes celesit qe gjindet nga frekuenca se shkronjave. Kete e kam realizuar permes nje textBox-i ne te cilin mund ta shkruash tekstin, ose nese klikon butonin _Load File_, permes _OpenFileDialog_ built-in funksionit, text file-in qe e selekton nga PC shfaqet ne po ate text box. Pastaj e kemi butonin _**Get Frequency**_ i cili bene llogaritjen e frekuences se shkronjave ne tekstin e dhene me heret, duke i injoruar shenjat e pikesimit dhe hapesirat. Llogaritja e frekuences behet ne te njejten logjike sikur te _**Console App**_ (pra permes nje _while loop_). Rezultati i fituar nga llogaritja shfaqet ne nje List View, por gjithashtu shfaqet edhe ne forme te nje _**Chart**_-i. Me poshte e kemi butonin _**Show Data**_ dhe _label_-en _English letter frequency_ , me klikimin e butonit shfaqet frekuenca e shkronjave ne gjuhen Angleze(te dhenat per kete pjese jane te vendosura manualisht nga GOOGLE) ne forme te nje _chart_-i. Kjo pjese e aplikacionit na ndihmon ne gjetjen e celesit per dekriptimin e kodit te Cesarit (**P.sh** nese ne ciphertext shkronja **I** e ka frekuencen me te madhe, dhe e dime qe ne gjuhen Angleze shkronja me e perodur eshte **E**, atehere gjasat jane qe **E** eshte zevendesuar me **I** ne ciphertext apo eshte zhvendosur per 4 vende ne baze te alfabetit, rrjedhimisht edhe celesi do te jete me shume gjase 4.), duke e bere krahasimin e shkronjave. Pasiqe ta gjejme celesin , ate mund ta shenojme tek textbox-i ku shkruan _Enter Key Value_ , dhe me klikimin e butonit _Enter_ do te behet dekriptimi i ciphertextit me ane te celesit qe i kemi dhene si vlere. 
Dekriptimi edhe tek **Console App** edhe tek **Desktop App** behet permes nje funksioni te vecante **_Decrypt(string ciphertext, int key)_** i cili merr si parametra ciphertext-in e shenuar nga perdoruesi dhe celesin me te cilin dekriptohet ciphertext-i per t'u fituar plaintext-i.

