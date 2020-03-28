//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Apps;

    public readonly struct AppEvent : IFormattable<AppEvent>, IAppEvent<AppEvent,object>
    {
        public string Description {get;}
        
        public object EventData {get;}

        public CorrelationToken Correlation {get;}

        [MethodImpl(Inline)]
        public static AppEvent<T> Create<T>(string name, T data, CorrelationToken? ct = null)
            => new AppEvent<T>(name, data, ct);

        [MethodImpl(Inline)]
        internal AppEvent(string name, object data, CorrelationToken? ct = null)
        {
            this.Description = name;
            this.EventData = data;
            this.Correlation = ct ?? CorrelationToken.Empty;
        }

        public string Format()
            => text.concat(EventData, text.colon(), text.space(), EventData);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public AppEvent<T> As<T>()
            => Create<T>(Description, (T)EventData, Correlation);
    }

    public readonly struct AppEvent<T> : IFormattable<AppEvent<T>>, IAppEvent<AppEvent<T>,T>
    {
        public string Description {get;}
        
        public T EventData {get;}

        public CorrelationToken Correlation {get;}

        [MethodImpl(Inline)]
        public static implicit operator AppEvent(AppEvent<T> src)
            => new AppEvent(src.Description, src.EventData, src.Correlation);

        [MethodImpl(Inline)]
        internal AppEvent(string name, T data, CorrelationToken? ct = null)
        {
            this.Description = name;
            this.EventData = data;
            this.Correlation = ct ?? CorrelationToken.Empty;
        }

        public string Format()
            => text.concat(EventData, text.colon(), text.space(), EventData);

        public override string ToString()
            => Format();
    }
}