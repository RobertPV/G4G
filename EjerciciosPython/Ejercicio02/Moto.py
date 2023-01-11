# -*- coding: utf-8 -*-
"""
Created on Tue Jan 10 20:54:37 2023

@author: Usuario
"""

from Vehiculo import *

class Moto(Vehiculo):
    
    def __init__(self, ide, marca, modelo, km, precio, sidecar):
        super().__init__(ide, marca, modelo, km, precio)
        self.__sidecar = sidecar
    
    def getPrecio(self):
        if(self.__sidecar == True):
            return super().getPrecio() + 50
        else:
            return super().getPrecio()
    
    def __str__(self):
        if(self.__sidecar == True):
            return super().__str__() + "\nSi tiene Sidecar"
        else:
            return super().__str__() + "\nNo tiene Sidecar"