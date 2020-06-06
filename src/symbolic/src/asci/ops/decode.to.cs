//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
     
    using static Seed;
    using static Control;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode2 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            return 2;
        } 

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode4 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            return 4;
        } 

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode5 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
            return 5;
        } 

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode8 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
            seek(dst,5) = skip(data,5);
            seek(dst,6) = skip(data,6);
            seek(dst,7) = skip(data,7);
            return 8;
        } 

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode16 src, Span<char> dst)
        {
            var data = SymBits.vinflate(src.Storage);
            var bytes = bytespan(data);
            var chars = cast<char>(bytes);
            var count = 0;    
            for(var i=0; i<chars.Length; i++, count++)
            {
                ref readonly var c = ref skip(chars,i);
                if((AsciCharCode)c != AsciCharCode.Null)
                    seek(dst,i) = c;
                else
                    break;
            }
            return count;
        }
    }
}