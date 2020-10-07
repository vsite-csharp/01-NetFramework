Hello World
===========
Jednostavni primjer za pregled Visual Studio Solutiona, strukture kazala.
Pregled koda u IL Disassembleru, da se vidi što je sve u modulu.


CIL kod
=======
Dvije aplikacije s identičnim kodom napisanim u 2 različita programska jezika
daju praktički identičan IL kod (porvjeriti).
Uočiti razliku izmeðu IL instrukcije add generirane u C# programu i instrukcije 
add.ovf generirane u VB.NET programu.


JIT prevoditelj i pozivi metoda
===============================
Pokazuje kako prvi poziv metode traje puno dulje jer JIT mora prvo prevesti
tu metodu u strojni kod. Sljedeći pozivi iste metode traju puno kraće.


ClsCompliant
============
Primjer značenja CLS compliant atributa

Sastoji se od dva modula:

1. ClsCompliant1 jest EXE pisan u VB.NET-u koji koristi modul ClsCompliant2

2. ClsCompliant2 jest DLL pisan u C# koji u sebi sadrži klasu TimeProvider sa
   statičkim metodama:
   - Getdatetime(string ime)
   - GetDateTime()
   - GetDatetime()

   Druga i treća verzija metoda ne zadovoljavaju CLS, jer se nazivi razlikuju 
   samo po velikim/malim slovima.

