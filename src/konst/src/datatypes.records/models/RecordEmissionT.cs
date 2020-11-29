//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RecordEmission<T> : IIndex<T>
        where T : struct
    {
        public IndexedSeq<T> Data {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public RecordEmission(T[] src, FS.FilePath dst)
        {
            Data = src;
            Target = dst;
        }

        public uint RowCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}