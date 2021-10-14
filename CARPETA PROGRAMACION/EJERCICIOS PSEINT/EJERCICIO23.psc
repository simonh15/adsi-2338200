Proceso Ejercicio23
	//Pedir tres números y mostrarlos ordenados de mayor a menor.
	Definir num1 Como Real;
	Definir num2 Como Real;
	Definir num3 como real;
	
	//Entrada
	Escribir "Escriba un numero";
	Leer num1;
	Escribir "Escriba otro número";
	Leer num2;
	Escribir "Escriba otro numero";
	Leer num3;
	
	//Salida
	si ( num1== num2 ) y ( num2 == num3 ) Entonces
		Escribir ' los numeros son igules ';
	SiNo
		Si num1>num2 y num2>num3 Entonces
			Escribir "El orden de mayor a menor es " , num1 , " - " , num2 , " - " , num3;
		sino
			Si num2>num1 y num1>num3 Entonces
				Escribir "El orden de mayor a menor es " , num2 , " - " , num1 , " - " , num3;
			SiNo
				Si num3>num1 y num1>num2 Entonces
					Escribir "El orden de mayor a menor es " , num3 , " - " , num1 , " - " , num2;
				SiNo
					Si num1>num3 y num3>num2 Entonces
						Escribir "El orden de mayor a menor es " , num1 , " - " , num3 , " - " , num2;
					SiNo
						Si num1>num3 y num3>num2 Entonces
							Escribir "El orden de mayor a menor es " , num1 , " - " , num3 , " - " , num2;
						SiNo
							si num2>num3 y num3>num1 Entonces
								Escribir "El orden de mayor a menor es " , num2 , " - " , num3 , " - " , num1;
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
	
	
	
	
	
	
	
FinProceso