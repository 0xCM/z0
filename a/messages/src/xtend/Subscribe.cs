//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Registers an event receiver to which brokered events will be relayed
        /// </summary>
        /// <param name="e">An event representative</param>
        /// <param name="broker">The broker</param>
        /// <param name="receiver">The handler ivoked upon event occurrence</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static Outcome Subscribe<E>(this E e, IAppEventBroker broker, Action<E> receiver)
            where E : IAppEvent
                => AppEvents.subscribe(e, broker, receiver);
    }
}