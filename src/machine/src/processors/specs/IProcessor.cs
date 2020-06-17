//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static Memories;

    public interface IProcessor
    {
        void Process(ICmd cmd, IProcessState state) {}
    }

    public interface IProcessor<C>: IProcessor
        where C : ICmd
    {
        
    }

    public interface IProcessor<C,S> : IProcessor<C>
        where C : unmanaged, ICmd
        where S : IProcessState
    {
        void Process(in C cmd, ref S state);      

        [MethodImpl(Inline)]
        void Process(ICmd cmd, ref S state)
            => Process((C)cmd, ref state);
    }
            
    public interface IProcessor<P,C,S> : IProcessor<C>
        where P : unmanaged, IProcessor<P,C,S>
        where C : unmanaged, ICmd
        where S : IProcessState
    {
        void Process(in C cmd, ref S state);    
    }    
}