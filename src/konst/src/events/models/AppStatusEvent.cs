//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppStatusEvent : IAppEvent<AppStatusEvent>
    {
        [MethodImpl(Inline)]
        public static AppStatusEvent create(string description, AppMsgColor flair = AppMsgColor.Magenta)
            => new AppStatusEvent(description, flair);        
        
        public string Description {get;}
        
        public AppMsgColor Flair {get;}
                
        [MethodImpl(Inline)]
        public AppStatusEvent(string description, AppMsgColor flair)
        {
            Description = description;
            Flair = flair;            
        }
        public string Format()
            => Description;

        public override string ToString()
            => Format();
    }
}