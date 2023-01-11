# -*- coding: utf-8 -*-
"""
Created on Tue Jan 10 19:31:06 2023

@author: Usuario
"""
from Vehiculo import *

class Coche(Vehiculo):
    
    def __init__(self, ide, marca, modelo, km, precio, airbag):
        super().__init__(ide, marca,modelo,km,precio)
        self.__airbag = airbag
    
    def getPrecio(self):
        if(self.__airbag == True):
            return super().getPrecio() + 200
        else:
            return super().getPrecio()

    def __str__(self):
        if(self.__airbag == True):    
            return super().__str__() + "\nSi tiene bolsas de aire"
        else:
            return super().__str__() + "\nNo tiene bolsas de aire "