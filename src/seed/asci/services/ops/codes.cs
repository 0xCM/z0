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
    using static Typed;

    partial struct asci
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<AsciCharCode> codes<A>(in A src)
            where A : unmanaged, IAsciSequence
                => codes(n2, src);
        
        [MethodImpl(Inline)]
        static ReadOnlySpan<AsciCharCode> codes<A>(N2 n, in A src)
            where A : unmanaged, IAsciSequence
        {
            if(typeof(A) == typeof(asci2))
                return Root.cast<AsciCharCode>(cast(n2,src).Encoded);
            else if(typeof(A) == typeof(asci4))
                return Root.cast<AsciCharCode>(cast(n4,src).Encoded);
            else if(typeof(A) == typeof(asci8))
                return Root.cast<AsciCharCode>(cast(n8,src).Encoded);
            else if(typeof(A) == typeof(asci16))
                return Root.cast<AsciCharCode>(cast(n16,src).Encoded);
            else                
                return codes(n32, src);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<AsciCharCode> codes<A>(N32 n, in A src)
            where A : unmanaged, IAsciSequence
        {
            if(typeof(A) == typeof(asci32))
                return Root.cast<AsciCharCode>(cast(n32,src).Encoded);
            else if(typeof(A) == typeof(asci64))
                return Root.cast<AsciCharCode>(cast(n64,src).Encoded);
            else
                return ReadOnlySpan<AsciCharCode>.Empty;
        }
         
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(in asci16 src)
            => Root.cast<AsciCharCode>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(sbyte offset, sbyte count)        
            => AsciDataStrings.Service.codes(offset, (sbyte)(count));

        [MethodImpl(Inline), Op]
        public static void codes(in char src, int count, ref AsciCharCode dst)
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = (AsciCharCode)skip(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void codes(ReadOnlySpan<char> src, Span<AsciCharCode> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            codes(in head(src), count, ref head(dst));
        }   
    }
}