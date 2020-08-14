//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
            
    public readonly struct AppError : IAppEvent<AppError, AppMsgData>
    {                
        public EventId Id {get;}
        
        public AppMsgData Data {get;}       
                         
        public MessageFlair Flair 
            => MessageFlair.Red;
        
        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();            
    }
}