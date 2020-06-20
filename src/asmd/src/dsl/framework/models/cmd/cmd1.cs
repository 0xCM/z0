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
    public readonly struct cmd<X0> : ICmd<cmd<X0>,X0>
        where X0 : struct, IOperand
    {
        public CmdOpCode Code {get;}

        public X0 A {get;}

        [MethodImpl(Inline)]
        public static implicit operator cmd(cmd<X0> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public cmd(CmdOpCode code, X0 arg0)
        {
            Code = code;
            A = arg0;
        }

        public cmd Untyped 
        { 
            [MethodImpl(Inline)] 
            get => new cmd(A);
        }
    }
}