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
    public readonly struct cmd<X0,X1,X2> : ICmd<cmd<X0,X1,X2>,X0,X1,X2>
        where X0 : struct, IOperand
        where X1 : struct, IOperand
        where X2 : struct, IOperand
    {
        public CmdOpCode Code {get;}

        public X0 A {get;}

        public X1 B {get;}

        public X2 C {get;}

        [MethodImpl(Inline)]
        public static implicit operator cmd(cmd<X0,X1,X2> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public cmd(CmdOpCode code, X0 a, X1 b, X2 x)
        {
            A = a;
            B = b;
            C = x;
            Code = code;
        }
        
        public cmd Untyped 
        { 
            [MethodImpl(Inline)] 
            get => new cmd(A, B, C);
        }
    }
}