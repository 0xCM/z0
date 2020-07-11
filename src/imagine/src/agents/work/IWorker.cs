//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IWorker
    {
        void Process(IOperands args, IWorkState state) {}
    }

    public interface IWorker<C>: IWorker
        where C : IOperands
    {
        
    }

    public interface IWorker<C,S> : IWorker<C>
        where C : unmanaged, IOperands
        where S : IWorkState
    {
        void Process(in C cmd, ref S state);      

        [MethodImpl(Inline)]
        void Process(IOperands cmd, ref S state)
            => Process((C)cmd, ref state);
    }
            
    public interface IWorker<P,C,S> : IWorker<C>
        where P : unmanaged, IWorker<P,C,S>
        where C : unmanaged, IOperands
        where S : IWorkState
    {
        void Process(in C cmd, ref S state);    
    }    
}