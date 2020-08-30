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
        [MethodImpl(Inline)]
        public static ref readonly RelationAttributes<S,T> include<S,T>(in RelationAttributes<S,T> dst, uint index, string name, variant value)
        {
            dst[index] = attribute(name,value, directed<S,T>());
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly RelationAttributes<S,T> include<A,S,T>(in RelationAttributes<S,T> dst, uint index, string name, A value)
            where A : unmanaged
        {
            dst[index] = attribute(name,value, directed<S,T>());
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly RelationAttributes include(in RelationAttributes dst, uint index, DirectedRelation r, string name, variant value)
        {
            dst[index] = attribute(r,name,value);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly RelationAttributes include<A>(in RelationAttributes dst, uint index, DirectedRelation r, string name, A value)
            where A : unmanaged
        {
            dst[index] = attribute(r,name,value);
            return ref dst;
        }
    }
}