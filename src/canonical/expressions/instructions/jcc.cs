//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Z0.Asm.Data;
    
    using static Seed;
    using static Asm.Data.JccTest;

    partial class AsmExpr
    {
        [Op]
        public static JccTest jcc1(byte x, byte y)
        {
            JccTest result = 0;
            if(x > y)
                result = target_GT;
            else if(x < y)
                result = target_LT;
            else if(x == y)
                result = target_EQ;

            return result;  
        }

        [Op]
        public static JccTest jcc1_1(byte x, byte y)
        {
            if(x > y)
                return target_GT;
            else if(x < y)
                return target_LT;
            else
                return target_EQ;
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

        [Op]
        public static byte jcc_switch(byte x)
        {
            byte result = 0;
            switch(x)
            {
                case 11:
                    result = 0b11100000;
                    break;
                case 2:
                    result = 0b11100000 >> 1;
                    break;
                case 13:
                    result = 0b11100000 >> 3;
                    break;
                case 7:
                    result = 0b11100000 >> 4;
                    break;
                case 9:
                    result = 0b11 << 1;
                    break;
                case 6:
                    result = 0b11 << 2;
                    break;
                case 21:
                    result = 0b11 << 3;
                    break;
                case 111:
                    result = 0b11 << 4;
                    break;
            }
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