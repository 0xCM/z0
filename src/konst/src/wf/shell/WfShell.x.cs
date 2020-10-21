//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.WfShellX, true)]
    public static partial class XWFShell
    {
        [MethodImpl(Inline), Op]
        public static bool Babble(this LogLevel src)
            => src == LogLevel.Babble;
    }
}