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
    using static SymBits;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode2 src, byte index)
            => (AsciCharCode)(src.Storage >> index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode4 src, byte index)
            => (AsciCharCode)(src.Storage >> index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode8 src, byte index)
            => (AsciCharCode)(src.Storage >> index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode16 src, byte index)
            => (AsciCharCode)src.Storage.GetElement(index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode16 src, N0 index)
            => (AsciCharCode)vextract(src.Storage,index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode16 src, N1 index)
            => (AsciCharCode)vextract(src.Storage,index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode16 src, N2 index)
            => (AsciCharCode)vextract(src.Storage,index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode16 src, N3 index)
            => (AsciCharCode)vextract(src.Storage,index);

    }
}