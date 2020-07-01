//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
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