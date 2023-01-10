// Librerias
#include <stdio.h>		
#include <conio.h>	
#include <windows.h>

// Variables
double tabla;
double res;
int mult = 1;
int y, y1;

// Funciones
void gotoxy(int x, int y);
int main()

{	
// Diseño
	gotoxy(8, 4);
	printf ("************");
	gotoxy(8,19);
	printf("***************************************************************");
	y = 5;
	do
	{
		gotoxy(8, y);
		printf ("*");
		y++;
	}
	while (y < 19);
	
	gotoxy(59, 4);
	printf ("************");
	y = 5;
	do
	{
		gotoxy(70, y);
		printf ("*");
		y++;
	}
	while (y < 19);
	gotoxy(11, 7);
	printf ("---------------------------------------------------------");
	gotoxy(11, 18);
	printf ("---------------------------------------------------------");
	y = 8;
	do
	{
	gotoxy(10, y);
	printf("|");
	y++;
	}
	while (y < 18);
	
	y = 8;
	do
	{
	gotoxy(68, y);
	printf("|");
	y++;
	}
	while (y < 18);
	
	y = 12;
	do
	{
	gotoxy(17, y);
	printf("|");
	y++;
	}
	while (y < 18);
	
	y = 12;
	do
	{
	gotoxy(37, y);
	printf("|");
	y++;
	}
	while (y < 18);
	
		y = 12;
	do
	{
	gotoxy(40, y);
	printf("|");
	y++;
	}
	while (y < 18);
	
		y = 12;
	do
	{
	gotoxy(61, y);
	printf("|");
	y++;
	}
	while (y < 18);
	
	
	gotoxy(18,11);
	printf("-------------------------------------------");
	
	gotoxy(27, 10);
	printf("|                       |");
	
// Inicio	
	gotoxy(20, 4);
	printf("***************************************\n");
	gotoxy(20, 5);
	printf("******* Tabla de Multiplicacion *******\n");
	gotoxy(20, 6);
	printf("***************************************\n");
	gotoxy(17, 9);
	
// Solicitando datos	
	printf("Introduce el numero que se va a multiplicar: ");
	scanf("%d", &tabla);
	
	
// Asignando valores a Y para colocar resultados en cuadro	
	y = 12;
	y1 = y;

// Bucle para imprimir resultados de la tabla
	do
	{
	res = mult * tabla;
		if (mult < 7)
		{
			gotoxy(21, y);
			printf("%d x %i = %d\n",tabla, mult, res );
			mult++;
			y++;
		} 
			else if (mult > 6)
			{
				gotoxy(43, y1);
				printf("%d x %i = %d\n",tabla, mult, res );
				mult++;
				y1++;
			}		
	}	
	while (mult <= 12);
	getch();
}


// Función Gotoxy
void gotoxy (int x,int y)
{
	HANDLE hcon;
	hcon = GetStdHandle(STD_OUTPUT_HANDLE);
	COORD dwPos;
	dwPos.X= x;
	dwPos.Y= y;
	SetConsoleCursorPosition(hcon,dwPos);
	
	
}




