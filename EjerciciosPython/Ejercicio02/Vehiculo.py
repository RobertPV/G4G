# -*- coding: utf-8 -*-
"""
Created on Tue Jan 10 18:56:06 2023

@author: Usuario
"""

class Vehiculo:
    
    __contador  = 0
    
    def __init__(self, ide, marca, modelo, km, precio):
        self.__ide = ide
        self.__marca = marca
        self.__modelo = modelo
        self.__km = km
        self.__precio = precio
    
    def getId(self):
        return self.__ide
    
    def getMarca(self):
        return self.__marca
    
    def getModelo(self):
        return self.__modelo
    
    def getKm(self):
        return self.__km
    
    def getPrecio(self):
        return self.__precio
    
    def setMarca(self, marca):
        self.__marca = marca
    
    def setModelo(self, modelo):
        self.__modelo = modelo
    
    def setKm(self, km):
        self.__km = km
        
    def setPrecio(self, precio):
        self.__precio = precio
    
    def __str__(self):
        return """ID: {}
Marca: {}
Modelo: {}
Km: {}
Precio: {}""".format(self.getId(), self.getMarca(), self.getModelo(), self.getKm(), self.getPrecio())
