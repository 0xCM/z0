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
        public static AppErrorEvent Empty => new AppErrorEvent(new Exception("empty"));
        
        public Exception Payload {get;}
        
        [MethodImpl(Inline)]
        public static implicit operator AppErrorEvent(Exception e)
            => Define(e);
         
        [MethodImpl(Inline)]
        public static AppErrorEvent Define(Exception e)
            => new AppErrorEvent(e);         

        [MethodImpl(Inline)]
        internal AppErrorEvent(Exception error)
        {
            this.Payload = error;
        }
                   
        public bool IsEmpty  => Payload == null || Payload.Message == Empty.Payload.Message;

        public string Description => IsEmpty ? string.Empty : Payload.Message;

        public AppErrorEvent Zero => Empty;        

        public AppMsgColor Flair => AppMsgColor.Red;
    }
}