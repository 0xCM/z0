//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Describes a register in the context of an asm instruction operand
    /// </summary>
    public class AsmRegisterInfo
    {
        public AsmRegisterInfo(Register name)
        {
            this.Name = name;
        }
        
        public Register Name {get;}

        public override string ToString()
            => Name.ToString();
    }
}