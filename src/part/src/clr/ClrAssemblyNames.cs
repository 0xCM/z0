//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    [ApiHost]
    public readonly struct ClrAssemblyNames
    {
        [MethodImpl(Inline), Op]
        public static ClrAssemblyName from(AssemblyName src)
            => new ClrAssemblyName(src);

        [MethodImpl(Inline), Op]
        public static ClrAssemblyName from(Assembly src)
            => new ClrAssemblyName(src);

        [MethodImpl(Inline), Op]
        public static ClrAssemblyVersion version(AssemblyName src)
        {
            var version = src.Version;
            var dst = new ClrAssemblyVersion(version.Major, version.Minor, version.Build, version.Revision);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static string format(AssemblyName src, AssemblyNameKind kind = AssemblyNameKind.Simple)
            => kind == AssemblyNameKind.Full ? src.FullName : src.Name;
    }
}