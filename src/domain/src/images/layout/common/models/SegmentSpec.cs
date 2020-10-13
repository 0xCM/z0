//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using api = DataLayouts;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct SegmentSpec : IDataLayout<SegmentSpec,SegmentPartition>
    {
        public LayoutIdentity Id {get;}

        readonly TableSpan<SegmentPartition> Data;

        [MethodImpl(Inline)]
        public SegmentSpec(LayoutIdentity id, SegmentPartition[] parts)
        {
            Id = id;
            Data = parts;
        }

        public uint Index
        {
            [MethodImpl(Inline)]
            get => Id.Index;
        }

        public uint SectionCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<SegmentPartition> Sections
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref SegmentPartition FirstSection
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ref SegmentPartition this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => api.width(Sections);
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}