//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public struct TypeMetadata : IReflected<TypeMetadata>
    {        
        [MethodImpl(Inline)]
        public TypeMetadata(MetadataToken id)
        {
            Id = id;
        }
        
        public MetadataToken Id {get;}
    }
}