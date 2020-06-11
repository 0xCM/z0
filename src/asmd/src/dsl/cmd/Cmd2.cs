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
    /// Defines an instruction that accepts two arguments
    /// </summary>
    public readonly struct cmd<A,B> : ICmd<cmd<A,B>,A,B>
        where A : struct, IOperand
        where B : struct, IOperand
    {
        [MethodImpl(Inline)]
        public static implicit operator cmd(cmd<A,B> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public cmd(CmdOpCode code, A arg0, B arg1)
        {
            Code = code;
            Arg0 = arg0;
            Arg1 = arg1;
        }

        public CmdOpCode Code {get;}

        public A Arg0 {get;}

        public B Arg1 {get;}

        public cmd Untyped { [MethodImpl(Inline)] get => new cmd(Arg0, Arg1);}
    }
}