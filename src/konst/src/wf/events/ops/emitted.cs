//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static Render;
    using static AB;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op]
        public static EmittedFile emitted(WfStepId step, FS.FilePath path, CorrelationToken ct)
            => new EmittedFile(step, path, ct);
    }
}