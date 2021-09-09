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
        public struct __m512i<T>
            where T : unmanaged
        {
            Cell512<T> Data;

            [MethodImpl(Inline)]
            public __m512i(Vector512<T> src)
                => Data = src;

            [MethodImpl(Inline)]
            public __m512i(Cell512<T> src)
                => Data = src;

            public num<T> this[int i]
            {
                [MethodImpl(Inline)]
                get => cell(ref this, i);

                [MethodImpl(Inline)]
                set => cell(ref this, i) = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator __m512i<T>(Vector512<T> src)
                => new __m512i<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator __m512i<T>(T src)
                => gcpu.vbroadcast(w512,src);

            [MethodImpl(Inline)]
            public static implicit operator Vector512<T>(__m512i<T> src)
                => src.Data;
        }
    }
}