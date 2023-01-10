#include <iostream>
#include<allegro.h>

BITMAP *buffer;
BITMAP *bloque;
BITMAP *bloque2;
int x = 100;
int y = 400;
using namespace std;

int main()
{
    allegro_init();
    install_keyboard();
    set_color_depth(32);
    set_gfx_mode(GFX_AUTODETECT_WINDOWED,800,600,0,0);
    buffer = create_bitmap(800,600);
clear_to_color(buffer,0xffffff);

    bloque= load_bitmap("bloque.bmp",NULL);
    bloque2= load_bitmap("cuadro2.bmp",NULL);


    blit(buffer, screen, 0,0,0,0,800,600);
    blit(bloque,screen,0,0,x,y,70,70);
     blit(bloque2,screen,0,0,x+100,y+100,30,30);


    readkey();
}
END_OF_MAIN()
