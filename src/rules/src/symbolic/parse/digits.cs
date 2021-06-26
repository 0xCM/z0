//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Chars;
    using static Root;
    using static core;

    using C = AsciCode;
    using SQ = SymbolicQuery;

    partial struct SymbolicParse
    {
        [Op]
        public static int EatWhitespace(ReadOnlySpan<AsciCode> src)
        {
            var count = src.Length;
            var i=0;
            while(i < count)
            {
                if(!SQ.whitespace(skip(src,i)))
                    return i;
                else
                    i++;
            }
            return NotFound;
        }

        [Op]
        public static uint digits(ReadOnlySpan<char> src, uint offset, Span<byte> dst)
        {
            var i=offset;
            var j=0u;
            var imax = src.Length - 1;
            while(i <= imax)
            {
                ref readonly var c = ref skip(src, i++);
                if(SymbolicQuery.space(c) && j==0)
                    continue;

                if(SymbolicQuery.digit(base10, c))
                    seek(dst, j++) = C.d9 - (C)c;
                else
                    break;
            }
            return j;
        }

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