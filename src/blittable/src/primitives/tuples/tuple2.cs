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
        public static tuple<T0,T1> t2<T0,T1>(T0 a0 = default, T1 a1 = default)
            where T0: unmanaged
            where T1: unmanaged
                => new tuple<T0,T1>(a0,a1);

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct tuple<T0,T1> : ITuple<tuple<T0,T1>,N2,T0,T1>
            where T0: unmanaged
            where T1: unmanaged
        {
            public static ByteSize SZ => size<tuple<T0,T1>>();

            internal T0 c0;

            internal T1 c1;

            [MethodImpl(Inline)]
            public tuple(T0 a0, T1 a1)
            {
                c0 = a0;
                c1 = a1;
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
        }
    }
}