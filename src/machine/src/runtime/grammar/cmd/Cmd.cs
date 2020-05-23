//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Data;

    using static Seed;

    /// <summary>
    /// Describes an instruction
    /// </summary>
    public readonly struct Cmd : ICmd
    {
        [MethodImpl(Inline)]
        public Cmd(params IOperand[] args)
        {
            Args = args;
            Code = default;
        }

        [MethodImpl(Inline)]
        public Cmd(CmdOpCode code, params IOperand[] args)
        {
            Args = args;
            Code = code;
        }
        
        public IOperand[] Args {get;}

        public CmdOpCode Code {get;}
    }
}