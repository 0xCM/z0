//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public readonly struct EnumIdentifiers
    {
        readonly IWfShell Wf;

        readonly Dictionary<ClrArtifactKey,Type> Index;

        public static EnumIdentifiers create(IWfShell wf)
            => new EnumIdentifiers(wf, wf.Api.Catalogs.EnumTypes);

        EnumIdentifiers(IWfShell wf, Type[] enums)
        {
            Wf = wf;
            Index = enums.Select(x => ((ClrArtifactKey)x.MetadataToken, x)).ToDictionary();
        }
    }
}