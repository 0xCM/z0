//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;
    using static SymBits;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci2 src, HexKind1 index)
            => (AsciCharCode)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci4 src, HexKind2 index)
            => (AsciCharCode)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci8 src, HexKind3 index)
            => (AsciCharCode)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci16 src, HexKind4 index)
            => (AsciCharCode)skip(bytes(src), (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci32 src, HexKind5 index)
            => (AsciCharCode)skip(bytes(src), (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci64 src, HexKind6 index)
            => (AsciCharCode)skip(bytes(src), (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci16 src, N4 index)
            => code<N4>(src, index);

        [MethodImpl(Inline)]
        public static AsciCharCode code<N>(in asci16 src, N index = default)
            where N : unmanaged, ITypeNat                
                => (AsciCharCode)vextract(src.Storage, index);

        /// <summary>
        /// Returns the upper-case hex code for a specified digit
        /// </summary>
        /// <param name="case">The case selector</param>
        /// <param name="index">The digit value</param>
        /// <remarks>movzx eax,dl -> movsxd rax,eax -> mov rdx,28b57e0aca9h -> movzx eax,byte ptr [rax+rdx] </remarks>
        [MethodImpl(Inline), Op]
        public static HexCode code(UpperCased @case, HexDigit digit)
            => (HexCode)skip(SymbolKonst.UpperHexCodes, (byte)digit);

        /// <summary>
        /// Returns the lower-case hex code for a specified digit
        /// </summary>
        /// <param name="case">The case selector</param>
        /// <param name="index">The digit value</param>
        /// <remarks>movzx eax,dl -> movsxd rax,eax -> mov rdx,28b57e0aed9h -> movzx eax,byte ptr [rax+rdx]</remarks>
        [MethodImpl(Inline), Op]
        public static HexCode code(LowerCased @case, HexDigit digit)
            => (HexCode)skip(SymbolKonst.LowerHexCodes, (byte)digit);
    }
}