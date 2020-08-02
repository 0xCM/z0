//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IWfBroker : IDisposable
    {
        Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent;        

        void Raise(IWfEvent e);

        void Raise(IAppEvent e);

        IWfEventSink Sink {get;}
    }

    public static partial class XTend
    {
        /// <summary>
        /// Registers an event receiver to which brokered events will be relayed
        /// </summary>
        /// <param name="e">An event representative</param>
        /// <param name="broker">The broker</param>
        /// <param name="receiver">The handler ivoked upon event occurrence</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static Outcome Subscribe<E>(this E e, IWfBroker broker, Action<E> receiver)
            where E : IWfEvent
                => broker.Subscribe(receiver, e);            
    }
}