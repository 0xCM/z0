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

    partial struct ArtifactRelations
    {
        [MethodImpl(Inline), Op]
        public static ref readonly RelationAttributes include(in RelationAttributes dst, uint index, ArtifactRelation r, string name, variant value)
        {
            dst[index] = attribute(r,name,value);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly RelationAttributes include<A>(in RelationAttributes dst, uint index, ArtifactRelation r, string name, A value)
            where A : unmanaged
        {
            dst[index] = attribute(r,name,value);
            return ref dst;
        }
    }
}