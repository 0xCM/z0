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
    using static SymBits;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci2 src, Hex1 index)
            => (AsciCharCode)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci4 src, Hex2 index)
            => (AsciCharCode)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci8 src, Hex3 index)
            => (AsciCharCode)(src.Storage >> (byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci16 src, Hex4 index)
            => (AsciCharCode)src.Storage.GetElement((byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci32 src, Hex5 index)
            => (AsciCharCode)src.Storage.GetElement((byte)index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci64 src, Hex6 index)
        {
            if((byte)index  <= 31)
                return code(src.Lo,(Hex5)index);
            else
                return code(src.Hi, ((Hex5)(byte)(index - 32)));
        }

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in asci16 src, N4 index)
            => code<N4>(src, index);

        [MethodImpl(Inline)]
        public static AsciCharCode code<N>(in asci16 src, N index = default)
            where N : unmanaged, ITypeNat                
                => (AsciCharCode)vextract(src.Storage, index);
    }
}