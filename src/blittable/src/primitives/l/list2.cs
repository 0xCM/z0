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

    partial struct Blit
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct list2<T0,T1> : IList<list2<T0,T1>,N2,T0,T1>
            where T0: unmanaged
            where T1: unmanaged
        {
            internal T0 c0;

            internal T1 c1;

            [MethodImpl(Inline)]
            public list2(T0 a0, T1 a1)
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