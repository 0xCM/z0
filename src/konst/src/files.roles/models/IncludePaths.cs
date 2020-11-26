//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = FileRoles;

    public readonly struct IncludePaths : IFsEntries<IncludePath>
    {
        readonly IndexedSeq<IncludePath> Data;

        [MethodImpl(Inline)]
        public IncludePaths(IncludePath[] src)
            => Data = src;

        public IncludePath[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator IncludePaths(IncludePath[] src)
            => new IncludePaths(src);

        public static IncludePaths Empty
            => new IncludePaths(sys.empty<IncludePath>());
    }
}