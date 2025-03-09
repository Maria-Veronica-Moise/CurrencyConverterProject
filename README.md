# Considerente Generale #

### Diagrama Logica ###

<img width="960" alt="cc diagrama" src="https://github.com/user-attachments/assets/21a33b71-5b36-43df-9b3a-2a9418ab599d" />


### Design Mock-up ###

![cc mockup](https://github.com/user-attachments/assets/285f9395-e19f-4903-b079-6a3f9ed0d6a3)


### Stack de tehnologii ###
- Versiune .NET: 8.0
- Limbaje de programare: C#
- Interfata grafica: Windows Forms

### Structura Aplicatiei ###
Solutia este formata din 2 proiecte:
- `CurrencyConverterBackend` => Proiect tip librarie de clase. Contine clasa `Currency` si `CurrencyRepository`, care impreuna gestioneaza datele si stocarea lor.
- `CurrencyConverterItSchoolProject` => Proiect de tip Windows Forms Application. Contine diverse `Forms` si `UserControls` construite in jurul claselor de backend si gestioneaza rularea aplicatiei.

### Limitari ###
Lista valutară este fixă hard codată iar lista ultimelor conversii este un mecanism temporar care se actualizează după apăsarea butonului CONVERT. 
Aplicatia nu dispune de mecanism de import / export de date.


![Schermafbeelding 2025-03-09 213302](https://github.com/user-attachments/assets/71f0a419-58dd-4ed7-a943-088a71fa39b9)
![Schermafbeelding 2025-03-09 213106](https://github.com/user-attachments/assets/fdc4d0e1-9a5c-4559-991b-f48a371bf8cf)


# Prezentarea Aplicatiei Grafice #

### Fereastra Principala ###
Ii permite utilizatorului sa:
- vizualizeze toate valutele existente, sub forma de lista abreviata in combobox.
- adauge suma care vrea sa o schimbe.
- vizualizeze care este valoarea schimbului valutar.
- aleaga prin intermediul unor butoane conversiile populare.
- vizualizeze care sunt ultimele schimburi valutare.
![Schermafbeelding 2025-03-09 203635](https://github.com/user-attachments/assets/01081b70-1572-4cb1-bcfc-f31b92b074fa)
![Schermafbeelding 2025-03-09 215409](https://github.com/user-attachments/assets/19b18259-fa53-41d0-b4e5-7577c665c101)


