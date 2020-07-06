//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asci
    {    
        [MethodImpl(Inline), Op]
        public static void chars(Base10 @base, ushort src, out char c1, out char c0)
        {
            c1 = (char)symval(digit(@base, src, Bit1));
            c0 = (char)symval(digit(@base, src, Bit0));
        } 

        [MethodImpl(Inline), Op]
        public static void chars(Base10 @base, uint src, out char c3, out char c2, out char c1, out char c0)
        {
            c3 = (char)symval(digit(@base, src, Bit3));
            c2 = (char)symval(digit(@base, src, Bit2));
            c1 = (char)symval(digit(@base, src, Bit1));
            c0 = (char)symval(digit(@base, src, Bit0));
        }

        [MethodImpl(Inline), Op]
        public static void chars(Base10 @base, ulong src, out char c7, out char c6, out char c5, out char c4, out char c3, out char c2, out char c1, out char c0)
        {
            c7 = (char)symval(digit(@base, src, Bit7));
            c6 = (char)symval(digit(@base, src, Bit6));
            c5 = (char)symval(digit(@base, src, Bit5));
            c4 = (char)symval(digit(@base, src, Bit4));
            c3 = (char)symval(digit(@base, src, Bit3));
            c2 = (char)symval(digit(@base, src, Bit2));
            c1 = (char)symval(digit(@base, src, Bit1));
            c0 = (char)symval(digit(@base, src, Bit0));
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Base10 @base, uint src)
        {            
            var store = z64;
            var proxy = z16c;
            ref var dst = ref As.@as(ref store, ref proxy);            
            chars(@base, src, 
                out As.add(dst, 3), 
                out As.add(dst, 2), 
                out As.add(dst, 1), 
                out As.add(dst, 0)
                );
            return As.cover(dst, 4);            
        }


        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Base10 @base, ulong src)
        {            
            var store = z128f;
            var proxy = z16c;
            ref var dst = ref As.@as(ref store, ref proxy);            
            chars(@base, src, 
                out As.add(dst, 7), 
                out As.add(dst, 6), 
                out As.add(dst, 5), 
                out As.add(dst, 4),
                out As.add(dst, 3), 
                out As.add(dst, 2), 
                out As.add(dst, 1), 
                out As.add(dst, 0)
                );
            return As.cover(dst, 4);            
        }
    }
}