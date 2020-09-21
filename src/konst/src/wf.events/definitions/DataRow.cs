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
            public Type DataType {get;}

            public WfEventId EventId {get;}

            public T Content {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public DataRow(T data, CorrelationToken ct, FlairKind flair = FlairKind.DataRow)
            {
                DataType = typeof(T);
                EventId = (DataType, ct);
                Content = data;
                Flair = flair;
            }

            [MethodImpl(Inline)]
            public string Format()
                =>  Render.format(EventId, Content);
        }

        public readonly struct DataRow<T,K> : IWfEvent<DataRow<T,K>>
            where T : ITextual
        {
            public const string EventName = nameof(DataRow<T,K>);

            public Type DataType {get;}

            public DataKind<K> DataKind {get;}

            public WfEventId EventId {get;}

            public T Content {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public DataRow(T data, K kind, CorrelationToken ct, FlairKind flair = FlairKind.DataRow)
            {
                DataType = typeof(T);
                DataKind = kind;
                EventId = (text.format("{0}/{1}", DataKind, DataType.Name), ct);
                Content = data;
                Flair = flair;
            }

            [MethodImpl(Inline)]
            public string Format()
                => Render.format(EventId, Content);
        }
    }
}