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
    using static Typed;

    partial class Symbolic
    {        
        static AsciDataStrings AsciStrings => default;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciCharCode> codes(ASCI asci)
            => cast<AsciCharCode>(AsciStrings.bytes(n0));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciCharCode> codes(ASCI asci, int i0, int i1)
            => cast<AsciCharCode>(Symbolic.segment(AsciStrings.bytes(n0),i0,i1));

        /// <summary>
        /// Loads 32 asci codes beginning at a specified index
        /// </summary>
        /// <param name="index">The index of the first code</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcodes(ASCI asci, int index)
        {
            ref readonly var src = ref head(AsciStrings.bytes(n0));         
            return SymBits.vload(w256,src);
        }

        [MethodImpl(Inline), Op]
        public static void codes(ReadOnlySpan<char> src, Span<AsciCodeCover> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
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