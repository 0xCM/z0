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

    partial class Symbolic     
    {
        [MethodImpl(Inline), Op]
        public static AsciCode4 encode(ReadOnlySpan<char> src, ASCI asci, N4 n)        
            => AsciCodes.encode(src,n);            

        [MethodImpl(Inline), Op]
        public static AsciCode8 encode(ReadOnlySpan<char> src, ASCI asci, N8 n)        
            => AsciCodes.encode(src,n);            

        [MethodImpl(Inline), Op]
        public static AsciCode16 encode(ReadOnlySpan<char> src, ASCI asci, N16 n)        
            => AsciCodes.encode(src, n);            

        [MethodImpl(Inline), Op]
        public static AsciCode32 encode(ReadOnlySpan<char> src, ASCI asci, N32 n)        
            => AsciCodes.encode(src, n);            

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode16 encode(ReadOnlySpan<char> src, out AsciCode16 dst)        
            => ref AsciCodes.encode(src, out dst);

        /// <summary>
        /// Encodes a specified number of source characters
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline), Op]
        public static void encode(ReadOnlySpan<char> src, int offset, int count, Span<AsciCharCode> dst)
        {
            ref readonly var input = ref skip(src, offset);
            ref var target = ref head(dst);
            for(var i=0; i<count; i++)
                seek(ref target, i) = (AsciCharCode)skip(input,i);
        }
    }
}