//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    /// <summary>
    /// Describes an instruction
    /// </summary>
    public readonly struct Cmd : ICommand
    {
        [MethodImpl(Inline)]
        public Cmd(params IOperand[] args)
        {
            Args = args;
            Code = default;
            Sig = default;
        }

        [MethodImpl(Inline)]
        public Cmd(CmdInfo code, params IOperand[] args)
        {
            Args = args;
            Code = code;
            Sig = default;
        }

        [MethodImpl(Inline)]
        public Cmd(CmdInfo code, OpSig sig, params IOperand[] args)
        {
            Args = args;
            Code = code;
            Sig = sig;
        }

        public IOperand[] Args {get;}

        public CmdInfo Code {get;}

        public OpSig Sig {get;}
    }

}