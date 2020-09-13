//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ListedFiles
    {
        public readonly TableSpan<ListedFile> Data;

        [MethodImpl(Inline)]
        public ListedFiles(ListedFile[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator ListedFiles(ListedFile[] src)
            => new ListedFiles(src);

        [MethodImpl(Inline)]
        public static implicit operator ListedFiles(FS.FilePath[] src)
            => new ListedFiles(src.Mapi((i,x) => new ListedFile(i,x)));

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ReadOnlySpan<ListedFile> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<ListedFile> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref ListedFile this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref ListedFile this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref ListedFile First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }
    }
}