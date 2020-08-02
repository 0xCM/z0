//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Flow;
    using static z;

    public readonly struct WfStepFinished : IWfEvent<WfStepFinished>
    {
        const string DefaultPattern = IdMarker + "Completed";

        const string DetailPattern = IdMarker + "Completed - {1}";

        public readonly WfEventId Id {get;}

        public readonly string Detail;

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepFinished(string worker, CorrelationToken? ct = null)
        {
            Id = wfid(worker, ct);
            Detail = EmptyString;
            Flair = AppMsgColor.Cyan;
        }

        [MethodImpl(Inline)]
        public WfStepFinished(string worker, string detail, CorrelationToken? ct = null)
        {
            Id = wfid(worker, ct);
            Detail = detail;
            Flair = AppMsgColor.Cyan;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.nonempty(Detail) 
            ? text.format(DetailPattern, Id, Detail)
            : text.format(DefaultPattern, Id);        
        
        public string Description
            => Format();

        public override string ToString()
            => Format();
    }
}