# -*- coding: utf-8 -*-
"""
Created on Thu Jan  5 20:46:20 2023

@author: Usuario
"""
from Coche import *
from Concesionario import *

coche1 = Coche(1, "KIA", "Rio", 100, 270000)
coche2 = Coche(2, "Volkswagen", "Jetta", 120, 370000)
coche3 = Coche(3, "Volkswagen", "Vento", 100, 170000)

concesionario = Concesionario(3)

concesionario.añadirCoche(coche1)
concesionario.añadirCoche(coche2)
concesionario.añadirCoche(coche3)

concesionario.mostrarCoches()

