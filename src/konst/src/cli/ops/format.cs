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

    partial struct Cli
    {
        [MethodImpl(Inline), Op]
        public static string format(in CliArtifactRef src)
            => text.format(RP.PSx3, src.Kind, src.Key, src.Name);
    }
}