//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    public interface ICommandProcessor
    {
        void Process(IOperands args, ICommandProcessorState state) {}
    }

    public interface ICommandProcessor<C>: ICommandProcessor
        where C : IOperands
    {
        
    }

    public interface ICommandProcessor<C,S> : ICommandProcessor<C>
        where C : unmanaged, IOperands
        where S : ICommandProcessorState
    {
        void Process(in C cmd, ref S state);      

        [MethodImpl(Inline)]
        void Process(IOperands cmd, ref S state)
            => Process((C)cmd, ref state);
    }
            
    public interface ICommandProcessor<P,C,S> : ICommandProcessor<C>
        where P : unmanaged, ICommandProcessor<P,C,S>
        where C : unmanaged, IOperands
        where S : ICommandProcessorState
    {
        void Process(in C cmd, ref S state);    
    }    
}