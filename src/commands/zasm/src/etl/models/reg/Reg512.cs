//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;

    partial class Commands
    {
        public readonly struct Reg512 : IRegister512<Reg512>
        {
            public Vector512<byte> Value {get;}

            public RegisterKind RegisterKind {get;}
 
            public RegisterSymbol Symbol {get => (RegisterSymbol)RegisterKind; }
       }
    }
}