//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
            
    [Event]
    public readonly struct WfError : IWfEvent<WfError>
    {                
        public WfEventId Id {get;}
        
        public readonly AppMsgData Description;
        
        [MethodImpl(Inline)]
        public WfError(AppMsg description, CorrelationToken? ct = null)
        {
            Description = description.Data;
            Id = wfid(nameof(WfError), ct);
        }

        [MethodImpl(Inline)]
        public WfError(AppMsgData description, CorrelationToken? ct = null)
        {
            Description = description;
            Id = wfid(nameof(WfError), ct);
        }

        [MethodImpl(Inline)]
        public WfError(Exception e, CorrelationToken? ct = null)
        {
            Description = AppMsg.NoCaller(e,AppMsgKind.Error).Data;
            Id = wfid(nameof(WfError), ct);
        }

        [MethodImpl(Inline)]
        public WfError(string description, CorrelationToken? ct = null)
        {
            Description = AppMsg.NoCaller(description, AppMsgKind.Error).Data;
            Id = wfid(nameof(WfError), ct);
        }

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