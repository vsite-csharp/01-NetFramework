Hello World
===========

Jednostavni primjer za pregled Visual Studio Solutiona, strukture kazala.
Pregled koda u IL Disassembleru, da se vidi �to je sve u modulu.


CIL kod
=======

Dvije aplikacije s identi�nim kodom napisanim u 2 razli�ita programska jezika
daju prakti�ki identi�an IL kod (porvjeriti).
Uo�iti razliku izme�u IL instrukcije add generirane u C# programu i instrukcije 
add.ovf generirane u VB.NET programu.


JIT prevoditelj i pozivi metoda
===============================

Pokazuje kako prvi poziv metode traje puno dulje jer JIT mora prvo prevesti
tu metodu u strojni kod. Sljede�i pozivi iste metode su puno kra�i.


ClsCompliant
============
Primjer zna�enja CLS compliant atributa

Sastoji se od dva modula:

1. ClsCompliant1 jest EXE pisan u VB.NET-u koji koristi modul ClsCompliant2

2. ClsCompliant2 jest DLL pisan u C# koji u sebi sadr�i klasu TimeProvider sa
   stati�kim metodama:
   - Getdatetime(string ime)
   - GetDateTime()
   - GetDatetime()

   Druga i tre�a verzija metoda ne zadovoljavaju CLS, jer se nazivi razlikuju 
   samo po velikim/malim slovima.

