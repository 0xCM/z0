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

    partial class Symbolic
    {
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
                seek(dst, j) = hexcode(casing, (byte)(data >> 4));
                seek(dst, j + 1) = hexcode(casing, (byte)(0xF & data));
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
                seek(dst, j) = hexcode(casing, (byte)(data >> 4));
                seek(dst, j + 1) = hexcode(casing, (byte)(0xF & data));
            }
            return j;
        }
    }
}