//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial struct Intrinsics
    {
        public struct __m256i<T>
            where T : unmanaged
        {
            Cell256<T> Data;

            [MethodImpl(Inline)]
            public __m256i(Vector256<T> src)
                => Data = src;

            [MethodImpl(Inline)]
            public __m256i(Cell256<T> src)
                => Data = src;

            public num<T> this[int i]
            {
                [MethodImpl(Inline)]
                get => cell(ref this, i);

                [MethodImpl(Inline)]
                set => cell(ref this, i) = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator __m256i<T>(Vector256<T> src)
                => new __m256i<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator __m256i<T>(T src)
                => gcpu.vbroadcast(w256,src);

            [MethodImpl(Inline)]
            public static implicit operator Vector256<T>(__m256i<T> src)
                => src.Data;
        }
    }
}