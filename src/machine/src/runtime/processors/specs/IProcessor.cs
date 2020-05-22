//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IProcessor
    {
        void Process(ICommand cmd, IProcessState state) {}
    }

    public interface IProcessor<C>: IProcessor
        where C : ICommand
    {
        
    }

    public interface IProcessor<C,S> : IProcessor<C>
        where C : unmanaged, ICommand
        where S : IProcessState
    {
        void Process(in C cmd, ref S state);      

        [MethodImpl(Inline)]
        void Process(ICommand cmd, ref S state)
            => Process((C)cmd, ref state);
    }
            
    public interface IProcessor<P,C,S> : IProcessor<C>
        where P : unmanaged, IProcessor<P,C,S>
        where C : unmanaged, ICommand
        where S : IProcessState
    {
        void Process(in C cmd, ref S state);    
    }    
}