Algoritmo Tarea3
	Definir sector, cantidad Como Entero
    Definir precio, total Como Real
    
    Escribir "Seleccione sector:"
    Escribir "1. Palco (Q300)"
    Escribir "2. Tribuna (Q100 - Q125)"
    Escribir "3. Preferencia (Q50 - Q75)"
    Escribir "4. Generales (Q30 - Q50)"
    Leer sector
    
    Escribir "Ingrese cantidad de entradas:"
    Leer cantidad
    
    Segun sector Hacer
        1:
            precio <- 300
        2:
            precio <- 100   // puedes ajustar si quieres rango
        3:
            precio <- 50
        4:
            precio <- 30
        De Otro Modo:
            Escribir "Sector invalido"
  FinSegun

total <- precio * cantidad

Escribir "Total a pagar: Q", total
FinProceso

