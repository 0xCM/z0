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
    {
        public string Description {get;}
        
        public T Payload {get;}

        public CorrelationToken Correlation {get;}
        
        [MethodImpl(Inline)]
        public static implicit operator AppEvent(AppEvent<T> src)
            => new AppEvent(src.Description, src.Payload, src.Correlation);

        [MethodImpl(Inline)]
        public AppEvent(string name, T data, CorrelationToken? ct = null)
        {
            Description = name;
            Payload = data;
            Correlation = ct ?? CorrelationToken.Empty;
        }
        
        public AppEvent<T> Zero 
            => Empty;

        public string Format()
            => string.Concat(Payload, CharText.Colon, CharText.Space, Payload);

        public override string ToString()
            => Format();

        public static AppEvent<T> Empty 
            => new AppEvent<T>(string.Empty, default(T));
    }
}