#include<stdio.h>
#include<conio.h>
#include<windows.h>
#include<time.h>

void ShowConsoleCursor(bool showFlag)
{
    HANDLE out = GetStdHandle(STD_OUTPUT_HANDLE);

    CONSOLE_CURSOR_INFO     cursorInfo;

    GetConsoleCursorInfo(out, &cursorInfo);
    cursorInfo.bVisible = showFlag; // visibilidad del cursor
    SetConsoleCursorInfo(out, &cursorInfo);
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
int a1=14,c1=5,a2=1,c2=1,b1= 20, k1= 7, b2= 1, k2 = 1;
int d1=6, e1=15, d2=1,e2=1, f1=26,g1=15,f2=1,g2=1;
int h1=15,u1=4,h2=1,u2=1,j1=22,l1=16,j2=1,l2=1;
int main()
{
	ShowConsoleCursor(false);
    
int i;
	int x,y;
	for (i=1;i<=60;i++) 	 	
	{
		if (i == 1)
		{
			gotoxy(1,1);printf("%c", 201);
		}
		
		gotoxy(i+1,1);printf("%c%c", 205, 205);
		if (i == 60)
		{
			gotoxy(62,1);printf("%c", 187);
		}
		x = i;
		gotoxy(x+1,30);printf("%c%c", 205, 205);
		
		if(i<=30 && i > 1)
		{
			y = i;
		gotoxy(1,y);printf("%c", 186);
		gotoxy(62,y);printf("%c", 186);
			
		}
		if ( y == 30)
		{
			gotoxy(1,y);printf("%c", 200);
			gotoxy(62,y);printf("%c\n", 188);
		}
		
		}
	while(1)
	{
	gotoxy(b1,k1); printf(" ");        //Primera bola
	b1= b1 + b2;
	k1= k1 + k2;
	gotoxy(b1,k1); printf("%c",134);
    Sleep(10);
    if(b1 == 2 || b1 == 59)  //Primera bola
    {
    	b2 = -1 * b2;
	}
	if(k1 == 2 || k1 == 29)
	{
		k2 = -1 * k2;	
	}
    
    gotoxy(a1,c1); printf(" ");         //Segunda bola
	a1= a1 + a2;
	c1= c1 + c2;
	gotoxy(a1,c1); printf("+");   
    Sleep(10);
    if(a1 == 2 || a1 == 59) //Segunda bola
    {
    	a2 = -1 * a2;
	}
	if(c1 == 2 || c1 == 29)
	{
		c2 = -1 * c2;
	}
    
    gotoxy(d1,e1); printf(" ");         //Tercera bola
	d1= d1 + d2;
	e1= e1 + e2;
	gotoxy(d1,e1); printf("8");
    Sleep(10);
    if(d1 == 2 || d1 == 59)  //Tercera bola
    {
    	d2 = -1 * d2;
	}
	if(e1 == 2 || e1 == 29)
	{
		e2 = -1 * e2;
	}
    
    gotoxy(f1,g1); printf(" ");        //Cuarta bola
	f1= f1 + f2;
	g1= g1 + g2;
	gotoxy(f1,g1); printf("~");
    Sleep(10);
    if(f1 == 2 || f1 == 59) //Cuarta bola
    {
    	f2 = -1 * f2;
	}
	if(g1 == 2 || g1 == 29)
	{
		g2 = -1 * g2;
	} 
    
    gotoxy(h1,u1); printf(" ");       //Quinta bola
	h1= h1 + h2;
	u1= u1 + u2;
	gotoxy(h1,u1); printf("%c",169);
    Sleep(10);
    if(h1 == 2 || h1 == 59)  //Quinta bola
    {
    	h2 = -1 * h2;
	}
	if(u1 == 2 || u1 == 29)
	{
		u2 = -1 * u2;
	}
    
    gotoxy(j1,l1); printf(" ");        //Sexta bola
	j1= j1 + j2;
	l1= l1 + l2;
	gotoxy(j1,l1); printf("%c",150);
    Sleep(10);
	if(j1 == 2 || j1 == 59)  //Sexta bola
    {
    	j2 = -1 * j2;
	}
	if(l1 == 2 || l1 == 29)
	{
		l2 = -1 * l2;
	}		}	
		
	getch();
}

