//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppStatusEvent : ITextual, IAppEvent<AppStatusEvent>
    {
        [MethodImpl(Inline)]
        public static AppStatusEvent Create(string description, AppMsgColor flair = AppMsgColor.Magenta)
            => new AppStatusEvent(description, flair);        
        
        public string Description {get;}
        
        public AppMsgColor Flair {get;}
                
        [MethodImpl(Inline)]
        public AppStatusEvent(string name, AppMsgColor flair)
        {
            Description = name;
            Flair = flair;            
        }
        public string Format()
            => Description;

        public override string ToString()
            => Format();
    }
}