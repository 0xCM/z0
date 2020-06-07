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
        public static string format(asci2 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n2));
            decode(src,dst);
            return new string(dst);
        }       
                 
        [MethodImpl(Inline), Op]
        public static string format(in asci4 src)
            => new string(decode(src));
        
        [MethodImpl(Inline), Op]
        public static string format(asci5 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n5));
            decode(src,dst);
            return new string(dst);
        }

        [MethodImpl(Inline), Op]
        public static string format(asci8 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n8));
            decode(src,dst);
            return new string(dst);
        }        

        [MethodImpl(Inline), Op]
        public static string format(in asci16 src)
            => new string(decode(src));

        [MethodImpl(Inline), Op]
        public static string format(in asci32 src)
            => new string(decode(src));

        [MethodImpl(Inline), Op]
        public static string format(in asci64 src)
            => new string(decode(src));
    }
}