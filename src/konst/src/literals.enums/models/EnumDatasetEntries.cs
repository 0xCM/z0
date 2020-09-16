//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Covers a <see cref='EnumDatasetEntry'/> sequence
    /// </summary>
    public readonly struct EnumDatasetEntries
    {
        readonly TableSpan<EnumDatasetEntry> Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumDatasetEntries(EnumDatasetEntry[] src)
            => new EnumDatasetEntries(src);

        [MethodImpl(Inline)]
        public EnumDatasetEntries(EnumDatasetEntry[] src)
            => Data = src;

        public Span<EnumDatasetEntry> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<EnumDatasetEntry> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref EnumDatasetEntry First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}