//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Typed;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static string format(in asci2 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n2));
            AsciCodes.decode(src,dst);
            return new string(dst);
        }       

        [MethodImpl(Inline), Op]
        public static string format(in asci4 src)
            => new string(AsciCodes.decode(src));

        [MethodImpl(Inline), Op]
        public static string format(in asci5 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n5));
            AsciCodes.decode(src,dst);
            return new string(dst);
        }

        [MethodImpl(Inline), Op]
        public static string format(in asci8 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n8));
            AsciCodes.decode(src,dst);
            return new string(dst);
        }        

        [MethodImpl(Inline), Op]
        public static string format(in asci16 src)
            => new string(AsciCodes.decode(src));

        [MethodImpl(Inline), Op]
        public static string format(in asci32 src)
            => new string(AsciCodes.decode(src));

        [MethodImpl(Inline), Op]
        public static string format(in asci64 src)
            => new string(AsciCodes.decode(src));
    }
}