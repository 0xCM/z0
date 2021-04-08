//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial struct Intel
    {
        public struct __m128i<T>
            where T : unmanaged
        {
            Vector128<T> Data;

            [MethodImpl(Inline)]
            public __m128i(Vector128<T> src)
                => Data = src;

            public num<T> this[int i]
            {
                [MethodImpl(Inline)]
                get => cell(ref this, i);

                [MethodImpl(Inline)]
                set => cell(ref this, i) = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator __m128i<T>(Vector128<T> src)
                => new __m128i<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator __m128i<T>(T src)
                => gcpu.vbroadcast(w128,src);

            [MethodImpl(Inline)]
            public static implicit operator Vector128<T>(__m128i<T> src)
                => src.Data;
        }
    }
}