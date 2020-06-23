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

    partial struct asci
    {         
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

        /// <summary>
        /// Projects a bytespan into a codespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The hexcode target</param>
        [MethodImpl(Inline), Op]
        public static int codes(ReadOnlySpan<byte> src, UpperCased @case, Span<HexCode> dst)
        {            
            var j = 0;
            var casing = UpperCased.Case;
            for(int i = 0; i<src.Length; i++, j+=2)
            {
                ref readonly var data = ref skip(src, i);                
                seek(dst, j) = code(casing, (HexDigit)(data >> 4));
                seek(dst, j + 1) = code(casing, (HexDigit)(0xF & data));
            }
            return j;
        }

        /// <summary>
        /// Projects a bytespan into a codespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The hexcode target</param>
        [MethodImpl(Inline), Op]
        public static int codes(ReadOnlySpan<byte> src, Span<HexCode> dst)
        {            
            var j = 0;
            var casing = LowerCased.Case;
            for(int i = 0; i<src.Length; i++, j+=2)
            {
                ref readonly var data = ref skip(src, i);                
                seek(dst, j) = code(casing, (HexDigit)(data >> 4));
                seek(dst, j + 1) = code(casing, (HexDigit)(0xF & data));
            }
            return j;
        }         
    }
}