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
    using static z;

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static ClrArtifactKey identity(in Type src)
            => src.MetadataToken;

        [MethodImpl(Inline), Op]
        public static Type[] types(Assembly src)
            => src.GetTypes();

        [MethodImpl(Inline), Op]
        public static Type type(in Index<Type>  src, ClrArtifactKey id)
        {
            for(var i=0; i<src.Length; i++)
            {
                var candidate = src[i];
                if(candidate.MetadataToken == id)
                    return candidate;
            }
            return EmptyVessels.EmptyStruct;
        }
    }
}