# -*- coding: utf-8 -*-
"""
Created on Tue Jan 10 18:55:49 2023

@author: Usuario
"""

from Coche import *
from Moto import *

a = Coche(1, "Volkswagen", "Jetta", 130, 250000, True)
a1 = Coche(2, "Kia", "Rio", 120, 200000, True)

b = Moto(3, "Harley Davidson", "Chopper", 110, 150000, True)
b1 = Moto(4, "Yamaha", "Carreras", 130, 200000, False)

print(a)
print("\n")
print(a1)
print("\n")
b.setPrecio(100000)
print(b)
print("\n")
print(b1)
