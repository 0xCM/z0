//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static AsmServiceMessages;
    using static Root;

    readonly struct AsmAssemblyCapture : IAsmAssemblyCapture
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static AsmAssemblyCapture Create(IAsmContext context)
            => new AsmAssemblyCapture(context);

        [MethodImpl(Inline)]
        AsmAssemblyCapture(IAsmContext context)
        {
            this.Context = context;
        }

        public Option<AsmOpExtract> Capture(AssemblyId src)
        {
            return default;
        }
    }
}