//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct EncodedOpCode
    {        
        public readonly byte[] Data;
        
        public readonly HexKind Primary;

        readonly byte Options;

        public readonly OperatingMode Mode;

        readonly byte Reserved;

        readonly ulong Operands;

        [MethodImpl(Inline)]
        public EncodedOpCode(byte[] data, HexKind primary, byte options, OperatingMode mode, ulong operands)
        {
            this.Data = data;
            this.Primary = primary;
            this.Options = options;
            this.Mode = mode;
            this.Operands = operands;
            this.Reserved = 0;
        }

        public OpCodeOperand this[duet index]
        {
            [MethodImpl(Inline)]
            get => OpCodes.operand(Operands, index);
        }        
    }
}