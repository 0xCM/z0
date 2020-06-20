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
    /// Defines an instruction that accepts three arguments
    /// </summary>
    public readonly struct cmd<A,B,C> : ICmd<cmd<A,B,C>,A,B,C>
        where A : struct, IOperand
        where B : struct, IOperand
        where C : struct, IOperand
    {
        public CmdOpCode Code {get;}

        public A Arg0 {get;}

        public B Arg1 {get;}

        public C Arg2 {get;}

        [MethodImpl(Inline)]
        public static implicit operator cmd(cmd<A,B,C> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public cmd(CmdOpCode code, A arg0, B arg1, C arg3)
        {
            Arg0 = arg0;
            Arg1 = arg1;
            Arg2 = arg3;
            Code = code;
        }
        
        public cmd Untyped 
        { 
            [MethodImpl(Inline)] 
            get => new cmd(Arg0, Arg1, Arg2);
        }
    }
}