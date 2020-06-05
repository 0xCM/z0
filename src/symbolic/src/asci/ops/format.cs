//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;
    using static Typed;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static string format(AsciCode2 src)
        {

            Span<char> dst = stackalloc char[2];
            decode(src,dst);
            return new string(dst);
        }       
                 
        // [MethodImpl(Inline), Op]
        // public static string format(AsciCode4 src)
        // {
        //     Span<char> dst = stackalloc char[4];
        //     decode(src,dst);
        //     return new string(dst);
        // }

        [MethodImpl(Inline), Op]
        public static string format(AsciCode4 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n4));
            decode(src,dst);
            return new string(dst);
        }
    }
}