# MACHINE APP

**MachineApp** je desktop aplikacija razvijena u **.NET 8** tehnologiji koristeći **Windows Forms** i implementira **Model-View-Presenter (MVP)** architecture pattern. Aplikacija omogućava upravljanje mašinama i koristi **MySQL** bazu podataka.

---

## Tehnologije

- **.NET 8** – platforma za razvoj aplikacije
- **Windows Forms** – grafički korisnički interfejs (GUI)
- **MySQL** – lokalna baza podataka
- **BCrypt.Net-Next** – hešovanje lozinki
- **MSTest** i **Moq** – unit testovi i mockovanje zavisnosti

---

## MVP Arhitektura

Aplikacija koristi MVP pattern i ovo je osnovna struktura projekta:

- **Model**: Klase `Machine`, `User`, `MachineType` i repozitorijumi `MachineRepo`, `UserRepo`
- **View**: WinForms forme koje implementiraju interfejse `ILogin`, `IMachineList`, `IMachineForm`
- **Presenter**: Klase `LoginPresenter`, `MachinesListPresenter`, `MachineFormPresenter` upravljaju logikom aplikacije

---

## Funkcionalnosti

- Prijava korisnika i autorizacija (administrator / običan korisnik)  
- CRUD operacije nad mašinama  
- Praćenje proizvodnje i isporuke mašina (dodavanje, izmena, brisanje)
- Osnovna validacija i prikaz grešaka

---

## Preuzimanje

[Link za preuzimanje ZIP arhive sa aplikacijom i bazom](https://drive.google.com/file/d/1ghQxhfBj3RREXLCL-Jt5yAzhFXqG4t3G/view?usp=sharing)

Sadržaj ZIP fajla:

- `MachineApp.exe` – izvršni fajl
- `machine_app_database.sql` – SQL skripta za bazu
- `README.txt` – kratak vodič za instalaciju

---
