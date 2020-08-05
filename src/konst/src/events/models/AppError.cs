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
         
        [MethodImpl(Inline)]
        public AppError(EventId id, AppMsg description)
        {
            Id = id;
            Data = description.Data;
        }

        [MethodImpl(Inline)]
        public AppError(EventId id, AppMsgData data)
        {
            Id = id;
            Data = data;
        }

        [MethodImpl(Inline)]
        public AppError(EventId id, Exception e)
        {
            Id = id;
            Data = AppMsgData.untyped(e, "{0}", AppMsgKind.Error, AppMsgColor.Red, AppMsgSource.create());
        }

        [MethodImpl(Inline)]
        public AppError(EventId id, string description)
        {
            Id = id;
            Data = AppMsgData.untyped(description, "{0}", AppMsgKind.Error, AppMsgColor.Red, AppMsgSource.create());
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }
        
        public AppError Zero 
            => Empty;
        
        public AppMsgColor Flair 
            => AppMsgColor.Red;
        
        public AppMsg Message
            => new AppMsg(Data);

        public string Format()
            => Message.Format();

        public override string ToString()
            => Format();
            
        public static AppError Empty 
            => default;
    }
}