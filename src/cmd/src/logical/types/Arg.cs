//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    public readonly struct Arg : IOperand
    {
        readonly byte[] Cells;

        public OperandSize Width {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Arg(byte[] data, OperandKind kind)
        {
            Cells = data;
            Width = (OperandSize)(data.Length * 8);
            ArgKind = kind;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => Cells;
        }        
    }
 
}