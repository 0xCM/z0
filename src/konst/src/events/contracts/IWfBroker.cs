//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IWfBroker : IAppBase, IDisposable, IMultiSink
    {
        Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent;        

        void Raise(IWfEvent e);

        void Raise(IAppEvent e);

        IWfEventSink Sink {get;}       
    }
}