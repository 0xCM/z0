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
    using static ArtifactModel;

    partial struct Needs
    {
        // [MethodImpl(Inline), Op]
        // public static ref readonly NeedAttributes include(in NeedAttributes dst, uint index, ArtifactRelation r, string name, variant value)
        // {
        //     dst[index] = attribute(r,name,value);
        //     return ref dst;
        // }

        // [MethodImpl(Inline), Op, Closures(AllNumeric)]
        // public static ref readonly NeedAttributes include<A>(in NeedAttributes dst, uint index, ArtifactRelation r, string name, A value)
        //     where A : unmanaged
        // {
        //     dst[index] = attribute(r,name,value);
        //     return ref dst;
        // }
    }
}