//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class Utf8AsciPoints
    {
        [MethodImpl(Inline)]
        static Utf8AsciPoint utf8(char c)
            => new Utf8AsciPoint((byte)c);

        public static Utf8AsciPoint d0 => utf8('0');

        public static Utf8AsciPoint d1 => utf8('1');
        
        public static Utf8AsciPoint d2 => utf8('2');
        
        public static Utf8AsciPoint d3 => utf8('3');
        
        public static Utf8AsciPoint d4 => utf8('4');
        
        public static Utf8AsciPoint d5 => utf8('5');
        
        public static Utf8AsciPoint d6 => utf8('6');
        
        public static Utf8AsciPoint d7 => utf8('7');
        
        public static Utf8AsciPoint d8 => utf8('8');
        
        public static Utf8AsciPoint d9 => utf8('9');
        
        public static Utf8AsciPoint a => utf8('a');
        
        public static Utf8AsciPoint b => utf8('b');
        
        public static Utf8AsciPoint c => utf8('c');
        
        public static Utf8AsciPoint d => utf8('d');
        
        public static Utf8AsciPoint e => utf8('e');
        
        public static Utf8AsciPoint f => utf8('f');
        
        public static Utf8AsciPoint g => utf8('g');
        
        public static Utf8AsciPoint h => utf8('h');
        
        public static Utf8AsciPoint i => utf8('i');
        
        public static Utf8AsciPoint j => utf8('j');
        
        public static Utf8AsciPoint k => utf8('k');
        
        public static Utf8AsciPoint l => utf8('l');
        
        public static Utf8AsciPoint m => utf8('m');
        
        public static Utf8AsciPoint n => utf8('n');
        
        public static Utf8AsciPoint o => utf8('o');
        
        public static Utf8AsciPoint p => utf8('p');
        
        public static Utf8AsciPoint q => utf8('q');
        
        public static Utf8AsciPoint r => utf8('r');
        
        public static Utf8AsciPoint s => utf8('s');
        
        public static Utf8AsciPoint t => utf8('t');
        
        public static Utf8AsciPoint u => utf8('u');
        
        public static Utf8AsciPoint v => utf8('v');
        
        public static Utf8AsciPoint w => utf8('w');
        
        public static Utf8AsciPoint x => utf8('x');
        
        public static Utf8AsciPoint y => utf8('y');
        
        public static Utf8AsciPoint z => utf8('z');

        public static Utf8AsciPoint A => utf8('A');
        
        public static Utf8AsciPoint B => utf8('B');
        
        public static Utf8AsciPoint C => utf8('C');
        
        public static Utf8AsciPoint D => utf8('D');
        
        public static Utf8AsciPoint E => utf8('E');
        
        public static Utf8AsciPoint F => utf8('F');
        
        public static Utf8AsciPoint G => utf8('G');
        
        public static Utf8AsciPoint H => utf8('H');
        
        public static Utf8AsciPoint I => utf8('I');
        
        public static Utf8AsciPoint J => utf8('J');

        public static Utf8AsciPoint K => utf8('K');

        public static Utf8AsciPoint L => utf8('L');
        
        public static Utf8AsciPoint M => utf8('M');
        
        public static Utf8AsciPoint N => utf8('N');
        
        public static Utf8AsciPoint O => utf8('O');
        
        public static Utf8AsciPoint P => utf8('P');
        
        public static Utf8AsciPoint Q => utf8('Q');
        
        public static Utf8AsciPoint R => utf8('R');
        
        public static Utf8AsciPoint S => utf8('S');
        
        public static Utf8AsciPoint T => utf8('T');
        
        public static Utf8AsciPoint U => utf8('U');
        
        public static Utf8AsciPoint V => utf8('V');

        public static Utf8AsciPoint W => utf8('W');

        public static Utf8AsciPoint X => utf8('X');

        public static Utf8AsciPoint Y => utf8('Y');

        public static Utf8AsciPoint Z => utf8('Z');   

        public static Utf8AsciPoint Space => utf8(' ');   
         
    }

        /*
        0x00 00000000 ___
        0x01 00000001 ___
        0x02 00000010 ___
        0x03 00000011 ___
        0x04 00000100 ___
        0x05 00000101 ___
        0x06 00000110 ___
        0x07 00000111 ___
        0x08 00001000 ___
        0x09 00001001 ___
        0x0a 00001010 ___
        0x0b 00001011 ___
        0x0c 00001100 ___
        0x0d 00001101 ___
        0x0e 00001110 ___
        0x0f 00001111 ___
        0x10 00010000 ___
        0x11 00010001 ___
        0x12 00010010 ___
        0x13 00010011 ___
        0x14 00010100 ___
        0x15 00010101 ___
        0x16 00010110 ___
        0x17 00010111 ___
        0x18 00011000 ___
        0x19 00011001 ___
        0x1a 00011010 ___
        0x1b 00011011 ___
        0x1c 00011100 ___
        0x1d 00011101 ___
        0x1e 00011110 ___
        0x1f 00011111 ___
        0x20 00100000 ' '
        0x21 00100001 '!'
        0x22 00100010 '"'
        0x23 00100011 '#'
        0x24 00100100 '$'
        0x25 00100101 '%'
        0x26 00100110 '&'
        0x27 00100111 '''
        0x28 00101000 '('
        0x29 00101001 ')'
        0x2a 00101010 '*'
        0x2b 00101011 '+'
        0x2c 00101100 ','
        0x2d 00101101 '-'
        0x2e 00101110 '.'
        0x2f 00101111 '/'
        0x30 00110000 '0'
        0x31 00110001 '1'
        0x32 00110010 '2'
        0x33 00110011 '3'
        0x34 00110100 '4'
        0x35 00110101 '5'
        0x36 00110110 '6'
        0x37 00110111 '7'
        0x38 00111000 '8'
        0x39 00111001 '9'
        0x3a 00111010 ':'
        0x3b 00111011 ';'
        0x3c 00111100 '<'
        0x3d 00111101 '='
        0x3e 00111110 '>'
        0x3f 00111111 '?'
        0x40 01000000 '@'
        0x41 01000001 'A'
        0x42 01000010 'B'
        0x43 01000011 'C'
        0x44 01000100 'D'
        0x45 01000101 'E'
        0x46 01000110 'F'
        0x47 01000111 'G'
        0x48 01001000 'H'
        0x49 01001001 'I'
        0x4a 01001010 'J'
        0x4b 01001011 'K'
        0x4c 01001100 'L'
        0x4d 01001101 'M'
        0x4e 01001110 'N'
        0x4f 01001111 'O'
        0x50 01010000 'P'
        0x51 01010001 'Q'
        0x52 01010010 'R'
        0x53 01010011 'S'
        0x54 01010100 'T'
        0x55 01010101 'U'
        0x56 01010110 'V'
        0x57 01010111 'W'
        0x58 01011000 'X'
        0x59 01011001 'Y'
        0x5a 01011010 'Z'
        0x5b 01011011 '['
        0x5c 01011100 '\'
        0x5d 01011101 ']'
        0x5e 01011110 '^'
        0x5f 01011111 '_'
        0x60 01100000 '`'
        0x61 01100001 'a'
        0x62 01100010 'b'
        0x63 01100011 'c'
        0x64 01100100 'd'
        0x65 01100101 'e'
        0x66 01100110 'f'
        0x67 01100111 'g'
        0x68 01101000 'h'
        0x69 01101001 'i'
        0x6a 01101010 'j'
        0x6b 01101011 'k'
        0x6c 01101100 'l'
        0x6d 01101101 'm'
        0x6e 01101110 'n'
        0x6f 01101111 'o'
        0x70 01110000 'p'
        0x71 01110001 'q'
        0x72 01110010 'r'
        0x73 01110011 's'
        0x74 01110100 't'
        0x75 01110101 'u'
        0x76 01110110 'v'
        0x77 01110111 'w'
        0x78 01111000 'x'
        0x79 01111001 'y'
        0x7a 01111010 'z'
        0x7b 01111011 '{'
        0x7c 01111100 '|'
        0x7d 01111101 '}'
        0x7e 01111110 '~'
        0x7f 01111111 ___
        */

}