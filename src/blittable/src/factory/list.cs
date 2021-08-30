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
            public static list1<T0> list<T0>(T0 a0 = default)
                where T0: unmanaged
                    => new list1<T0>(a0);

            [MethodImpl(Inline)]
            public static list2<T0,T1> list<T0,T1>(T0 a0 = default, T1 a1 = default)
                where T0: unmanaged
                where T1: unmanaged
                    => new list2<T0,T1>(a0,a1);

            [MethodImpl(Inline)]
            public static list3<T0,T1,T2> list<T0,T1,T2>(T0 a0 = default, T1 a1 = default, T2 a2 = default)
                where T0: unmanaged
                where T1: unmanaged
                where T2 : unmanaged
                    => new list3<T0,T1,T2>(a0,a1,a2);

            [MethodImpl(Inline)]
            public static list4<T0,T1,T2,T3> list<T0,T1,T2,T3>(T0 a0 = default, T1 a1 = default, T2 a2 = default, T3 a3 = default)
                where T0: unmanaged
                where T1: unmanaged
                where T2 : unmanaged
                where T3 : unmanaged
                    => new list4<T0,T1,T2,T3>(a0,a1,a2,a3);
        }
    }
}
