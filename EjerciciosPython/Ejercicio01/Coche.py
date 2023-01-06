# -*- coding: utf-8 -*-
"""
Created on Thu Jan  5 20:46:52 2023

@author: Usuario
"""

class Coche:
    
    def __init__(self, ide, marca,modelo,km,precio):
        self.__ide = ide
        self.__marca = marca
        self.__modelo = modelo
        self.__km = km
        self.__precio = precio
    
    def __str__(self):
        return """ID: {}
Marca: {}
Modelo: {}
Km: {} km
Precio: ${}""".format(self.__ide,self.__marca,self.__modelo,self.__km,self.__precio)
    
    def setId(self, ide):
        self.__ide = ide
    
    def setMarca(self, marca):
        self.__marca = marca
        
    def setModelo(self, modelo):
        self.__modelo = modelo
    
    def setKm(self, km):
        self.__km = km
        
    def setPrecio(self, precio):
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
    