//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    partial struct BitFlow
    {
        [MethodImpl(Inline)]
        public static tuple<T0,T1,T2> t3<T0,T1,T2>(T0 a0 = default, T1 a1 = default, T2 a2 = default)
            where T0: unmanaged
            where T1: unmanaged
            where T2 : unmanaged
                => new tuple<T0,T1,T2>(a0,a1,a2);

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct tuple<T0,T1,T2> : ITuple<tuple<T0,T1,T2>,N3,T0,T1,T2>
            where T0: unmanaged
            where T1: unmanaged
            where T2 : unmanaged
        {
            public static ByteSize SZ => size<tuple<T0,T1,T2>>();

            internal T0 c0;

            internal T1 c1;

            internal T2 c2;

            [MethodImpl(Inline)]
            public tuple(T0 a0, T1 a1, T2 a2)
            {
                c0 = a0;
                c1 = a1;
                c2 = a2;
            }

            public T0 this[N0 n]
            {
                [MethodImpl(Inline)]
                get => c0;
                [MethodImpl(Inline)]
                set => c0 = value;
            }

            public T1 this[N1 n]
            {
                [MethodImpl(Inline)]
                get => c1;
                [MethodImpl(Inline)]
                set => c1 = value;
            }

            public T2 this[N2 n]
            {
                [MethodImpl(Inline)]
                get => c2;
                [MethodImpl(Inline)]
                set => c2 = value;
            }
        }
    }
}