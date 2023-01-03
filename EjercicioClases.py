# -*- coding: utf-8 -*-
"""
Created on Mon Jan  2 20:04:22 2023

@author: Usuario
"""

class Vehiculo:
    def __init__(self, color, ruedas):
        self.color = color
        self.ruedas = ruedas
    def __str__(self):
        return "El color es: {} \nTiene: {} ruedas".format(self.color, self.ruedas)

class Coche(Vehiculo):
    def __init__(self, color, ruedas, velocidad, cilindrada):
        super().__init__(color, ruedas)
        self.velocidad = velocidad
        self.cilindrada = cilindrada
    def __str__(self):
        return super().__str__() + """\nSu velocidad es de: {} km/h 
Su cilindrada es de: {} cc""".format(self.velocidad, self.cilindrada)

class Bicicleta(Vehiculo):
    def __init__(self,color, ruedas, tipo):
        super().__init__(color, ruedas)
        self.tipo = tipo
    def __str__(self):
        return super().__str__() + """\nTipo: {}""".format(self.tipo)

class Camioneta(Coche):
    def __init__(self, color, ruedas, velocidad, cilindrada, carga):
        super().__init__(color, ruedas, velocidad, cilindrada)
        self.carga = carga
    def __str__(self):
        return super().__str__() + "Carga: {} kg".format(self.carga)
class Motocicleta(Bicicleta):
    def __init__(self, color, ruedas, tipo, velocidad, cilindrada):
        super().__init__(color, ruedas, tipo)
        self.velocidad = velocidad
        self.cilindrada = cilindrada
    def __str__(self):
        return super().__str__() + """\nSu velocidad es de: {} km/h
Su cilindrada es de {} cc""".format(self.velocidad, self.cilindrada)


a = Vehiculo("Rojo", 4)
b = Coche("Azul", 2, 110, 5000)
c = Bicicleta("Negro",2,"Urbana")
d = Camioneta("Gris", 4, 120, 6500, 500)
e = Motocicleta("Verde", 2, "Deportiva", 130, 5500)

print(a)
print("\n")
print(b)
print("\n")
print(c)
print("\n")
print(d)
print("\n")
print(e)
