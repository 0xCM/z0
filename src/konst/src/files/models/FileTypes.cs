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

    public readonly struct FileTypes
    {
        readonly FileType[] Data;

        [MethodImpl(Inline)]
        public FileTypes(FileType[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ReadOnlySpan<FileType> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator FileTypes(FileType[] src)
            => new FileTypes(src);
    }
}