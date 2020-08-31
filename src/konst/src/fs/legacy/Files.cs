//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct Files : IEnumerable<FilePath>
    {
        public static Files from(FilePath[] src)
            => new Files(src.Map(normalize));

        public readonly FilePath[] Data;

        [MethodImpl(Inline)]
        public static implicit operator Files(FilePath[] src)
            => new Files(src);

        [MethodImpl(Inline)]
        public static implicit operator FilePath[](Files src)
            => src.Data;

        [MethodImpl(Inline)]
        public Files(FilePath[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Files(FS.FilePath[] src)
            => Data = src.Select(x => FilePath.Define(x.Name));

        public Count32 Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<FilePath> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref FilePath this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref FilePath this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public static FilePath normalize(FilePath src)
            => FilePath.Define(src.Name.Replace('\\', '/'));

        IEnumerator<FilePath> IEnumerable<FilePath>.GetEnumerator()
            => ((IEnumerable<FilePath>)Data).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Data.GetEnumerator();
    }
}