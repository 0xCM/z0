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

    using H = HexCharData;
    using C = AsciCharCode;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static C code(in asci2 src, Hex1Seq index)
            => (C)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static C code(in asci4 src, Hex2Seq index)
            => (C)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static C code(in asci8 src, Hex3Seq index)
            => (C)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static C code(in asci16 src, Hex4Seq index)
            => (C)skip(bytes(src), (byte)index);

        [MethodImpl(Inline), Op]
        public static C code(in asci32 src, Hex5Seq index)
            => (C)skip(bytes(src), (byte)index);

        [MethodImpl(Inline), Op]
        public static C code(in asci64 src, Hex6Seq index)
            => (C)skip(bytes(src), (byte)index);

        [MethodImpl(Inline), Op]
        public static C code(in asci16 src, N4 index)
            => code<N4>(src, index);

        [MethodImpl(Inline)]
        public static C code<N>(in asci16 src, N index = default)
            where N : unmanaged, ITypeNat
                => (C)vextract(src.Storage, index);

        /// <summary>
        /// Returns the upper-case hex code for a specified digit
        /// </summary>
        /// <param name="case">The case selector</param>
        /// <param name="index">The digit value</param>
        /// <remarks>movzx eax,dl -> movsxd rax,eax -> mov rdx,28b57e0aca9h -> movzx eax,byte ptr [rax+rdx] </remarks>
        [MethodImpl(Inline), Op]
        public static HexCode code(UpperCased @case, HexDigit digit)
            => (HexCode)skip(H.UpperCodes, (byte)digit);

        /// <summary>
        /// Returns the lower-case hex code for a specified digit
        /// </summary>
        /// <param name="case">The case selector</param>
        /// <param name="index">The digit value</param>
        /// <remarks>movzx eax,dl -> movsxd rax,eax -> mov rdx,28b57e0aed9h -> movzx eax,byte ptr [rax+rdx]</remarks>
        [MethodImpl(Inline), Op]
        public static HexCode code(LowerCased @case, HexDigit digit)
            => (HexCode)skip(H.LowerCodes, (byte)digit);
    }
}