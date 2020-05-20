//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;

    public readonly struct Reg : IRegister
    {
        readonly byte[] Cells;

        public DataWidth Width {get;}

        public RegisterKind RegisterKind {get;}

        [MethodImpl(Inline)]
        public Reg(byte[] data, RegisterKind kind)
        {
            Cells = data;
            Width = (DataWidth)(data.Length * 8);
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