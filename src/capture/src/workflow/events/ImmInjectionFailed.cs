//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [Event]
    public readonly struct ImmInjectionFailed : IWfEvent<ImmInjectionFailed>
    {
        public const string EventName = nameof(ImmInjectionFailed);
        public WfEventId EventId {get;}

        public WfPayload<MethodInfo> Method {get;}

        public FlairKind Flair
            => FlairKind.Error;

        [MethodImpl(Inline)]
        public ImmInjectionFailed(WfStepId step, MethodInfo method, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            Method = method;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId,Method);
    }
}