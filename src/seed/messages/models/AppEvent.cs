//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppEvent : ITextual<AppEvent>, IAppEvent<AppEvent>
    {
        public string Description {get;}
        
        public object Content {get;}

        public CorrelationToken Correlation {get;}
        

        [MethodImpl(Inline)]
        public AppEvent(string name, object data, CorrelationToken? ct = null)
        {
            Description = name;
            Content = data ?? default(EmptyPayload);
            Correlation = ct ?? CorrelationToken.Empty;
        }

        public bool HasPayload
        {
            [MethodImpl(Inline)]
            get => Content != null && !(Content is IEmptyPayload);
        }

        public AppEvent Zero 
            => Empty;

        public string Format()
            => string.Concat(Content, CharText.Colon, CharText.Space, Content);

        public override string ToString()
            => Format();

        public static AppEvent Empty 
            => new AppEvent(string.Empty, default(EmptyPayload));

        readonly struct EmptyPayload : ITextual<EmptyPayload>, IEmptyPayload
        {            
            public string Format() 
                => string.Empty;

            public override string ToString() 
                => Format();
        }

        interface IEmptyPayload {}
    }


}