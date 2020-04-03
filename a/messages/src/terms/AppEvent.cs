//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AppEvent : IFormattable<AppEvent>, IAppEvent<AppEvent,object>
    {
        public string Description {get;}
        
        public object Payload {get;}

        public CorrelationToken Correlation {get;}

        [MethodImpl(Inline)]
        public AppEvent Create(string name, object data = null, CorrelationToken? ct = null)
            => new AppEvent(name,data,ct);

        [MethodImpl(Inline)]
        public static AppEvent<T> Create<T>(string name, T data, CorrelationToken? ct = null)
            => new AppEvent<T>(name, data, ct);

        [MethodImpl(Inline)]
        internal AppEvent(string name, object data, CorrelationToken? ct = null)
        {
            this.Description = name;
            this.Payload = data ?? default(EmptyPayload);
            this.Correlation = ct ?? CorrelationToken.Empty;
        }

        public bool HasPayload
        {
            [MethodImpl(Inline)]
            get => Payload != null && !(Payload is IEmptyPayload);
        }

        public string Format()
            => string.Concat(Payload, CharText.Colon, CharText.Space, Payload);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public AppEvent<T> As<T>()
            => Create<T>(Description, (T)Payload, Correlation);

        readonly struct EmptyPayload : IFormattable<EmptyPayload>, IEmptyPayload
        {            
            public string Format() => string.Empty;

            public override string ToString() => Format();
        }

        interface IEmptyPayload {}
    }

    public readonly struct AppEvent<T> : IFormattable<AppEvent<T>>, IAppEvent<AppEvent<T>,T>
    {
        public string Description {get;}
        
        public T Payload {get;}

        public CorrelationToken Correlation {get;}

        [MethodImpl(Inline)]
        public static implicit operator AppEvent(AppEvent<T> src)
            => new AppEvent(src.Description, src.Payload, src.Correlation);

        [MethodImpl(Inline)]
        internal AppEvent(string name, T data, CorrelationToken? ct = null)
        {
            this.Description = name;
            this.Payload = data;
            this.Correlation = ct ?? CorrelationToken.Empty;
        }

        public string Format()
            => string.Concat(Payload, CharText.Colon, CharText.Space, Payload);

        public override string ToString()
            => Format();
    }
}