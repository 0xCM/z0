//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Operand : IOperand
    {
        readonly byte[] Cells;

        public DataWidth Width {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Operand(byte[] data, OperandKind kind)
        {
            Cells = data;
            Width = (DataWidth)(data.Length * 8);
            ArgKind = kind;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => Cells;
        }        
    }
 
}