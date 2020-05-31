//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;


    using static Seed;

    /// <summary>
    /// Describes an instruction
    /// </summary>
    public readonly struct Cmd : ICmdData
    {
        [MethodImpl(Inline)]
        public Cmd(params IOperandSpec[] args)
        {
            Args = args;
            Code = default;
        }

        [MethodImpl(Inline)]
        public Cmd(CmdOpCode code, params IOperandSpec[] args)
        {
            Args = args;
            Code = code;
        }
        
        public IOperandSpec[] Args {get;}

        public CmdOpCode Code {get;}
    }
}