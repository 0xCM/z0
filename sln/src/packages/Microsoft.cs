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

    partial struct Packages
    {
        public readonly struct Microsoft
        {
            public readonly struct Build : IScoped<Microsoft>
            {
                public readonly struct Runtime : IPackage<Runtime>, IScoped<Build>
                {
                    public VersionExpresson Version => "";
                }
            }

            public readonly struct Extensions : IScoped<Microsoft>
            {
                public VersionExpresson Version => "";
            }

            public readonly struct CodeAnalysis : IScopedPackage<CodeAnalysis,Microsoft>
            {
                public VersionExpresson Version => "3.8.0-5.final";

                public readonly struct Common : IScopedPackage<Common,CodeAnalysis>
                {
                    public VersionExpresson Version => "";
                }

                public readonly struct Scripting : IScopedPackage<Scripting,CodeAnalysis>
                {
                    public VersionExpresson Version => "";
                }
            }
        }
    }
}