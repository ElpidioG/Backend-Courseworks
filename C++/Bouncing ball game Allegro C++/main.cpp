#include <iostream>
#include <allegro.h>
#include <stdlib.h>

using namespace std;

int x = 260;
int y = 300;
int a = 140;
int b = 100;
int rad = 7;
int a1 = 5;
int b1 = 5;
int vidas = 3;
int scores = 0;



void barra()
{

    // movimiento de la barra
    if (key[KEY_RIGHT] and x < 470)
    {
        x+=5;
    }
        if (key[KEY_LEFT] and x > 30)
    {
        x-=5;
    }

}

void bola()
{



// crear pelota

    a = a + a1;
    b = b + b1;



// mover pelota de izquierda a derecha
    if (a < 545)
    {
        a1= -1*a1;
    }
        if (a > 40)
    {
        a1= -1*a1;
    }
// mover pelota de arriba a abajo
    if (b < 370)
    {
        b1= -1*b1;
    }
        if (b > 40)
    {
        b1 = -1*b1;
    }


// Si la pelota topa el borde de abajo
      if (b >= 350)
    {
        vidas--;
        a = 70+rand()%(400);
        b = 40;

    }


//Si la pelota toca la barra
    if ( ((a <= x+90 and a >= x) and (b >= y and b <= y+3)) )
    {
        scores = scores+5;
        b1= -1*b1;

    }




}


int main()
{

    allegro_init();

    install_keyboard();
    set_color_depth(32);
BITMAP *buffer = create_bitmap(600,400);
    set_gfx_mode(GFX_AUTODETECT_WINDOWED,600,400,0,0);
    clear_to_color(buffer, 0xFFFFFF);
// pantalla



    while(!key[KEY_ESC] and vidas != 0)
    {
    bola();
    barra();

  blit (buffer,screen,0,0,0,0,700,700);
    clear_to_color(buffer,0xffffff);
      // borde
    circlefill(buffer, a, b, rad,0xff0000);
    rectfill(buffer, 30,30,570,20, 0xED4376);
    rectfill(buffer, 30,20,20,370, 0xED4376);
    rectfill(buffer, 570,360,30,370, 0xED4376);
    rectfill(buffer, 570,30,560,370, 0xED4376);

// barra
    rectfill(buffer, x,y,x+90,y+15, 0x05009E);


    //  imprimir puntuacion
textprintf_ex(screen, font,50,10, 0x00ff00, -1, "Scores: %d", scores);

    // imprimir vidas
textprintf_ex(screen, font,350,10, 0x00ff00, -1, "Vidas: %d", vidas);

    rest(2);

    }
        blit (buffer,screen,0,0,0,0,700,700);
    clear_to_color(buffer,0xffffff);
if (vidas == 0)
    {
        clear(buffer);
        textout_centre_ex(buffer, font, "GAMEOVER", 110, 130, 0x00ff00, 0xffffff);
    }
}


END_OF_MAIN()



