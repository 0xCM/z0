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

    public struct ApiSurface
    {
        ApiSurfaceRoot Root;

        Type[] Interfaces;

        Type[] Hosts;

        Type[] DataTypes;

        MethodInfo[] StatelessApi;

        Type[] Services;
    }
}