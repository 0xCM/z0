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

    /// <summary>
    /// Describes an instruction
    /// </summary>
    public readonly struct Command : ICommand
    {
        [MethodImpl(Inline)]
        public Command(params IOperand[] args)
        {
            Args = args;
            Code = default;
        }

        [MethodImpl(Inline)]
        public Command(CmdOpCode code, params IOperand[] args)
        {
            Args = args;
            Code = code;
        }
        
        public IOperand[] Args {get;}

        public CmdOpCode Code {get;}
    }
}