//Programa que pide dos numeros y una Opcion 
//Realizar una operacion segun la opcion elegida
Algoritmo Ejercicio3
	Escribir "***********************"
	Escribir "CALCULADORA BASICA"
	Escribir "***********************"
	
	//Variables 
	Definir numero1, numero2, resultado Como Real
	Definir opcion Como Entero
	
	Escribir "Ingrse el primer numero"
	Leer num1
	
	Escribir " Ingrese el segundo numero"
	Leer num2
	
	Escribir "Seleccione una opcion"
	Escribir "1. Sumar"
	Escribir "2. Restar"
	Escribir "3. Multiplicar"
	Escribir "4. Dividir"
	Leer opcion
	
	Segun opcion Hacer
		1:
			Escribir num1 + num2  
			Escribir "Resultado:"
		2:
			Escribir num1 - num2
			Escribir "Resultado:"
		3:
			Escribir num1 * num2 
			Escribir "Resultado:"
		4:
			Escribir num1 / num2 
			Escribir "Resultado:"
		De Otro Modo:
			Escribir "OPCIONES VALIDAS"
	Fin Segun
FinAlgoritmo
