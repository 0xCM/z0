//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppEvent : ITextual, IAppEvent<AppEvent>
    {
        [MethodImpl(Inline)]
        public static AppEvent Create(StringRef id, string description, AppMsgColor flair = AppMsgColor.Magenta)
            => new AppEvent(id, description, flair);

        [MethodImpl(Inline)]
        public static AppEvent<T> Create<T>(string description, T content, AppMsgColor flair = AppMsgColor.Magenta)
            where T : struct
                => new AppEvent<T>(description, content, flair);
        
        public StringRef Id {get;}
        
        public string Description {get;}
        
        public AppMsgColor Flair {get;}        

        [MethodImpl(Inline)]
        public AppEvent(StringRef id, string descripton, AppMsgColor flair)
        {
            Id = id;
            Description = descripton;
            Flair = flair;
        }

        public string Format()
            => string.Concat(Id, CharText.Colon, CharText.Space, Description);

        public override string ToString()
            => Format();
    }
}