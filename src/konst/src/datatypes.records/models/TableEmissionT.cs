//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures the emission of a record sequence to a file-system target
    /// </summary>
    public readonly struct TableEmission<T> : ITextual
        where T : struct
    {
        public IndexedSeq<T> Data {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public TableEmission(T[] src, FS.FilePath dst)
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

        public string Format()
            => string.Format("{0}({1}): {2}", typeof(T).Name, RowCount, Target.ToUri());

        public override string ToString()
            => Format();
    }
}