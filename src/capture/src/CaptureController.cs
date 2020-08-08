//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CaptureController
    {
        public const string ActorName = nameof(CaptureControl);        

        [MethodImpl(Inline)]
        public static CaptureControl create(IAppContext root, CorrelationToken ct, WfConfig config)
            => new CaptureControl(root, ct, config);
    }
}