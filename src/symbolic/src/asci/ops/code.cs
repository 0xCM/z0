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

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static AsciCharCode code(AsciCode2 src, byte index)
            => (AsciCharCode)(src.Data >> index);


        [MethodImpl(Inline), Op]
        public static AsciCharCode code(AsciCode4 src, byte index)
            => (AsciCharCode)(src.Data >> index);


        [MethodImpl(Inline), Op]
        public static AsciCharCode code(in AsciCode8 src, byte index)
            => (AsciCharCode)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static char decode(in AsciCode8 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static AsciCharCode code(AsciCode16 src, byte index)
            => (AsciCharCode)src.Data.GetElement(index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(in AsciCode16 src)
            => cast<AsciCharCode>(bytespan(src)); 

    }
}