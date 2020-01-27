//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public sealed class AsmContext : OpContext<AsmContext>, IAsmContext
    {   
        public static IAsmContext Define(IClrIndex clrindex, DataResourceIndex resources,  AsmFormatConfig format)             
            => new AsmContext(clrindex, resources, format, Rng.WyHash64(Seed64.Seed10));
        
        AsmContext(IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, IPolyrand random)
            : base(random)            
        {
            this.ClrIndex = clrIndex;
            this.Resources = resources;
            this.AsmFormat = format;
        }

        public IClrIndex ClrIndex {get;}

        public DataResourceIndex Resources {get;}
        
        public AsmFormatConfig AsmFormat {get;}

        public IAsmContext WithFormat(AsmFormatConfig config)
            => new AsmContext(ClrIndex, Resources, config, Random);

        public IAsmContext WithEmptyClrIndex()
            => new AsmContext(ClrMetadataIndex.Empty, Resources, AsmFormat, Random);

    }   
}