//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    using static SymBits;

    partial struct asci
    {
        [MethodImpl(Inline)]
        public static void store(ReadOnlySpan<byte> src, char fill, Span<char> dst)
        {            
            var count = Root.length(src,dst);
            for(var i=0; i<count; i++)            
            {
                ref readonly var next = ref skip(src,i);                                    
                seek(dst,i) = next == 0 ? fill : @char(skip(src,i));
            }
        }

        [MethodImpl(Inline), Op]
        public static int store(in asci2 src, Span<char> dst)
        {
            var data = asci.cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            return 2;
        } 

        [MethodImpl(Inline), Op]
        public static int store(in asci4 src, Span<char> dst)
        {
            var data = asci.cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            return 4;
        } 

        [MethodImpl(Inline), Op]
        public static int store(in asci8 src, Span<char> dst)
        {
            var data = asci.cover(src);
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
        public static int store(in asci16 src, Span<char> dst)
            => decode(SymBits.vinflate(src.Storage), ref head(dst));

        [MethodImpl(Inline), Op]
        public static int store(in asci32 src, Span<char> dst)
        {
            ref var c = ref head(dst);
            var count = decode(SymBits.vinflate(vlo(src.Storage)), ref c);
            count += decode(SymBits.vinflate(vhi(src.Storage)), ref add(ref c, count));
            return count;
        }
    }
}