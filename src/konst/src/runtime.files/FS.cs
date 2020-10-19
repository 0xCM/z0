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

    [ApiHost(HostName)]
    public readonly partial struct FS
    {
        public const string HostName = "fs";
    }

    [ApiHost(HostName)]
    public static partial class XTendFS
    {
        public const string HostName = FS.HostName + AsciCharText.Dot + AsciCharText.x;
    }
}