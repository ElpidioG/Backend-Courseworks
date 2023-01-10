#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <windows.h>
//main function
int rango, r, s, x;
void gotoxy (int x,int y);
int main(void)
{
	system("color 0A");
    //variable
    
    do
    {
        gotoxy(19, 2);
        printf("Rango: ");
        scanf("%d", &rango);
        printf("\n");
        
    }

    while (rango < 1 );
    for (int r = 0; r < rango; r++)
    {	printf("\t\t");
        //Espacios antes del primer lado
        for (int s = rango - r; s > 1; s--)
        {
        	
            printf(" ");
            
            
           
        }
        //Primer lado de *
        for (int x = 0; x < r + 1; x++)
        {
            printf("*");

         
        }
        // 2do lado de *
        for (int x = 1; x < r + 1; x++)
        {
            printf("*");

         
        }

        printf("\n");
    }
  
getch();
}

void gotoxy (int x,int y)
{
	HANDLE hcon;
	hcon = GetStdHandle(STD_OUTPUT_HANDLE);
	COORD dwPos;
	dwPos.X= x;
	dwPos.Y= y;
	SetConsoleCursorPosition(hcon,dwPos);
	
	
}

