//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Z0.Asm.Data;

    /// <summary>
    /// Defines an instruction that accepts one argument
    /// </summary>
    public readonly struct Command<A> : ICommand<Command<A>,A>
        where A : struct, IOperand
    {
        [MethodImpl(Inline)]
        public static implicit operator Command(Command<A> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public Command(CmdOpCode code, A arg0)
        {
            Code = code;
            Arg0 = arg0;
        }

        public A Arg0 {get;}

        public CmdOpCode Code {get;}

        public Command Untyped { [MethodImpl(Inline)] get => new Command(Arg0);}
    }
}