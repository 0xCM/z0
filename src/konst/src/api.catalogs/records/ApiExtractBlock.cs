//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Part;

    public enum ApiExtractField : uint
    {
        Sequence = 0 | 10 << WidthOffset,

        Address = 1 | 16 << WidthOffset,

        Length = 2 | 8 << WidthOffset,

        Uri = 3 | 110 << WidthOffset,

        OpSig = 4 | 110 << WidthOffset,

        Data = 5 | 1 << WidthOffset
    }

    public readonly struct ApiExtractBlock
    {
        public readonly int Sequence;

        public readonly MemoryAddress Address;

        public readonly int Length;

        public readonly OpUri Uri;

        public readonly string OpSig;

        public readonly CodeBlock Data;

        public ApiExtractBlock(int Sequence, MemoryAddress Address, int Length, OpUri Uri, string OpSig, CodeBlock Data)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.Length = Length;
            this.Uri = Uri;
            this.OpSig = OpSig;
            this.Data = Data;
        }
    }
}