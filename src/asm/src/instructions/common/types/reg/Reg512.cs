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
        public readonly struct Reg512 : IRegister512<Reg512>
        {
            public Vector512<byte> Value {get;}

            public RegisterKind RegisterKind {get;}
 
            public RegisterSymbol Symbol {get => (RegisterSymbol)RegisterKind; }
       }
    }
}