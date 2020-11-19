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

    partial class BitFields
    {
        [MethodImpl(Inline)]
        internal static T Mask<I,T>(BitField256<I,T> src, I index)
            where T : unmanaged
            where I : unmanaged
                => BitMasks.lo<T>(src.Spec[index]);

        [MethodImpl(Inline)]
        public static T read<I,T>(in BitField256<I,T> src, I index)
            where T : unmanaged
            where I : unmanaged
                => gmath.and(vcell(src.State, z.@as<I,byte>(index)), Mask(src,index));
    }
}