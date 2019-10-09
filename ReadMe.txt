Hello World
===========

Jednostavni primjer za pregled Visual Studio Solutiona, strukture kazala.
Pregled koda u IL Disassembleru, da se vidi što je sve u modulu.


CIL kod
=======

Dvije aplikacije s identiènim kodom napisanim u 2 razlièita programska jezika
daju praktièki identièan IL kod (porvjeriti).
Uoèiti razliku izmeðu IL instrukcije add generirane u C# programu i instrukcije 
add.ovf generirane u VB.NET programu.


JIT prevoditelj i pozivi metoda
===============================

Pokazuje kako prvi poziv metode traje puno dulje jer JIT mora prvo prevesti
tu metodu u strojni kod. Sljedeæi pozivi iste metode su puno kraæi.


ClsCompliant
============
Primjer znaèenja CLS compliant atributa

Sastoji se od dva modula:

1. ClsCompliant1 jest EXE pisan u VB.NET-u koji koristi modul ClsCompliant2

2. ClsCompliant2 jest DLL pisan u C# koji u sebi sadrži klasu TimeProvider sa
   statièkim metodama:
   - Getdatetime(string ime)
   - GetDateTime()
   - GetDatetime()

   Druga i treæa verzija metoda ne zadovoljavaju CLS, jer se nazivi razlikuju 
   samo po velikim/malim slovima.

