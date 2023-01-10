#include<stdio.h>
#include<conio.h>
#include<windows.h>

void gotoxy(int x, int y);
int main()
{
	int i;
	int x,y;
	for (i=1;i<=30;i++) 	 	
	{
		if (i == 1)
		{
			gotoxy(1,1);printf("%c", 201);
		}
		
		gotoxy(i+1,1);printf("%c%c", 205, 205);
		if (i == 30)
		{
			gotoxy(32,1);printf("%c", 187);
		}
		x = i;
		gotoxy(x+1,15);printf("%c%c", 205, 205);
		
		if(i<=15 && i > 1)
		{
			y = i;
		gotoxy(1,y);printf("%c", 186);
		gotoxy(32,y);printf("%c", 186);
			
		}
		if ( y == 15)
		{
			gotoxy(1,y);printf("%c", 200);
			gotoxy(32,y);printf("%c\n", 188);
		}
		
		}

	
	getch();
	
	
}
void gotoxy(int x, int y)
{
 HANDLE hcon;
 hcon = GetStdHandle(STD_OUTPUT_HANDLE);
 COORD dwPos;
 dwPos.X = x;
 dwPos.Y = y;
 SetConsoleCursorPosition(hcon,dwPos);
}


