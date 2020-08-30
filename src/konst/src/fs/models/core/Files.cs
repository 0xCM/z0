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
            public readonly FilePath[] Data;

            [MethodImpl(Inline)]
            public static implicit operator FilePath[](Files src)
                => src.Data;

            [MethodImpl(Inline)]
            public static implicit operator Files(FilePath[] src)
                => new Files(src);

            [MethodImpl(Inline)]
            public Files(FilePath[] src)
                => Data = src;

            public Count32 Count
            {
                [MethodImpl(Inline)]
                get => Data.Length;
            }

            public ref readonly FilePath this[uint index]
            {
                [MethodImpl(Inline)]
                get => ref Data[index];
            }

            [MethodImpl(Inline)]
            public static FilePath normalize(FilePath src)
                => path(src.Name.Replace('\\', '/'));

            IEnumerator<FilePath> IEnumerable<FilePath>.GetEnumerator()
                => ((IEnumerable<FilePath>)Data).GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => Data.GetEnumerator();
        }
    }
}