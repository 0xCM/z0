//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public struct AssemblyMetadata
    {
        readonly public MetadataToken Id;

        [MethodImpl(Inline)]
        public AssemblyMetadata(MetadataToken id)
        {
            Id = id;
        }
    }        
}