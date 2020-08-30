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

        public FilePath Target {get;}

        [MethodImpl(Inline)]
        public TableEmission(T[] src, FilePath dst)
        {
            Data = src;
            Target = dst;
        }

        public Count32 RowCount
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