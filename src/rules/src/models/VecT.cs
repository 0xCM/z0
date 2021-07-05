//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Vec<T>
        {
            readonly Index<T> Data;

            [MethodImpl(Inline)]
            public Vec(T[] src)
            {
                src = Data;
            }

            public uint Length
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Data.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !Data.IsEmpty;
            }

            public ref T this[long index]
            {
                [MethodImpl(Inline)]
                get => ref Data[index];
            }

            public ref T this[ulong index]
            {
                [MethodImpl(Inline)]
                get => ref Data[index];
            }

            public T[] Storage
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator Vec<T>(T[] src)
                => new Vec<T>(src);

            public static Vec<T> Empty => new Vec<T>(sys.empty<T>());
        }
    }
}