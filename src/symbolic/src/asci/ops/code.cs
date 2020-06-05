//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static AsciCharCode code(AsciCode2 src, byte index)
            => (AsciCharCode)(src.Data >> index);


        [MethodImpl(Inline), Op]
        public static AsciCharCode code(AsciCode4 src, byte index)
            => (AsciCharCode)(src.Data >> index);
    }
}