//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public static class AsmProcessServices
    {
        public static IAsmProcessEmitter Emitter(IAsmContext context)
            => AsmProcessEmitter.Create(context);

        public static IAsmProcessCapture Capture(IAsmContext context)
            => ProcessCapture.Create(context);

    }
}
