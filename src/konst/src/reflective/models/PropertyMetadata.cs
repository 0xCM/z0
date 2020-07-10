//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public struct PropertyMetadata
    {
        public readonly MetadataToken Id;

        [MethodImpl(Inline)]
        public PropertyMetadata(MetadataToken id)
        {
            Id = id;
        }
    }    
}