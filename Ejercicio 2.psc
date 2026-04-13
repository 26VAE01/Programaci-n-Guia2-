//Inglesar un aletra: A ? Exelente, B ? Bueno, C ? Regular,
//D ? Deficiente, F ? Reprovado
Algoritmo Ejercicio3
	Definir letra Como Caracter
	Escribir "CLASIFICACION DE LETRAS POR RANGO"
	EScribir Sin Saltar "Digite una letra:"
	Leer letra
	
	Segun letra Hacer
		"A" O "a":
			Escribir "EXELENTE"
		"B" O "b":
			Escribir "BUENO"
		"C" O "c":
			Escribir"REGULAR"
		"D" O "d":
			Escribir "DEFICIENTE"
		"F" O "f":
			Escribir "REPROVADO"
	De Otro Modo:
			Escribir "Digite una una letra valida entre A,B,C,D y F"
	Fin Segun
	
FinAlgoritmo
