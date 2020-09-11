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
            public static implicit operator Files(Z0.FilePath[] src)
                => new Files(src.Select(x => FS.path(x.Name)));

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

            public ReadOnlySpan<FilePath> ViewNonEmpty
                => Data.Storage.Where(x => x.IsNonEmpty);

            public Files Where(Func<FilePath,bool> f)
                => Data.Storage.Where(f);

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

            public Outcome<uint> Delete()
            {
                try
                {
                    foreach(var file in Data.View)
                        FS.delete(file);

                    Edit.Clear();

                    return Count;
                }
                catch(Exception e)
                {
                    return e;
                }
            }

            IEnumerator<FilePath> IEnumerable<FilePath>.GetEnumerator()
                => ViewNonEmpty.ToEnumerable().GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => ViewNonEmpty.ToEnumerable().GetEnumerator();
        }
    }
}