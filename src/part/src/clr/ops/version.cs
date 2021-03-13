//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ClrAssemblyVersion version(AssemblyName src)
        {
            var version = src.Version;
            var dst = new ClrAssemblyVersion(version.Major, version.Minor, version.Build, version.Revision);
            return dst;
        }
    }
}