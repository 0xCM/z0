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
        public static void chars(AsciCode2 src, Span<char> dst)
        {
            var data = codes(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
        } 

        [MethodImpl(Inline), Op]
        public static void chars(AsciCode4 src, Span<char> dst)
        {
            var data = codes(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
        } 

        [MethodImpl(Inline), Op]
        public static void chars(AsciCode8 src, Span<char> dst)
        {
            var data = codes(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
            seek(dst,5) = skip(data,5);
            seek(dst,6) = skip(data,6);
            seek(dst,7) = skip(data,7);
        } 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(AsciCode16 src)
            => cast<char>(bytespan(vinflate(src.Data)));    
    }
}