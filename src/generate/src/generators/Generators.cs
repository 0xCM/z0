//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using static Root;

    public readonly struct Generators 
    {
        public static BitSetGenerator[] BitSets => new BitSetGenerator[]{
            DuetGenerator.Service,
            TriadGenerator.Service,
            QuartetGenerator.Service,
            QuintetGenerator.Service,
            OctetGenerator.Service,
        };
    }
}