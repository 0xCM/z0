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
        public readonly AppMsgData Description;
        
        [MethodImpl(Inline)]
        public static implicit operator AppErrorEvent(Exception e)
            => new AppErrorEvent(e);
         
        [MethodImpl(Inline)]
        public AppErrorEvent(AppMsg description)
            => Description = description;

        [MethodImpl(Inline)]
        public AppErrorEvent(AppMsgData description)
            => Description = description;

        [MethodImpl(Inline)]
        public AppErrorEvent(Exception e)
            => Description = AppMsg.NoCaller(e,AppMsgKind.Error);

        [MethodImpl(Inline)]
        public AppErrorEvent(string description)
            => Description = AppMsg.NoCaller(description, AppMsgKind.Error);

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Description.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Description.IsNonEmpty;
        }
        
        public AppErrorEvent Zero 
            => Empty;
        
        public AppMsgColor Flair 
            => AppMsgColor.Red;
        
        public AppMsg Message
            => Description;

        public string Format()
            => Message.Format();

        public override string ToString()
            => Format();
            
        public static AppErrorEvent Empty 
            => new AppErrorEvent(AppMsgData.Empty);
    }
}