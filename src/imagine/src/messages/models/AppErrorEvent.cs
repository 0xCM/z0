//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
            
    public readonly struct AppErrorEvent : IAppEvent<AppErrorEvent>
    {                
        public readonly Exception Error;
        
        [MethodImpl(Inline)]
        public static implicit operator AppErrorEvent(Exception e)
            => Define(e);
         
        [MethodImpl(Inline)]
        public static AppErrorEvent Define(Exception e)
            => new AppErrorEvent(e);         

        [MethodImpl(Inline)]
        public AppErrorEvent(Exception error)
        {
            Error = error;
        }
                   
        public bool IsEmpty 
            => Error == null || Error.Message == Empty.Error.Message;

        public string Description 
            => IsEmpty ? string.Empty : Error.Message;

        public AppErrorEvent Zero 
            => Empty;
        
        public AppMsgColor Flair 
            => AppMsgColor.Red;

        public static AppErrorEvent Empty 
            => new AppErrorEvent(new Exception("empty"));
    }
}