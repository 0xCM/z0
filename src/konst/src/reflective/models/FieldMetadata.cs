//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public struct FieldMetadata
    {
        public readonly MetadataToken Id;
    
        [MethodImpl(Inline)]
        public FieldMetadata(MetadataToken id)
        {
            Id = id;
        }    
    }
}