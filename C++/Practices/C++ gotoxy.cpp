#include <stdio.h>
#include <conio.h>
#include <windows.h>

char producto1 [20], proveedor [50], producto2 [20], proveedor1 [50], proveedor4 [50],
producto3 [20], proveedor2 [50], producto4 [20], proveedor3 [50], producto5 [20];
	
float  precio, precio1, precio2, precio3, precio4;

int cantidad, cantidad1, cantidad2, cantidad3, cantidad4, tramo, tramo2, tramo3, tramo4, tramo5;

void gotoxy (int x,int y);
int main ()
{
	printf("\t*************************\n");
	printf("\t* Registro de Productos *\n");
	printf("\t*************************\n\n");
	printf ("Introduzca el Nombre del 1er producto: ");
	scanf("%s" ,&producto1);
	printf ("Introduzca el Precio: $");
	scanf("%f" , &precio);
	printf ("Introduzca la cantidad total: ");
	scanf("%d" , &cantidad);
	printf ("Introduzca el Proveedor de este producto: ");
	scanf("%s" , &proveedor);
	printf("********** Ingrese el Tramo al que pertenece dicho Producto **********  \n");
	scanf("%d",&tramo);
	getch();
	
	printf ("\nIntroduzca el Nombre del 2do producto: ");
	scanf("%s" ,&producto2);
	printf ("Introduzca el Precio: $");
	scanf("%f" , &precio1);
	printf ("Introduzca la cantidad total: ");
	scanf("%d" , &cantidad1);
	printf ("Introduzca el Proveedor de este producto: ");
	scanf("%s" , &proveedor1);
		printf("********** Ingrese el Tramo al que pertenece dicho Producto **********  \n");
	scanf("%d",&tramo2);
	getch();
	
	printf ("\nIntroduzca el Nombre del 3er producto: ");
	scanf("%s",&producto3);
	printf ("Introduzca el Precio: $");
	scanf("%f" , &precio2);
	printf ("Introduzca la cantidad total: ");
	scanf("%d" , &cantidad2);
	printf ("Introduzca el Proveedor de este producto: ");
	scanf("%s" , &proveedor2);
	printf("********** Ingrese el Tramo al que pertenece dicho Producto **********  \n");
	scanf("%d",&tramo3);
	getch();
	
	printf ("\nIntroduzca el Nombre del 4to producto: ");
	scanf("%s" ,&producto4);
	printf ("Introduzca el Precio: $");
	scanf("%f" , &precio3);
	printf ("Introduzca la cantidad total: ");
	scanf("%d" , &cantidad3);
	printf ("Introduzca el Proveedor de este producto: ");
	scanf("%s" , &proveedor3);
	printf("********** Ingrese el Tramo al que pertenece dicho Producto **********  \n");
	scanf("%d",&tramo4);
	getch();
	
	printf ("\nIntroduzca el Nombre del 5to producto: ");
	scanf("%s" ,&producto5);
	printf ("Introduzca el Precio: $");
	scanf("%f" , &precio4);
	printf ("Introduzca la cantidad total: ");
	scanf("%d" , &cantidad4);
	printf ("Introduzca el Proveedor de este producto: ");
	scanf("%s" , &proveedor4);
		printf("********** Ingrese el Tramo al que pertenece dicho Producto **********  \n");
	scanf("%d",&tramo5);
	getch();
	
	gotoxy (20,41);
	printf ("Tramo %d", tramo);
	gotoxy (20,42);
	printf ("1er Producto \n");
	gotoxy (20,43);
	printf ("Nombre: %s \n",producto1);
	gotoxy (20,44);
	printf ("Precio: $%.2f \n",precio);
	gotoxy (20,45);
	printf ("Cantidad: %d \n",cantidad);
	gotoxy (20,46);
	printf ("Proveedor: %s \n",proveedor);
	
	gotoxy (30,49);
	printf ("Tramo %d", tramo2);
	gotoxy (30,50);
	printf ("2do Producto \n");
	gotoxy (30,51);
	printf ("Nombre: %s\n",producto2);
	gotoxy (30,52);
	printf ("Precio: $%.2f\n",precio1);
	gotoxy (30,53);
	printf ("Cantidad:  %d\n",cantidad1);
	gotoxy (30,54);
	printf ("Proveedor: %s \n",proveedor1);
	
	gotoxy (40,56);
	printf ("Tramo %d", tramo3);
	gotoxy (40,57);
	printf ("3er Producto \n");
	gotoxy (40,58);
	printf ("Nombre: %s\n",producto3);
	gotoxy (40,59);
	printf ("Precio: %.2f\n",precio2);
	gotoxy (40,60);
	printf ("Cantidad: %d\n",cantidad2);
	gotoxy (40,61);
	printf ("Proveedor: %s\n",proveedor2);
	
	gotoxy (50,63);
	printf ("Tramo %d", tramo4);
	gotoxy (50,64);
	printf ("4to Producto \n");
	gotoxy (50,65);
	printf ("Nombre: %s\n",producto4);
	gotoxy (50,66);
	printf ("Precio: $%.2f\n",precio3);
	gotoxy (50,67);
	printf ("Cantidad: %d\n",cantidad3);
	gotoxy (50,68);
	printf ("Proveedor: %s\n\n",proveedor3);
	
	if (tramo5 == 1)
	{
	gotoxy (40,42);
	printf ("5to Producto\n");
	gotoxy (40,43);	
	printf ("Nombre: %s\n",producto5);
	gotoxy (40,44);
	printf ("Precio: $%.2f\n",precio4);
	gotoxy (40,45);
	printf ("Cantidad: %d\n",cantidad4);
	gotoxy (40,46);
	printf ("Proveedor: %s\n",proveedor4);
	getch();
	}
	
	else if (tramo5 == 2)
	{
	gotoxy (50,50);
	printf ("5to Producto\n");
	gotoxy (50,51);	
	printf ("Nombre: %s\n",producto5);
	gotoxy (50,52);	
	printf ("Precio: $%.2f\n",precio4);
	gotoxy (50,53);	
	printf ("Cantidad: %d\n",cantidad4);
	gotoxy (50,54);	
	printf ("Proveedor: %s\n",proveedor4);
	getch();
	}
	
	else if (tramo5 == 3)
	{
	gotoxy (60,57);
	printf ("5to Producto\n");
	gotoxy (60,58);	
	printf ("Nombre: %s\n",producto5);
	gotoxy (60,59);	
	printf ("Precio: $%.2f\n",precio4);
	gotoxy (60,60);	
	printf ("Cantidad: %d\n",cantidad4);
	gotoxy (60,61);	
	printf ("Proveedor: %s\n",proveedor4);
	getch();
	}
	
	else if (tramo5 == 4)
	{
	gotoxy (70,64);
	printf ("5to Producto\n");
	gotoxy (70,65);	
	printf ("Nombre: %s\n",producto5);
	gotoxy (70,66);	
	printf ("Precio: $%.2f\n",precio4);
	gotoxy (70,67);	
	printf ("Cantidad: %d\n",cantidad4);
	gotoxy (70,68);	
	printf ("Proveedor: %s\n",proveedor4);
	getch();
	}
	else
	{	gotoxy (60,71);
		printf ("Tramo %d", tramo5);
		gotoxy (60,72);
		printf ("5to Producto\n");
		gotoxy (60,73);	
		printf ("Nombre: %s\n",producto5);
		gotoxy (60,74);	
		printf ("Precio: $%.2f\n",precio4);
		gotoxy (60,75);	
		printf ("Cantidad: %d\n",cantidad4);
		gotoxy (60,76);	
		printf ("Proveedor: %s\n",proveedor4);
		getch();
		
	}
		
}

void gotoxy (int x,int y){
	HANDLE hcon;
	hcon = GetStdHandle(STD_OUTPUT_HANDLE);
	COORD dwPos;
	dwPos.X= x;
	dwPos.Y= y;
	SetConsoleCursorPosition(hcon,dwPos);
	
	
	}

