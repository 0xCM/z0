//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Chars;

    partial struct TextRules
    {
        partial struct Parse
        {
            [Op]
            public static bool digit(char src, out byte dst)
            {
                switch(src)
                {
                    case D0:
                        dst = 0;
                        return true;
                    case D1:
                        dst = 1;
                        return true;
                    case D2:
                        dst = 2;
                        return true;
                    case D3:
                        dst = 3;
                        return true;
                    case D4:
                        dst = 4;
                        return true;
                    case D5:
                        dst = 5;
                        return true;
                    case D6:
                        dst = 6;
                        return true;
                    case D7:
                        dst = 7;
                        return true;
                    case D8:
                        dst = 8;
                        return true;
                    case D9:
                        dst = 9;
                        return true;
                }
                dst = byte.MaxValue;
                return false;
            }
        }
    }
}