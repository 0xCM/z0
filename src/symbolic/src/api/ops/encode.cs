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
        public static ref readonly AsciCode2 encode(ReadOnlySpan<char> src, out AsciCode2 dst)        
            => ref AC2.encode(src, out dst);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 encode(ReadOnlySpan<char> src, out AsciCode4 dst)        
            => ref AC4.encode(src, out dst);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode5 encode(ReadOnlySpan<char> src, out AsciCode5 dst)        
            => ref AC5.encode(src, out dst);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode8 encode(ReadOnlySpan<char> src, out AsciCode8 dst)        
            => ref AC8.encode(src, out dst);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode16 encode(ReadOnlySpan<char> src, out AsciCode16 dst)        
            => ref AC16.encode(src, out dst);

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode32 encode(ReadOnlySpan<char> src, out AsciCode32 dst)        
            => ref AC32.encode(src, out dst);            

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