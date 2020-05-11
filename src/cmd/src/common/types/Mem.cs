//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Models
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    public readonly struct Mem : IMemory
    {
        readonly byte[] Cells;

        public OperandSize Width {get;}

        [MethodImpl(Inline)]
        public Mem(byte[] data)
        {
            Cells = data;
            Width = (OperandSize)(data.Length * 8);
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => Cells;
        }        
    }

}