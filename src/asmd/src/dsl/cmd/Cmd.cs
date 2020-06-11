//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes an instruction
    /// </summary>
    public readonly struct cmd : ICmd
    {
        public IOperand[] Args {get;}

        public CmdOpCode Code {get;}
 
        [MethodImpl(Inline)]
        public cmd(params IOperand[] args)
        {
            Args = args;
            Code = default;
        }

        [MethodImpl(Inline)]
        public cmd(CmdOpCode code, params IOperand[] args)
        {
            Args = args;
            Code = code;
        }       
    }
}