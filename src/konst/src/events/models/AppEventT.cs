//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppEvent<T> : IAppEvent<AppEvent<T>>
        where T : struct
    {
        public readonly StringRef Id;
        
        public readonly T Payload;

        public AppMsgColor Flair {get;}


        [MethodImpl(Inline)]
        public AppEvent(StringRef id, T data, AppMsgColor flair = AppMsgColor.Blue)
        {
            Id = id;
            Payload = data;
            Flair = flair;
        }
        
        public string Format()
        {
            var dst = text.build();
            dst.Append(Id);
            dst.Append(Chars.Space);
            dst.Append(Chars.Pipe);
            dst.AppendLine(z.bytes(Payload).Format());
            return dst.ToString();
        }    


        public override string ToString()
            => Format();

        public static AppEvent<T> Empty 
            => new AppEvent<T>(string.Empty, default(T), AppMsgColor.Gray);
    }
}