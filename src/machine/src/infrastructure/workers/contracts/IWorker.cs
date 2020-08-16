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
        void Process(IAsmOperands args, IWorkState state) 
        {

            
        }
    }

    public interface IWorker<C>: IWorker
        where C : IAsmOperands
    {
        
    }

    public interface IWorker<C,S> : IWorker<C>
        where C : unmanaged, IAsmOperands
        where S : IWorkState
    {
        void Process(in C cmd, ref S state);      

        [MethodImpl(Inline)]
        void Process(IAsmOperands cmd, ref S state)
            => Process((C)cmd, ref state);
    }
            
    public interface IWorker<P,C,S> : IWorker<C>
        where P : unmanaged, IWorker<P,C,S>
        where C : unmanaged, IAsmOperands
        where S : IWorkState
    {
        void Process(in C cmd, ref S state);    
    }    
}