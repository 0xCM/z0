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
    /// Defines an instruction that accepts two arguments
    /// </summary>
    public readonly struct Cmd<A,B> : ICmdData<Cmd<A,B>,A,B>
        where A : struct, IOperandSpec
        where B : struct, IOperandSpec
    {
        [MethodImpl(Inline)]
        public static implicit operator Cmd(Cmd<A,B> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public Cmd(CmdOpCode code, A arg0, B arg1)
        {
            Code = code;
            Arg0 = arg0;
            Arg1 = arg1;
        }

        public CmdOpCode Code {get;}

        public A Arg0 {get;}

        public B Arg1 {get;}

        public Cmd Untyped { [MethodImpl(Inline)] get => new Cmd(Arg0, Arg1);}
    }
}