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
        public readonly ListedFile[] Data;

        [MethodImpl(Inline)]
        public ListedFiles(ListedFile[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ref readonly ListedFile this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator ListedFiles(ListedFile[] src)
            => new ListedFiles(src);
    }
}