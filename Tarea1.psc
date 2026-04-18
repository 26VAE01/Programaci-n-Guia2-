//Programa una calculadora trigonometrica
Algoritmo Tarea1
	Definir angulo , rad como Real
	Definir opcion Como Entero
	
	Escribir "*************************"
	Escribir "CACULADORA TRIGONOMETRICA"
	Escribir "*************************"
	Escribir "1. SENO"
	Escribir "2. COSENO"
	Escribir "3. TANGENTE"
	Escribir "Selecciona una opcion"
	Leer opcion
	
	Escribir"Ingrese el angulo en grados:"
	Leer angulo
	
	rad = angulo * PI/180
	
	Segun opcion Hacer
	1:
		Escribir "SENO",Sen(rad)
	2:
		Escribir "COSENO",Cos(rad)
	3:
		Escribir "TANGENTE",Tan(rad)
	De Otro Modo:
		Escribir "Opcion invalida"
Fin Segun
	
FinAlgoritmo
