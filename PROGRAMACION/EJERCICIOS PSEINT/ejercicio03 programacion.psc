Proceso ejercicio03

	//Hacer un algoritmo que declare una variable para guardar el promedio del semestre, otra para guardar
	//el nombre de un estudiante y otra para guardar el número de notas perdidas.
	
	
	//definir // declarar 
	definir not_1 Como Real;
	definir not_2 Como Real;
	definir not_3 Como Real;
	definir promedio_semestre como real ;
	definir nombre_estudiante como cadena ;
	definir notas_perdidas Como Entero;
	 
	//operaciones de entrada 
	escribir " escribir nota 1 : " ; 
	leer not_1 ;
	escribir " escribir nota 2 : ";
	leer not_2 ;
	escribir "escribir nota 3 ";
	leer not_3 ;
	escribir " nombre del estudiante: ";
	leer nombre_estudiante ;
	escribir " numero de notas perdidas: " ;
	leer notas_perdidas ; 
	
	// procesos 
	
	promedio_semestre = (not_1 + not_2 + not_3) / 3;
	
	// operaciones de salida 
	escribir " el promedio del semestre es :" , promedio_semestre , " nombre del estudiante : " , nombre_estudiante , " numero de notas perdidas : " , notas_perdidas ;
	
FinProceso
