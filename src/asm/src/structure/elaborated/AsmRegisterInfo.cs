//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    /// <summary>
    /// Describes a register in the context of an asm instruction operand
    /// </summary>
    public readonly struct AsmRegisterInfo : ITextual
    {
        public static AsmRegisterInfo Empty => new AsmRegisterInfo(Register.None);

        [MethodImpl(Inline)]
        public AsmRegisterInfo(Register name)
        {
            this.Name = name;
        }
        
        public Register Name {get;}

        public string Format() 
            => $"{Name}";

        public override string ToString()
            => Format();
    }
}