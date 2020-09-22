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

    public struct TextResourceRow
    {
        public ClrArtifactKey Id;

        public MemoryAddress Address;

        public Ptr<char> Value;
    }


    public readonly struct TextResourceRows
    {
        readonly TableSpan<TextResourceRow> Data;

        [MethodImpl(Inline)]
        public TextResourceRows(TextResourceRow[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator TextResourceRows(TextResourceRow[] src)
            => new TextResourceRows(src);

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<TextResourceRow> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}