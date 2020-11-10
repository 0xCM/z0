//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct Packages
    {
        public readonly struct dnlib : IPackage<dnlib>
        {
            public VersionExpresson Version => "";
        }

        public readonly struct ICSharpCode
        {
            public readonly struct Decompiler  : IScopedPackage<Decompiler, ICSharpCode>
            {
                public VersionExpresson Version => "";
            }
        }
    }
}