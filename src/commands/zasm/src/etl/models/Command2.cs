//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines an instruction that accepts two arguments
    /// </summary>
    public readonly struct Command<A,B> : ICommand<Command<A,B>,A,B>
        where A : struct, IOperand
        where B : struct, IOperand
    {
        [MethodImpl(Inline)]
        public static implicit operator Command(Command<A,B> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public Command(CmdOpCode code, A arg0, B arg1)
        {
            Code = code;
            Arg0 = arg0;
            Arg1 = arg1;
        }

        public CmdOpCode Code {get;}

        public A Arg0 {get;}

        public B Arg1 {get;}

        public Command Untyped { [MethodImpl(Inline)] get => new Command(Arg0, Arg1);}
    }
}