//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct SymbolSpec : ISymbolSpec
    {
        public ushort SymWidth {get;}

        public ushort SegWidth {get;}

        public ushort Capacity {get;}

        public ArtifactIdentity SegDomain {get;}

        public ArtifactIdentity SymDomain {get;}


        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ArtifactIdentity segdomain, ArtifactIdentity symdomain)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            Capacity = (ushort)(SegWidth/SymWidth);
            SegDomain = segdomain;
            SymDomain = symdomain;            
        }        
    }
}