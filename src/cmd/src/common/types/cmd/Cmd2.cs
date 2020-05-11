//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Models
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    /// <summary>
    /// Defines an instruction that accepts two arguments
    /// </summary>
    public readonly struct Cmd<A,B> : ICommand<Cmd<A,B>,A,B>
        where A : unmanaged, IOperand
        where B : unmanaged, IOperand
    {
        [MethodImpl(Inline)]
        public static implicit operator Cmd(Cmd<A,B> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public Cmd(A arg0, B arg1)
        {
            Arg0 = arg0;
            Arg1 = arg1;
        }

        public A Arg0 {get;}

        public B Arg1 {get;}

        public Cmd Untyped { [MethodImpl(Inline)] get => new Cmd(Arg0, Arg1);}
    }
}