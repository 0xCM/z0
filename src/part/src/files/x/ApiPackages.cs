//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XFs
    {
        [Op]
        public static ApiPackages ApiPackages(this IEnvPaths src)
            => src.PackageRoot();
    }
}