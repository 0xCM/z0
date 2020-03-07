//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public readonly struct AppEvent : IFormattable<AppEvent>, IAppEvent<AppEvent,object>
    {
        public string EventName {get;}
        
        public object EventData {get;}

        [MethodImpl(Inline)]
        public static AppEvent<T> Create<T>(string name, T data)
            => new AppEvent<T>(name,data);

        [MethodImpl(Inline)]
        internal AppEvent(string name, object data)
        {
            this.EventName = name;
            this.EventData = data;
        }

        public string Format()
            => text.concat(EventData, text.colon(), text.space(), EventData);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public AppEvent<T> As<T>()
            => Create<T>(EventName, (T)EventData);
    }

    public readonly struct AppEvent<T> : IFormattable<AppEvent<T>>, IAppEvent<AppEvent<T>,T>
    {
        public string EventName {get;}
        
        public T EventData {get;}

        [MethodImpl(Inline)]
        public static implicit operator AppEvent(AppEvent<T> src)
            => new AppEvent(src.EventName, src.EventData);

        [MethodImpl(Inline)]
        internal AppEvent(string name, T data)
        {
            this.EventName = name;
            this.EventData = data;
        }

        public string Format()
            => text.concat(EventData, text.colon(), text.space(), EventData);

        public override string ToString()
            => Format();
    }
}