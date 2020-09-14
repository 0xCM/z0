//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost("artifacts.api")]
    public readonly struct Artifacts
    {
        [MethodImpl(Inline), Op]
        public static ClrArtifactServices clr()
            => default;
    }
}