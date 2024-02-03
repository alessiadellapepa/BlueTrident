# BlueTrident
Contenuto di quetso progetto:
- Cartella 'csv' contenente i file .csv originali delle registrazioni estratte utilizzando la piattaforma Nexus
- File Excel 'RaccoltaDati.xlsx' contenente le linee guida per la lettura dei dati raccolti e che spiegano in breve i movimenti registrati e gli ID associati ad ogni movimento raccolto
- Cartella 'BlueTridentAnalysisProject' contenente il necessario per l'esecuzione del codice Python
- Cartella 'BlueTridentUnityProject' contenente il necessario per l'esecuzione del progetto Unity
## Come eseguire il progetto Python
- Crea un nuovo progetto Python.
- All'interno della cartella principale del tuo progetto copia ed incolla i file presenti all'interno della cartella BlueTridentAnalysisProject (ossia la cartella Registrazioni ed i due eseguibili python).
- Nelle impostazioni del progetto importa la libreria : matplotlib.

Nella cartella Registrazioni sono contenute le registrazioni relative ai singoli movimenti registrati: sono state estratte le informazioni dai file originali presenti nella cartella 'csv' e per ogni file csv di movimento originale sono stati separati i dati relativi ai vari sensori in file diversi (Accelerometro, Giroscopio, Global Angle, HighG e Magnetometro).
### Esecuzione dei File .py
Prima di mandare in esecuzione uno dei due file, modifica il contenuto della chiamata open (line 15, in entrambi i file) con il percorso corretto della registrazione che vuoi analizzare. Le registrazioni nella cartella Registrazioni sono divise per sessioni di registrazione (NomeSessione=1874,1902) ed all'interno di esse trovi le registrazioni catalogate per ID# (segui guida all'interno del file fornito: RaccoltaDati.xlsx ). 

Dovrai modificare il parametro all'interno della chiamata open come segue: 
- open('Registrazioni/NomeSessione/ID/#/HighG.csv') nel caso si stesse utilizzando la classe AnalisiAccelerometro.py
- open('Registrazioni/NomeSessione/ID/#/Magnetometro.csv') nel caso si stesse utilizzando la classe AnalisiMagnetometro.py

Esempio pratico: voglio eseguire AnalisiAccelerometro.py relativamente al movimento Extra 0 eseguito nella sessione 1874. 
Sostituirò la chiamata open con : open('Registrazioni/1874/E/0/HighG.csv')

### Nota
Viene lasciata l'esecuzione di plt.show() invece del plt.saveFig() [riga commentata], per semplificare la visualizzazione tridimensionale e dinamica dei dati raccolti. Nella versione utilizzata in questo lavoro di tesi è stata eseguita la chiamata SaveFig() che salva il plot come un'immagine all'interno della cartella corretta in '/Registrazioni/Risultati'
# Come eseguire il progetto Unity
