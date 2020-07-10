//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public struct ModuleMetadata
    {
        public readonly MetadataToken Id;

        [MethodImpl(Inline)]
        public ModuleMetadata(MetadataToken id)
        {
            Id = id;
        }        
    }        
}