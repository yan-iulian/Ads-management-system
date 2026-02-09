# Ads Management System

## Descriere
Acest proiect este o aplicație desktop de tip **Windows Forms**, dezvoltată în **C# (.NET)**, destinată gestionării unei agenții de publicitate. Aplicația permite administrarea clienților, a campaniilor publicitare aferente, a produselor și a cheltuielilor, oferind o soluție centralizată pentru monitorizarea activității și a performanței financiare.

Aplicația utilizează o bază de date **Oracle** pentru stocarea și manipularea datelor.

## Cum se rulează proiectul

1.  Se clonează acest repository sau se descarcă fișierele.
2.  Se deschide fișierul `AdsManagementSystem.sln` în Visual Studio.
3.  Sau se rulează direct (fără compilare) :
    * Se navighează în folderul: `Ads management system/bin/Debug/`
    * Se deschide fișierul `AdsManagementSystem.exe`
4.  Se introduce username-ul și parola din tabelul de credențiale de mai jos.

## Credențiale Utilizatori

Mai jos este lista utilizatorilor predefiniți pentru accesul în aplicație:

| ID | Username | Parola | Rol | Nume Complet |
| :--- | :--- | :--- | :--- | :--- |
| 1 | catanaiulian23 | parola | Administrator | Catana Iulian Florin |
| 2 | maria.popescu | maria2024 | Operator | Popescu Maria |
| 3 | george.stan | stan4321 | Contabil | Stan George |
| 4 | andrei.dumitru | andrei2025 | Operator | Dumitru Andrei |
| 5 | ana.ionescu | ana_pass | Operator | Ionescu Ana |
| 6 | bogdan.vasile | bvasile!23 | Contabil | Vasile Bogdan |
| 7 | raluca.sandu | rsandu2023 | Operator | Sandu Raluca |
| 8 | daniel.neagu | neagu321 | Administrator | Neagu Daniel |
| 9 | laura.petre | laura_pw | Operator | Petre Laura |
| 10 | mihai.ilie | ilie2022 | Operator | Ilie Mihai |

## Funcționalități Principale

### 1. Autentificare și Gestionare Utilizatori
- **Login Securizat**: Acces pe bază de utilizator și parolă.
- **Roluri**: Funcționalități diferențiate (ex: Administrator, Operator, Contabil).
- **Sesiune**: Memorarea utilizatorului conectat și afișarea datelor acestuia pe pagina principală.

### 2. Gestiunea Clienților
- **Listare Clienți**: Vizualizarea tuturor clienților într-un tabel, cu posibilitate de căutare după nume.
- **Adăugare Client**: Formular pentru introducerea de noi clienți (Persoană Fizică / Firmă).
- **Detalii Client**: Pagină dedicată pentru fiecare client (`PaginaPersonalaForm`) care afișează datele de contact și statusul campaniei.
- **Ștergere Client**: Posibilitatea de a șterge un client din baza de date.

### 3. Gestiunea Campaniilor
- **Status Campanie**: Verificare automată dacă un client are o campanie activă.
- **Detalii Campanie**: Afișarea informațiilor precum Nume Campanie, Perioada (Data Start - Data Sfârșit), Buget Total.
- **Profitabilitate**: Calcul automat al profitului (Buget - Total Cheltuieli).
- **Facturare**: Generarea automată a unei facturi în format `.txt` pe Desktop, incluzând produsele campaniei și calculul TVA.

### 4. Gestiunea Produselor
- **Catalog Produse**: Vizualizarea tuturor produselor disponibile (`ToateProduseleForm`) cu opțiuni de adăugare și ștergere.
- **Produse per Campanie**: Vizualizarea produselor asociate specific unei campanii și calculul valorii totale a acestora.

### 5. Gestiunea Financiară (Cheltuieli)
- **Urmărire Cheltuieli**: Listarea cheltuielilor asociate unei campanii.
- **Totaluri**: Calculul automat al totalului cheltuielilor pentru monitorizarea bugetului.

## Tehnologii Utilizate
- **Limbaj**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Bază de Date**: Oracle Database (via `Oracle.ManagedDataAccess`)
- **IDE**: Visual Studio


