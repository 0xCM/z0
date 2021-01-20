//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Digital
    {
        /// <summary>
        /// Returns the upper-case hex code for a specified digit
        /// </summary>
        /// <param name="case">The case selector</param>
        /// <param name="index">The digit value</param>
        /// <remarks>movzx eax,dl -> movsxd rax,eax -> mov rdx,28b57e0aca9h -> movzx eax,byte ptr [rax+rdx] </remarks>
        [MethodImpl(Inline), Op]
        public static HexCode code(UpperCased @case, HexDigit digit)
            => (HexCode)skip(HexSymData.UpperCodes, (byte)digit);

        /// <summary>
        /// Returns the lower-case hex code for a specified digit
        /// </summary>
        /// <param name="case">The case selector</param>
        /// <param name="index">The digit value</param>
        /// <remarks>movzx eax,dl -> movsxd rax,eax -> mov rdx,28b57e0aed9h -> movzx eax,byte ptr [rax+rdx]</remarks>
        [MethodImpl(Inline), Op]
        public static HexCode code(LowerCased @case, HexDigit digit)
            => (HexCode)skip(HexSymData.LowerCodes, (byte)digit);

        /// <summary>
        /// Projects a bytespan into a codespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The hexcode target</param>
        [MethodImpl(Inline), Op]
        public static int codes(ReadOnlySpan<byte> src, UpperCased @case, Span<HexCode> dst)
        {
            var j=0u;
            var casing = UpperCased.Case;
            for(var i=0u; i<src.Length; i++, j+=2)
            {
                ref readonly var data = ref skip(src, i);
                seek(dst, j) = Asci.code(casing, (HexDigit)(data >> 4));
                seek(dst, j + 1) = Asci.code(casing, (HexDigit)(0xF & data));
            }
            return (int)j;
        }

        /// <summary>
        /// Projects a bytespan into a codespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The hexcode target</param>
        [MethodImpl(Inline), Op]
        public static int codes(ReadOnlySpan<byte> src, Span<HexCode> dst)
        {
            var j=0u;
            var casing = LowerCased.Case;
            for(var i=0u; i<src.Length; i++, j+=2)
            {
                ref readonly var data = ref skip(src, i);
                seek(dst, j) = Asci.code(casing, (HexDigit)(data >> 4));
                seek(dst, j + 1) = Asci.code(casing, (HexDigit)(0xF & data));
            }
            return (int)j;
        }
    }
}