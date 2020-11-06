//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event(EventName)]
    public readonly struct RowEvent<T> : IWfEvent<RowEvent<T>>
    {
        public const string EventName = nameof(GlobalEvents.Row);

        public WfEventId EventId {get;}

        public T Data {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RowEvent(T data, FlairKind flair = Ran)
        {
            EventId= WfEventId.define(EventName);
            Data = data;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data?.ToString() ?? EmptyString;
    }
}