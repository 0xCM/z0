//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableEmission<F,T>
        where T : struct, ITable<F,T>
        where F : unmanaged, Enum
    {
        public readonly T[] Data {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<T[],FS.FilePath>(TableEmission<F,T> src)
            => (src.Data,src.Target);

        [MethodImpl(Inline)]
        public TableEmission(T[] src, FS.FilePath dst)
        {
            Data = src;
            Target = dst;
        }

        public Count RowCount
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}