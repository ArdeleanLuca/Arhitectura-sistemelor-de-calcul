# Laboratory 1 – Conversia numerelor între baze

## 🎯 Scopul laboratorului
Scopul acestui laborator este de a realiza un program care convertește un număr întreg dintr-o bază de numerație în altă bază (între 2 și 16), utilizând funcțiile disponibile în .NET pentru conversie.

---

## 🧠 Elemente teoretice

### ✅ Conversie prin bază intermediară 10
1️⃣ Convertim numărul din baza inițială în baza 10  
2️⃣ Convertim din baza 10 în baza finală

Formula:
N = Σ (cᵢ × bⁱ)

---

### ✅ Conversii rapide din baza 2 în 8 și 16
✔ Grupăm câte **3 biți** → baza 8  
✔ Grupăm câte **4 biți** → baza 16  

Exemple:
101011₂ → (101)(011) → 53₈  
1110 1101₂ → ED₁₆

---

## 💻 Implementare în C#
Programul:
- citește de la tastatură numărul de convertit
- citește baza inițială și baza finală (2–16)
- afișează rezultatul în baza dorită

---

## 📝 Exemplu de rulare

Introduceti numarul: 123  
Introduceti baza initiala (2-16): 10  
Introduceti baza finala (2-16): 2  

Numarul 123 din baza 10 este 1111011 in baza 2 ✅  

---

## 📂 Structura proiectului

Laboratory 1/  
 ├── Laboratory 1.sln  
 └── Laboratory1/  
      ├── Program.cs  
      ├── Laboratory1.csproj  
      └── ...  

---

## ✅ Concluzii
Studentul poate:
- converti numere între baze diferite (2 ⇄ 8 ⇄ 10 ⇄ 16)
- utiliza funcțiile `Convert.ToInt32()` și `Convert.ToString()` din .NET
- înțelege conversiile rapide la baze de puteri ale lui 2
