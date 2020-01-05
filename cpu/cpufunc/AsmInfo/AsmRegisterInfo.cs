//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Describes a register in the context of an asm instruction operand
    /// </summary>
    public class AsmRegisterInfo
    {
        public AsmRegisterInfo(string RegisterName)
        {
            this.RegisterName = RegisterName;
        }
        
        public string RegisterName {get;}
    }

}