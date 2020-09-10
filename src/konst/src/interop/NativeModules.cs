//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct NativeModules
    {
        [MethodImpl(Inline), Op]
        public static Outcome<DacLib.Module> dac(FS.FilePath src)
            => DacLib.Module.create(src);
    }
}