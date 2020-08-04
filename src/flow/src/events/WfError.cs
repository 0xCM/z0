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
            Id = wfid(nameof(WfError), ct);
            Description = description.Data;
        }

        [MethodImpl(Inline)]
        public WfError(string worker, Exception e, CorrelationToken ct)
        {
            Id = wfid(nameof(WfError), ct);
            Description = AppMsg.NoCaller(e, AppMsgKind.Error).Data;
        }

        [MethodImpl(Inline)]
        public WfError(string worker, object content, CorrelationToken ct)
        {
            Id = wfid(nameof(WfError), ct);
            Description = AppMsg.NoCaller(content, AppMsgKind.Error).Data;
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
        
        public AppMsgColor Flair 
            => AppMsgColor.Red;
        
        public AppMsg Message
            => new AppMsg(Description);

        public string Format()
            => Message.Format();            
    }
}