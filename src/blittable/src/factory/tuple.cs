//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    partial struct Blit
    {
        partial struct Factory
        {
            [MethodImpl(Inline)]
            public static tuple<T0> tuple<T0>(T0 a0 = default)
                where T0: unmanaged
                    => new tuple<T0>(a0);

            [MethodImpl(Inline)]
            public static tuple<T0,T1> tuple<T0,T1>(T0 a0 = default, T1 a1 = default)
                where T0: unmanaged
                where T1: unmanaged
                    => new tuple<T0,T1>(a0,a1);

            [MethodImpl(Inline)]
            public static tuple<T0,T1,T2> tuple<T0,T1,T2>(T0 a0 = default, T1 a1 = default, T2 a2 = default)
                where T0: unmanaged
                where T1: unmanaged
                where T2 : unmanaged
                    => new tuple<T0,T1,T2>(a0,a1,a2);

            [MethodImpl(Inline)]
            public static tuple<T0,T1,T2,T3> tuple<T0,T1,T2,T3>(T0 a0 = default, T1 a1 = default, T2 a2 = default, T3 a3 = default)
                where T0: unmanaged
                where T1: unmanaged
                where T2 : unmanaged
                where T3 : unmanaged
                    => new tuple<T0,T1,T2,T3>(a0,a1,a2,a3);
        }
    }
}
