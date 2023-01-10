#include <iostream>
#include<allegro.h>

BITMAP *buffer;
BITMAP *mouse;
BITMAP *menu;
BITMAP *menu1;
BITMAP *menu2;
BITMAP *menu3;
BITMAP *menu4;


using namespace std;

void menus()
{

    mouse = load_bitmap ("mouse.bmp",NULL);
    menu = load_bitmap ("menu.bmp",NULL);
    menu1 = load_bitmap ("menu1.bmp",NULL);
    menu2 = load_bitmap ("menu2.bmp",NULL);
    menu3 = load_bitmap ("menu3.bmp",NULL);
    menu4 = load_bitmap ("menu4.bmp",NULL);
//clear_to_color(buffer,0xffffff);
//draw_sprite(buffer, mouse, mouse_x, mouse_y);
blit(menu2, buffer,0,0,0,0,800,600);
if ((mouse_x <= 770 and mouse_x>=0) and (mouse_y <= 590 and mouse_y>=0)    )
{
    masked_blit(mouse,buffer,0,0,mouse_x,mouse_y,30,30);

}

if ((mouse_x <= 373 and mouse_x>=199) and (mouse_y <= 450 and mouse_y>=311)    )
{
    if (mouse_b &1 ){
        blit(menu3, buffer,0,0,0,0,800,600);

}

}
else if ((mouse_x <= 637 and mouse_x>=508) and (mouse_y <= 448 and mouse_y>=308)    )
{

if (mouse_b &1 ){
        blit(menu1, buffer,0,0,0,0,800,600);

}
}



blit(buffer, screen,0,0,0,0,800,600);
}


int main()
{
    allegro_init();
    install_keyboard();
    install_mouse();
    set_color_depth(32);
    set_gfx_mode(GFX_AUTODETECT_WINDOWED,800,600,0,0);
    buffer = create_bitmap(800,600);

    menus();



}

END_OF_MAIN()
