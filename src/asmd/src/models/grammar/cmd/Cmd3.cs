//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Z0.Asm.Data;

    /// <summary>
    /// Defines an instruction that accepts three arguments
    /// </summary>
    public readonly struct Cmd<A,B,C> : ICmdData<Cmd<A,B,C>,A,B,C>
        where A : struct, IOperandSpec
        where B : struct, IOperandSpec
        where C : struct, IOperandSpec
    {
        [MethodImpl(Inline)]
        public static implicit operator Cmd(Cmd<A,B,C> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public Cmd(CmdOpCode code, A arg0, B arg1, C arg3)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg3;
            Code = code;
        }

        public CmdOpCode Code {get;}

        public A Arg0 {get;}

        public B Arg1 {get;}

        public C Arg2 {get;}
        
        public Cmd Untyped { [MethodImpl(Inline)] get => new Cmd(Arg0, Arg1, Arg2);}
    }
}