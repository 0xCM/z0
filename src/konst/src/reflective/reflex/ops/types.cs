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

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static ArtifactIdentity identity(in Type src)
            => src.MetadataToken;

        [MethodImpl(Inline), Op]
        public static KeyedValues<ArtifactIdentity,Type> TypeIndex(Assembly src)
        {
            var types = src.GetTypes();
            var count = types.Length;
            var dst = sys.alloc<KeyedValue<ArtifactIdentity,Type>>(count);
            var index = new KeyedValues<ArtifactIdentity,Type>(types, identity, dst);
            return index;
        }

        [MethodImpl(Inline), Op]
        public static Type type(in Indexed<Type>  src, ArtifactIdentity id)       
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