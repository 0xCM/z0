//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EventMessage
    {
        public IWfEvent Event {get;}

        public TextBlock Message {get;}

        [MethodImpl(Inline)]
        public EventMessage(IWfEvent e, TextBlock msg)
        {
            Event = e;
            Message = msg;
        }

        public string Format()
            => Message;

        public override string ToString()
            => Format();
    }
}