//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static JccTest;
    using static Hex4Kind;
    using static math;

    partial class AsmPatterns
    {
        [Op]
        public static byte jcc(byte x, byte y)
        {
            if(x == 0)
                goto x00;
            else if(x == 2 && y <= 7)
                goto x01;
            else if(x == 3 && y > 9)
                goto x02;
            else if(x == 4 && y > 0)
                goto x03;
            else if(x == 5 && y < 18)
                goto x04;
            else if(x == 6 && y < 0)
                goto x05;
            else
                goto xff;


            x00:
                return and(x,y);
            x01:
                return or(x,y);
            x02: 
                return xor(x,y);            
            x03: 
                return div(x,y);            
            x04: 
                return not(y);            
            x05: 
                return negate(x);            
            xff: 
                return mod(x,y);            
        }


        [Op]
        public static sbyte jcc(sbyte x, sbyte y)
        {
            if(x == 0)
                goto x00;
            else if(x == 2 && y <= 7)
                goto x01;
            else if(x == 3 && y > 9)
                goto x02;
            else if(x == 4 && y > 0)
                goto x03;
            else if(x == 5 && y < 18)
                goto x04;
            else if(x == 6 && y < 0)
                goto x05;
            else
                goto xff;


            x00:
                return and(x,y);
            x01:
                return or(x,y);
            x02: 
                return xor(x,y);            
            x03: 
                return div(x,y);            
            x04: 
                return not(y);            
            x05: 
                return negate(x);            
            xff: 
                return mod(x,y);
            
        }


        [Op]
        public static ulong jcc(ulong x, ulong y)
        {
            if(x == 0)
                goto x00;
            else if(x == 2 && y <= 7)
                goto x01;
            else if(x == 3 && y > 9)
                goto x02;
            else if(x == 4 && y > 0)
                goto x03;
            else if(x == 5 && y < 18)
                goto x04;
            else if(x == 6 && y < 0)
                goto x05;
            else
                goto xff;


            x00:
                return and(x,y);
            x01:
                return or(x,y);
            x02: 
                return xor(x,y);            
            x03: 
                return div(x,y);            
            x04: 
                return not(y);            
            x05: 
                return negate(x);            
            xff: 
                return mod(x,y);
            
        }

        [Op]
        public static JccTest jcc2(byte x, byte y)
        {
            JccTest result = 0;
            if(x >= y)
                result = target_GTEQ;
            else if(x <= y)
                result = target_LTEQ;
            else if(x != y)
                result = target_NEQ;

            return result;  
        }

        [Op]
        public static byte jcc_no_switch(byte x)
        {
            byte result = 0;
                if(x ==11)
                    result = 0b11100000;
                else if(x ==2)
                    result = 0b11100000 >> 1;
                else if(x == 13)
                    result = 0b11100000 >> 3;
                else if(x == 7)
                    result = 0b11100000 >> 4;
                else if(x == 9)
                    result = 0b11 << 1;
                else if(x == 6)
                    result = 0b11 << 2;
                else if(x == 21)
                    result = 0b11 << 3;
                else if(x == 111)
                    result = 0b11 << 4;
            return result;             
        }


        static JccTest target_GT
            =>  NLE;

        static JccTest target_LT
            =>  L;

        static JccTest target_EQ
            =>  E;            

        static JccTest target_GTEQ
            =>  NL;

        static JccTest target_LTEQ
            =>  LE;

        static JccTest target_NEQ
            =>  NE;            
    }
}