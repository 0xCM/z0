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

    partial struct WfEvents
    {
        public readonly struct DataRow<T> : IWfEvent<DataRow<T>>
            where T : ITextual
        {
            public const string EventName = nameof(DataRow<T>);

            public WfEventId EventId {get;}

            public T Data {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public DataRow(T data, CorrelationToken ct, FlairKind flair = FlairKind.DataRow)
            {
                EventId = (EventName, ct);
                Data = data;
                Flair = flair;
            }

            [MethodImpl(Inline)]
            public string Format()
                =>  Render.format(EventId, Data);
        }

        public readonly struct DataRow<T,K> : IWfEvent<DataRow<T,K>>
            where T : ITextual
        {
            public const string EventName = nameof(DataRow<T,K>);

            public WfEventId EventId {get;}

            public T Data {get;}

            public DataKind<K> Class {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public DataRow(T data, K kind, CorrelationToken ct, FlairKind flair = FlairKind.DataRow)
            {
                EventId = (EventName, ct);
                Data = data;
                Class = kind;
                Flair = flair;
            }

            [MethodImpl(Inline)]
            public string Format()
                =>  Render.format(EventId, Class, Data);
        }
    }
}