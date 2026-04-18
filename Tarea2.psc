Algoritmo Tarea2
	Definir opcion Como Entero
    Definir c Como Caracter
    
    Escribir "CLASIFICADOR DE CARACTER"
    Escribir "1. Verificar si es vocal"
    Escribir "2. Verificar si es digito"
    Escribir "3. Verificar ambos"
    Escribir "Seleccione una opcion:"
    Leer opcion
    
    Escribir "Ingrese un caracter:"
    Leer c
    
    Segun opcion Hacer
        1:
            Si c = "a" O c = "e" O c = "i" O c = "o" O c = "u" Entonces
                Escribir "Es una vocal"
            Sino
                Escribir "No es vocal"
            FinSi
            
        2:
            Si c >= "0" Y c <= "9" Entonces
                Escribir "Es un digito"
            Sino
                Escribir "No es un digito"
            FinSi
            
        3:
            Si c = "a" O c = "e" O c = "i" O c = "o" O c = "u" Entonces
                Escribir "Es una vocal"
            Sino
                Si c >= "0" Y c <= "9" Entonces
                    Escribir "Es un digito"
                Sino
                    Escribir "No es vocal ni digito"
                FinSi
            FinSi
            
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
FinProceso

