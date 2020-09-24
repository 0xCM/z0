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
        public readonly struct RowCreated<T> : IWfEvent<RowCreated<T>>
            where T : ITextual
        {
            public Type DataType {get;}

            public WfEventId EventId {get;}

            public T Content {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public RowCreated(T data, CorrelationToken ct, FlairKind flair = FlairKind.DataRow)
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

        public readonly struct RowCreated<T,K> : IWfEvent<RowCreated<T,K>>
            where T : ITextual
            where K : unmanaged
        {
            public const string EventName = nameof(RowCreated<T,K>);

            public Type DataType {get;}

            public Kind<K> DataKind {get;}

            public WfEventId EventId {get;}

            public T Content {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public RowCreated(T data, K kind, CorrelationToken ct, FlairKind flair = FlairKind.DataRow)
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