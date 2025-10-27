# Laboratory 2 – Conversia numerelor în virgulă fixă între baze (2–16)

## Scopul laboratorului
Realizarea unui program de consolă C# capabil să convertească un număr în virgulă fixă (cu partea întreagă și fracțională) dintr-o bază b1 într-o bază b2, unde:
- 2 ≤ b1 ≤ 16
- 2 ≤ b2 ≤ 16

## Elemente teoretice
Un număr în virgulă fixă este de forma: X = [parte întreagă].[parte fracțională]

Conversia se face separat:

1️⃣ Din baza b1 în baza 10:
- Partea întreagă: N(int) = Σ(cᵢ × b1^i)
- Partea fracțională: N(frac) = Σ(cᵢ × b1^(-i))

2️⃣ Din baza 10 în baza b2:
- Partea întreagă → împărțiri repetate la b2
- Partea fracțională → înmulțiri repetate cu b2

Programul limitează partea fracțională la 12 cifre pentru precizie numerică.

## Funcționalități
- validează numere în baza b1
- suportă cifre 0..9 și A..F
- conversie corectă pentru partea întreagă și fracțională
- afișare rezultat în baza b2
- tratează și cazurile fără partea fracțională

## Exemplu de rulare
Introduceti numarul: A.F
Introduceti baza initiala b1 (2-16): 16
Introduceti baza finala b2 (2-16): 2
Rezultat: 1010.1111

Alt exemplu:
101.101₂ → 5.625₁₀ → 5.A₁₆

## Structura proiectului
Laboratory 2/
 ├── Program.cs
 ├── Laboratory 2.csproj
 └── Laboratory 2.sln

## Concluzii
Studentul înțelege:
- conversia numerelor în virgulă fixă între baze diferite
- utilizarea puterilor negative în fracții
- conversie b1 → baza 10 → b2

Realizat de: Ardelean Luca
Data: 27.10.2025
