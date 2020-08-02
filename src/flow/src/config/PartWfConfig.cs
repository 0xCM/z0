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

        public readonly IPart[] Parts;        
        
        [MethodImpl(Inline)]
        public PartWfConfig(WfContext context, ArchiveConfig src, ArchiveConfig dst, IPart[] parts)
        {
            Context = context;
            Source = src;
            Target = dst;
            Parts = parts;
        }    
    }
}