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

    partial struct FS
    {
        public readonly struct Files : IEnumerable<FilePath>
        {
            public readonly TableSpan<FilePath> Data;

            [MethodImpl(Inline)]
            public static implicit operator FilePath[](Files src)
                => src.Data;

            [MethodImpl(Inline)]
            public static implicit operator Files(FilePath[] src)
                => new Files(src);

            [MethodImpl(Inline)]
            public Files(FilePath[] src)
                => Data = src;

            public uint Count
            {
                [MethodImpl(Inline)]
                get => (uint)Data.Length;
            }

            public ReadOnlySpan<FilePath> View
            {
                [MethodImpl(Inline)]
                get => Data.View;
            }

            public Span<FilePath> Edit
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
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

            IEnumerator<FilePath> IEnumerable<FilePath>.GetEnumerator()
                => ((IEnumerable<FilePath>)Data.Storage).GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => Data.Storage.GetEnumerator();
        }
    }
}