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

    using A = ClrArtifacts;
    using S = System;
    using R = System.Reflection;
    using api = ClrArtifactApi;

    [ApiHost("artifacts.clr.service")]
    public readonly partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<A.Type> Types(R.Assembly src)
            => api.types(src);
    }
}