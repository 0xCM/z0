//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct OutputReceiver<T>
    {
        public static OutputReceiver<T> create(ViewTrigger<T> trigger)
        {
            var receiver = new OutputReceiver<T>();
            receiver.Trigger = trigger;
            receiver.Current = default;
            return receiver;
        }

        internal T Current;

        internal ViewTrigger<T> Trigger;
    }
}