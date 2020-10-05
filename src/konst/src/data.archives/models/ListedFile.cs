//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using  api = Archives;

    /// <summary>
    /// Defines an entry in list of files
    /// </summary>
    public readonly struct ListedFile : ITextual
    {
        public readonly uint Index;

        public readonly FS.FilePath Path;

        [MethodImpl(Inline)]
        public static implicit operator ListedFile((uint index, FS.FilePath path) src)
            => new ListedFile(src.index, src.path);

        [MethodImpl(Inline)]
        public static implicit operator ListedFile((int index, FS.FilePath path) src)
            => new ListedFile(src.index, src.path);

        [MethodImpl(Inline)]
        public ListedFile(uint index, FS.FilePath path)
        {
            Index = index;
            Path = path;
        }

        [MethodImpl(Inline)]
        public ListedFile(int index, FS.FilePath path)
        {
            Index = (uint)index;
            Path = path;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);
    }
}