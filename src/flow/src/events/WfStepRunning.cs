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

    public readonly struct WfStepRunning : IWfEvent<WfStepRunning>
    {        
        const string DefaultPattern = "{0}: executing";

        const string DetailPattern = "{0}: {1}";

        public WfEventId Id {get;}

        public readonly string Detail;

        [MethodImpl(Inline)]
        public WfStepRunning(string worker, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(worker, ct ?? CorrelationToken.create(), now());
            Detail = EmptyString;
            Detail = EmptyString;
        }

        [MethodImpl(Inline)]
        public WfStepRunning(string worker, string detail, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(worker, ct ?? CorrelationToken.create(), now());
            Detail = EmptyString;
            Detail = detail;
        }

        public AppMsgColor Flair 
            => AppMsgColor.Magenta;

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