//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    partial class BitFields
    {
        [MethodImpl(Inline)]
        internal static T Mask<F,T>(BitField256<F,T> src, F index)
            where T : unmanaged
            where F : unmanaged, Enum
                => BitMask.lo<T>(src.Spec[index]);

        [MethodImpl(Inline)]
        public static T read<F,T>(in BitField256<F,T> src, F index)
            where T : unmanaged
            where F : unmanaged, Enum
                => gmath.and(vcell(src.State, Enums.numeric<F,byte>(index)), Mask(src,index));
    }
}