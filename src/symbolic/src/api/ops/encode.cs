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

    partial class Symbolic     
    {
        [MethodImpl(Inline), Op]
        public static asci16 encode(ReadOnlySpan<char> src, ASCI asci, N16 n)        
            => AsciCodes.encode(n, src);            

        [MethodImpl(Inline), Op]
        public static asci32 encode(ReadOnlySpan<char> src, ASCI asci, N32 n)        
            => AsciCodes.encode(n,src);            

        [MethodImpl(Inline), Op]
        public static asci64 encode(ReadOnlySpan<char> src, ASCI asci, N64 n)        
            => AsciCodes.encode(n,src);            

        [MethodImpl(Inline), Op]
        public static ref readonly asci16 encode(ReadOnlySpan<char> src, out asci16 dst)        
            => ref AsciCodes.encode(src, out dst);

        /// <summary>
        /// Fills a caller-supplied target span with asci codes corresponding to characters in a source span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, Span<AsciCharCode> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = (AsciCharCode)skip(src,i);
            return count;
        }

        /// <summary>
        /// Encodes a specified number of source characters
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="dst">The data target</param>
        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, int offset, int count, Span<AsciCharCode> dst)
        {
            ref readonly var input = ref skip(src, offset);
            ref var target = ref head(dst);
            for(var i=0; i<count; i++)
                seek(ref target, i) = (AsciCharCode)skip(input,i);
            return count;
        }
    }
}