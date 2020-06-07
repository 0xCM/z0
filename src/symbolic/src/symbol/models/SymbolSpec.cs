//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    public readonly struct SymbolSpec : ISymbolSpec
    {
        public ushort SymWidth {get;}

        public ushort SegWidth {get;}

        public ushort Capacity {get;}

        public MetadataToken SegDomain {get;}

        public MetadataToken SymDomain {get;}


        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, MetadataToken segdomain, MetadataToken symdomain)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            Capacity = (ushort)(SegWidth/SymWidth);
            SegDomain = segdomain;
            SymDomain = symdomain;            
        }        
    }
}