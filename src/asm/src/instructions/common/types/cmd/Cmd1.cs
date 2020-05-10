//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class InstructionModels
    {
        /// <summary>
        /// Defines an instruction that accepts one argument
        /// </summary>
        public readonly struct Cmd<A> : ICommand<Cmd<A>,A>
            where A : unmanaged, IOperand
        {
            [MethodImpl(Inline)]
            public static implicit operator Cmd(Cmd<A> src)
                => src.Untyped;

            [MethodImpl(Inline)]
            public Cmd(A arg0)
            {
                Arg0 = arg0;
            }

            public A Arg0 {get;}

            public Cmd Untyped { [MethodImpl(Inline)] get => new Cmd(Arg0);}
        }
    }
}