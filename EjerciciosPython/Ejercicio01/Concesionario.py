# -*- coding: utf-8 -*-
"""
Created on Thu Jan  5 21:14:40 2023

@author: Usuario
"""

class Concesionario:
    
    __listaCoches = []
    __limite = 0
    __contador = 0
    
    def __init__(self, limite):
        self.__limite = limite
    
    def añadirCoche(self, coche):
        if(coche == None):
            print("Debe ingresar un dato valido a la lista de coches")
        else:
            if(self.__contador < self.__limite):
                self.__listaCoches.append(coche)
                self.__contador += 1
            else:
                print("Se ha llenado completamente la lista")
    
    def mostrarCoches(self):
        if(len(self.__listaCoches) == 0 ):
            print("No hay coches en la lista")
        else:
            for i in self.__listaCoches:
                print(i)
            
    def vaciarCoches(self):
        if(len(self.__listaCoches) == 0):
            print("No hay nada que vaciar en la lista")
        else:
            self.__listaCoches.clear()
            self.__contador = 0
            print("Lista vacia")
    
    def eliminarCoche(self, coche):
        if coche in self.__listaCoches:
            self.__listaCoches.remove(coche)
            self.__contador -= 1
        else:
            print("El coche que desea eliminar no se encuentra en la lista")
                    
