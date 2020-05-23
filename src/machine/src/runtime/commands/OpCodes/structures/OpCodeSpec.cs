//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct OpCodeSpec
    {
        [MethodImpl(Inline)]
        public static OpCodeSpec From(ReadOnlySpan<byte> src)
            => new OpCodeSpec(src);
        
        public readonly byte[] Encoded;
        
        public readonly HexKind Primary;

        readonly byte Options;

        public readonly OperatingMode Mode;

        readonly byte Reserved;

        readonly ulong Operands;

        [MethodImpl(Inline)]
        internal OpCodeSpec(ReadOnlySpan<byte> src)
        {
            this.Primary = (HexKind)head(src);
            this.Options = default;
            this.Mode = default;
            this.Operands = default;
            this.Reserved = 0;
            this.Encoded = src.ToArray();
        }

        [MethodImpl(Inline)]
        public OpCodeSpec(HexKind primary, byte options, OperatingMode mode, ulong operands)
        {
            this.Primary = primary;
            this.Options = options;
            this.Mode = mode;
            this.Operands = operands;
            this.Reserved = 0;
            this.Encoded = Control.array<byte>();
        }

        public OpCodeOperand this[duet index]
        {
            [MethodImpl(Inline)]
            get => OpCodes.operand(Operands, index);
        }        
    }
}