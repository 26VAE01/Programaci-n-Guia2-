Algoritmo Tarea4
	Definir opcion Como Entero
    Definir valor Como Real
    
    Escribir "CONVERSOR DE LONGITUD"
    Escribir "1. Metros a otras unidades"
    Escribir "2. Pies a otras unidades"
    Escribir "3. Centimetros a otras unidades"
    Escribir "4. Pulgadas a otras unidades"
    Escribir "Seleccione una opcion:"
    Leer opcion
    
    Escribir "Ingrese el valor:"
    Leer valor
    
    Segun opcion Hacer
        1: // Metros
            Escribir "En pies: ", valor * 3.28084
            Escribir "En centimetros: ", valor * 100
            Escribir "En pulgadas: ", valor * 39.37
            
        2: // Pies
            Escribir "En metros: ", valor * 0.3048
            Escribir "En centimetros: ", valor * 30.48
            Escribir "En pulgadas: ", valor * 12
            
        3: // Centimetros
            Escribir "En metros: ", valor / 100
            Escribir "En pies: ", valor * 0.0328084
            Escribir "En pulgadas: ", valor * 0.3937
            
        4: // Pulgadas
            Escribir "En metros: ", valor * 0.0254
            Escribir "En pies: ", valor / 12
            Escribir "En centimetros: ", valor * 2.54
            
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
FinProceso
