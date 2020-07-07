//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static BufferSeqId;

    using Z0.Asm;

    partial struct Evaluate
    {
        [MethodImpl(Inline), Op]
        public static IEvalDispatcher dispatcher(IPolyrand random, IAppMsgSink sink, uint bufferSize)
            => new EvalDispatcher(random, sink, bufferSize);
    }
}
