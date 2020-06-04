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
    /// Defines an instruction that accepts one argument
    /// </summary>
    public readonly struct Cmd<A> : ICmdData<Cmd<A>,A>
        where A : struct, IOperand
    {
        [MethodImpl(Inline)]
        public static implicit operator Cmd(Cmd<A> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public Cmd(CmdOpCodeModel code, A arg0)
        {
            Code = code;
            Arg0 = arg0;
        }

        public A Arg0 {get;}

        public CmdOpCodeModel Code {get;}

        public Cmd Untyped { [MethodImpl(Inline)] get => new Cmd(Arg0);}
    }
}