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

    [Event(EventName)]
    public readonly struct RowsEvent<T> : IWfEvent<RowsEvent<T>>
        where T : ITextual
    {
        public const string EventName = GlobalEvents.Rows;

        public Type DataType {get;}

        public WfEventId EventId {get;}

        public T Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RowsEvent(T data)
        {
            DataType = typeof(T);
            EventId = DataType;
            Content = data;
            Flair = FlairKind.DataRow;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();
    }
}