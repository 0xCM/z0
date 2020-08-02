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

    public readonly struct PartWfConfig
    {    
        public readonly WfContext Context;
        
        public readonly ArchiveConfig Source;

        public readonly ArchiveConfig Target;

        public readonly PartId[] Parts;        

        public readonly string[] Args;
        
        [MethodImpl(Inline)]
        public PartWfConfig(WfContext context, string[] args, ArchiveConfig src, ArchiveConfig dst, PartId[] parts)
        {
            Context = context;
            Args = args;
            Source = src;
            Target = dst;
            Parts = parts;
        }    
    }
}