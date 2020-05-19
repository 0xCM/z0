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
    /// Defines an instruction that accepts three arguments
    /// </summary>
    public readonly struct Command<A,B,C> : ICommand<Command<A,B,C>,A,B,C>
        where A : struct, IOperand
        where B : struct, IOperand
        where C : struct, IOperand
    {
        [MethodImpl(Inline)]
        public static implicit operator Command(Command<A,B,C> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public Command(CmdOpCode code, A arg0, B arg1, C arg3)
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
        
        public Command Untyped { [MethodImpl(Inline)] get => new Command(Arg0, Arg1, Arg2);}
    }
}