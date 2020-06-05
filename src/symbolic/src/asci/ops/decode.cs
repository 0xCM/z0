//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;
    using static Control;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static void decode(AsciCode2 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
        } 

        [MethodImpl(Inline), Op]
        public static int decode(AsciCode4 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            return 4;
        } 

        [MethodImpl(Inline), Op]
        public static char decode(AsciCode2 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char decode(AsciCode4 src, byte index)
            => (char)code(src,index);
    }
}