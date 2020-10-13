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
    public readonly struct SegmentPartition : IDataLayout<SegmentPartition>
    {
        public LayoutIdentity Id {get;}

        readonly ClosedInterval<ulong> Range;

        public uint Index  => Id.Index;

        [MethodImpl(Inline)]
        public SegmentPartition(LayoutIdentity id, ulong start, ulong end)
        {
            Id = id;
            Range = new ClosedInterval<ulong>(start,end);
        }

        public ulong Left
        {
            [MethodImpl(Inline)]
            get => Range.Min;
        }

        public ulong Right
        {
            [MethodImpl(Inline)]
            get => Range.Max;
        }

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => Range.Width;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}