//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppEvent<T> : IAppEvent<AppEvent<T>, T>
        where T : struct
    {
        public EventId Id {get;}

        public EventPayload<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public AppEvent(EventId id, T data, FlairKind flair = FlairKind.Blue)
        {
            Id = id;
            Content = data;
            Flair = flair;
        }

        public string Format()
        {
            var dst = text.build();
            dst.Append(Id);
            dst.Append(Chars.Space);
            dst.Append(Chars.Pipe);
            dst.AppendLine(z.bytes(Content.Data).Format());
            return dst.ToString();
        }


        public override string ToString()
            => Format();

        public static AppEvent<T> Empty
            => default;
    }
}