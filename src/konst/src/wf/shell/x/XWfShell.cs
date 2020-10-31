//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.WfShellX, true)]
    public static partial class XWFShell
    {
        [MethodImpl(Inline), Op]
        public static bool Babble(this LogLevel src)
            => src == LogLevel.Babble;

        /// <summary>
        /// Registers an event receiver to which brokered events will be relayed
        /// </summary>
        /// <param name="e">An event representative</param>
        /// <param name="broker">The broker</param>
        /// <param name="receiver">The handler invoked upon event occurrence</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static Outcome Subscribe<E>(this E e, IWfBroker broker, Action<E> receiver)
            where E : IWfEvent
                => broker.Subscribe(receiver, e);
    }
}