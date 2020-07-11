//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    
    public readonly struct ArchiveServices : TArchiveServices
    {
        public static TArchiveServices Services 
            => default(ArchiveServices);
    }
}