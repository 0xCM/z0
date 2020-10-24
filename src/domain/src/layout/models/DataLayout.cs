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

    using api = DataLayouts;

    public struct DataLayout : IDataLayout<DataLayout,SegmentSpec>
    {
        public uint Index {get;}

        public LayoutIdentity Id {get;}

        readonly TableSpan<SegmentSpec> Data;

        [MethodImpl(Inline)]
        public DataLayout(uint index, LayoutIdentity id, SegmentSpec[] segments)
        {
            Index = index;
            Id = id;
            Data = segments;
        }

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => api.width(Data.View);
        }

        public ReadOnlySpan<SegmentSpec> Sections
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint SectionCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref SegmentSpec FirstSection
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}