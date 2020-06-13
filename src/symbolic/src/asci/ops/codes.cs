//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Konst;
    using static Control;

    partial class AsciCodes
    {
        static AsciDataStrings AsciStrings => default;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(in asci16 src)
            => cast<AsciCharCode>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes()
            => cast<AsciCharCode>(AsciStrings.CharBytes);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(sbyte offset, sbyte count)        
            => AsciStrings.codes(offset, count);

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