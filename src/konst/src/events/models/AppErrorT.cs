//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
            
    public readonly struct AppError<T> : IAppEvent<AppError<T>, T>
    {                
        public EventId Id {get;}
        
        public T Data {get;}       

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public AppError(EventId id, T data)
        {
            Id = id;
            Data = data;
            Flair = MessageFlair.Red;
        }
                
        public string Format()
            => text.format("{0} | {1}", Id, Data);                    
    }
}