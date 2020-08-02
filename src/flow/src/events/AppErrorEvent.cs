//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
            
    public readonly struct WfError : IWfEvent<WfError>
    {                
        public WfEventId Id => WfEventId.define(nameof(WfError));
        public readonly AppMsgData Description;
        
        [MethodImpl(Inline)]
        public static implicit operator WfError(Exception e)
            => new WfError(e);
         
        [MethodImpl(Inline)]
        public WfError(AppMsg description)
            => Description = description.Data;

        [MethodImpl(Inline)]
        public WfError(AppMsgData description)
            => Description = description;

        [MethodImpl(Inline)]
        public WfError(Exception e)
            => Description = AppMsg.NoCaller(e,AppMsgKind.Error).Data;

        [MethodImpl(Inline)]
        public WfError(string description)
            => Description = AppMsg.NoCaller(description, AppMsgKind.Error).Data;

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
        
        public WfError Zero 
            => Empty;
        
        public AppMsgColor Flair 
            => AppMsgColor.Red;
        
        public AppMsg Message
            => new AppMsg(Description);

        public string Format()
            => Message.Format();

        public override string ToString()
            => Format();
            
        public static WfError Empty 
            => new WfError(AppMsgData.Empty);
    }
}