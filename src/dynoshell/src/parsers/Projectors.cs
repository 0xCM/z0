//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.Build.Construction;

    using MsBC = Microsoft.Build.Construction;

    using static Konst;
    using static z;


    public delegate ref T RefProjector<S,T>(in T src, ref T dst);

    public readonly struct Projectors
    {
        public static ref SlnProjectConfig project(in ProjectConfigurationInSolution src, ref SlnProjectConfig dst)
        {
            dst.Build = src.IncludeInBuild;
            dst.FullName = src.FullName;
            dst.Name = src.ConfigurationName;
            dst.Platform = src.PlatformName;
            return ref dst;
        }
    }
}