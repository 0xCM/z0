//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    static class MaskCases
    {
        public static T central<T>(N8 f, N2 d)
            where T : unmanaged
                => BitMasks.central<T>(f,d);

        public static T central<T>(N8 f, N4 d)
            where T : unmanaged
                => BitMasks.central<T>(f,d);

        public static T central<T>(N8 f, N6 d)
            where T : unmanaged
                => BitMasks.central<T>(f,d);

        [MethodImpl(Inline), NumericClosures(UnsignedInts), Naturals(4,6,8,10,12,14,16,18,32,64)]
        public static T lsb<N,T>(N w, N2 f, N1 d, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMasks.lsb<N,T>(w, f, d);
    }
}