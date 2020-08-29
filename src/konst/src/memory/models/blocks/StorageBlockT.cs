//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct StorageBlock<T>
        where T : unmanaged
    {
        public static ByteSize Size => size<T>()*2;

        public T Lo;

        public T Hi;

        [MethodImpl(Inline)]
        public static implicit operator StorageBlock<T>(Pair<T> src)
            => new StorageBlock<T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public StorageBlock(T lo, T hi)
        {
            Lo = lo;
            Hi = hi;
        }
    }
}