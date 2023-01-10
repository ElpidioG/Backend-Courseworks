#include <iostream>
#include <allegro.h>
using namespace std;

int x = 270;
int y = 325;
int x1 = 100;
int y1 = 200;
int movprab = 1;
int movlao = 1;
int main()
{
    allegro_init();
    install_keyboard();
    set_color_depth(32);
    set_gfx_mode(GFX_AUTODETECT_WINDOWED,600,400,0,0);
    BITMAP *buffer = create_bitmap(600,400);
    clear_to_color(buffer, 0x000000);

    while(!key[KEY_ESC] )
    {
        //bordes
        rectfill(buffer,30,360,20,20,0x2DDBD8);
        rectfill(buffer,540,30,30,20,0x2DDBD8);
        rectfill(buffer,30,360,540,350,0x2DDBD8);
        rectfill(buffer,540,30,530,350,0x2DDBD8);
        //barra
        rectfill(buffer, x,y,x+80,y+10, 0xFE0000);
        //bola
        circlefill(buffer, x1,y1,5,0x0AF315);
        y1=y1+movprab;
        x1=x1+movlao;
        blit (buffer,screen,0,0,0,0,700,700);
         clear_to_color(buffer, 0x000000);

      if(y1 < 350 )
    {
    movprab= -1 * movprab;
    }
     if(y1 > 30 )
    {
    movprab= -1 * movprab;
    }
  if(x1 < 530 )
    {
    movlao= -1 * movlao;
    }
    if(x1 > 40 )
    {
    movlao= -1 * movlao;
    }

     if((x1>=x&&x1<=x+80)&&(y1>=y&&y1<=y+5) )
    {
    movprab= -1 * movprab;
    }
     if (y1>=340){
    {
    y1 = 40;
    x1 = 20 + rand()%(100);
    }

    if (key[KEY_RIGHT] and x < 450)
    {
        x+=50;
    }
        if (key[KEY_LEFT] and x > 35)
    {
        x-=50;
    }
    rest(100);
    }
       clear_to_color(buffer, 0x000000);
}
}    END_OF_MAIN()
