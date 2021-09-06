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

    partial struct Blit
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct tuple<T0> : ITuple<tuple<T0>,N1,T0>
            where T0: unmanaged
        {
            internal T0 c0;

            [MethodImpl(Inline)]
            public tuple(T0 a0)
            {
                c0 = a0;
            }

            public T0 this[N0 n]
            {
                [MethodImpl(Inline)]
                get => c0;
                [MethodImpl(Inline)]
                set => c0 = value;
            }
        }
    }
}