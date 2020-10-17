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

    public readonly struct Files : IEnumerable<FS.FilePath>
    {
        readonly FS.FilePath[] Data;

        [MethodImpl(Inline)]
        public static implicit operator Files(FS.FilePath[] src)
            => new Files(src);

        [MethodImpl(Inline)]
        public static implicit operator FS.FilePath[](Files src)
            => src.Data;

        [MethodImpl(Inline)]
        public Files(FS.FilePath[] src)
            => Data = src.Select(x => FS.path(x.Name));

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<FS.FilePath> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public FS.FilePath[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref FS.FilePath this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref FS.FilePath this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public static FS.FilePath normalize(FS.FilePath src)
            => FS.path(src.Name.Replace('\\', '/'));

        IEnumerator<FS.FilePath> IEnumerable<FS.FilePath>.GetEnumerator()
            => ((IEnumerable<FS.FilePath>)Data).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Data.GetEnumerator();
    }
}