//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitFlow
    {
        public struct list<T>
            where T : unmanaged
        {
            Index<T> Data;

            [MethodImpl(Inline)]
            public list(T[] src)
            {
                Data = src;
            }

            public uint ItemCount
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            public ref T this[uint index]
            {
                [MethodImpl(Inline)]
                get => ref Data[index];
            }

            public ref T this[int index]
            {
                [MethodImpl(Inline)]
                get => ref Data[index];
            }

            [MethodImpl(Inline)]
            public static implicit operator list<T>(T[] src)
                => new list<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator T[](list<T> src)
                => src.Data;
        }
    }
}