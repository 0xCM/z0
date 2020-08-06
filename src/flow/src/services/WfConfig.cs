//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct WfConfig
    {    
        public readonly string[] Args;

        public readonly PartId[] Parts;        

        public readonly ArchiveConfig Source;

        public readonly ArchiveConfig Target;
        
        [MethodImpl(Inline)]
        public WfConfig(string[] args, ArchiveConfig src, ArchiveConfig dst, PartId[] parts)
        {
            Args = args;
            Source = src;
            Target = dst;
            Parts = parts;
        }    
    }
}