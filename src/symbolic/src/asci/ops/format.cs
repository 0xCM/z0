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

            var dst = CharBlocks.c16s(CharBlocks.alloc(n2));
            decode(src,dst);
            return new string(dst);
        }       
                 

        [MethodImpl(Inline), Op]
        public static string format(AsciCode4 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n4));
            decode(src,dst);
            return new string(dst);
        }
        
        [MethodImpl(Inline), Op]
        public static string format(AsciCode5 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n5));
            decode(src,dst);
            return new string(dst);
        }

        [MethodImpl(Inline), Op]
        public static string format(AsciCode8 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n8));
            decode(src,dst);
            return new string(dst);
        }        

        [MethodImpl(Inline), Op]
        public static string format(in AsciCode16 src)
            => new string(AsciCodes.decode(src));

        [MethodImpl(Inline), Op]
        public static string format(AsciCode32 src)
            => new string(decode(src));
    }
}