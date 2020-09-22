//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ListedFiles
    {
        readonly TableSpan<ListedFile> Data;

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

        public ListedFile[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
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

        public void Save(Z0.FilePath dst)
        {
            var records = View;
            var count = records.Length;
            var header = Table.header<ListedFileField>();
            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(Archives.format(record));
            }
        }
    }
}