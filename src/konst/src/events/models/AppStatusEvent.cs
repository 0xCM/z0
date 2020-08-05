//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppStatus : IAppEvent<AppStatus, string>
    {
        [MethodImpl(Inline)]
        public static AppStatus create(string data, AppMsgColor flair = AppMsgColor.Magenta)
            => new AppStatus(data, flair);        
        
        public string Data {get;}
        
        public AppMsgColor Flair {get;}
                
        [MethodImpl(Inline)]
        public AppStatus(string data, AppMsgColor flair)
        {
            Data = data;
            Flair = flair;            
        }
        public string Format()
            => Data;

        public override string ToString()
            => Format();
    }
}