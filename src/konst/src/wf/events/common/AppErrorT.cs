//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppError<T> : IAppEvent<AppError<T>, T>
    {
        public EventId Id {get;}

        public T Data {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public AppError(EventId id, T data)
        {
            Id = id;
            Data = data;
            Flair = FlairKind.Error;
        }

        public string Format()
            => text.format("{0} | {1}", Id, Data);
    }
}