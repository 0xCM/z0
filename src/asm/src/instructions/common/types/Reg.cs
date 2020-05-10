//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class InstructionModels
    {
        public readonly struct Reg : IRegister
        {
            readonly byte[] Cells;

            public OperandSize Width {get;}

            public RegisterKind RegisterKind {get;}

            [MethodImpl(Inline)]
            public Reg(byte[] data, RegisterKind kind)
            {
                Cells = data;
                Width = (OperandSize)(data.Length * 8);
                RegisterKind = kind;
            }

            public ReadOnlySpan<byte> Data
            {
                [MethodImpl(Inline)]
                get => Cells;
            }        

            public RegisterSymbol Symbol 
            {
                [MethodImpl(Inline)]
                get => (RegisterSymbol)RegisterKind;
            }
        }
    }
}