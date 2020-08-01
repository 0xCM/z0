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
    using static z;

    public readonly struct StepExecuted : IWorkflowEvent<StepExecuted>
    {
        const string DefaultPattern = "{0}: executing";

        const string DetailPattern = "{0}: {1}";

        public readonly WfEventId Id {get;}

        public readonly string Detail;

        public AppMsgColor Flair => AppMsgColor.Cyan;

        [MethodImpl(Inline)]
        public StepExecuted(string worker, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(worker, ct ?? CorrelationToken.create(), now());
            Detail = EmptyString;
        }

        [MethodImpl(Inline)]
        public StepExecuted(string worker, string detail, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(worker, ct ?? CorrelationToken.create(), now());
            Detail = detail;
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