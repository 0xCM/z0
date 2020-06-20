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
    public readonly struct cmd<X0,X1> : ICmd<cmd<X0,X1>,X0,X1>
        where X0 : struct, IOperand
        where X1 : struct, IOperand
    {
        public CmdOpCode Code {get;}

        public X0 A {get;}

        public X1 B {get;}

        [MethodImpl(Inline)]
        public static implicit operator cmd(cmd<X0,X1> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public cmd(CmdOpCode code, X0 arg0, X1 arg1)
        {
            Code = code;
            A = arg0;
            B = arg1;
        }

        public cmd Untyped 
        {
             [MethodImpl(Inline)] 
             get => new cmd(A, B);
        }
    }
}