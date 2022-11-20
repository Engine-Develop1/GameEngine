using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public enum ItemsEnum
    {
        none = 0x00,
        Righteous = 0xff,
        Steel = 0xfe, 
        Bronze = 0xfd,
        Diamond = 0xfc,
        iron = 0xfb,
        leather = 0xfa,
        stone = 0x01, //N
        flint = 0x02, //N
        ironore = 0x03, //N
        coal = 0x04, //N
        Wood = 0x05, //N
        Piece_of_wood = 0x06, //N
        tinore = 0x07, //N
        copperore = 0x08, //N
        torch = 0x85, //C WW
        stick = 0x86, //C WW
        iron_block, //C S
        ironIngot, //C S
        tinIngot, //C S
        copperIngot, //C S
        steel, //C AS
        bronze, //C AS
        bukkit, //C A
        lava_bukkit, //C find lava
        //main hand
        WoodenPickaxe = 0xb4,
        WoodenAxe = 0xb5,
        WoodenSword = 0xb6,
        StonePickaxe = 0xb7,
        StoneAxe = 0xb8,
        StoneSword = 0xb9,
        IronPickaxe =0xba,
        IronAxe = 0xbb,
        IronSword = 0xbc,
        steelPickaxe = 0xbd,
        axe_of_Justice = 0xbe,
        Sword_of_Justice = 0xbf,
        an_old_axe_form_Bolvar = 0xc0,
        //of hand
        basic_shield,
        average_shield,
        advanced_shield,
    }
    public enum Armor
    {
    }
}
