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
    /// Defines an instruction that accepts one argument
    /// </summary>
    public readonly struct cmd<A> : ICmd<cmd<A>,A>
        where A : struct, IOperand
    {
        [MethodImpl(Inline)]
        public static implicit operator cmd(cmd<A> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public cmd(CmdOpCode code, A arg0)
        {
            Code = code;
            Arg0 = arg0;
        }

        public A Arg0 {get;}

        public CmdOpCode Code {get;}

        public cmd Untyped { [MethodImpl(Inline)] get => new cmd(Arg0);}
    }
}