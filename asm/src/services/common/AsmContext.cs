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
            => new AsmContext(clrindex, resources, format, CilFormatConfig.Default, Rng.WyHash64(Seed64.Seed10));
        
        AsmContext(IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat, IPolyrand random)
            : base(random)            
        {
            this.Data = ContextData.Create(clrIndex, resources,format,cilFormat);
        }

        AsmContext(ContextData data, IPolyrand random)
            : base(random)            
        {
            this.Data = data;
        }

        ContextData Data;

        public IClrIndex ClrIndex 
            => Data.ClrIndex;

        public DataResourceIndex Resources
            => Data.Resources;
        
        public AsmFormatConfig AsmFormat 
            => Data.AsmFormat;

        public CilFormatConfig CilFormat
            => Data.CilFormat;

        public IAsmContext WithFormat(AsmFormatConfig config)
        {
            var copy = Replicate();
            Data = copy.Data.WithFormat(config);
            return copy;
        }

        public IAsmContext WithFormat(CilFormatConfig config)
        {
            var copy = Replicate();
            Data = copy.Data.WithFormat(config);
            return copy;
        }

        public IAsmContext WithEmptyClrIndex()
        {
            var copy = Replicate();
            copy.Data = copy.Data.WithEmptyClrIndex();            
            return copy;
        }

        AsmContext Replicate()
            => new AsmContext(Data,Random);

        struct ContextData
        {
            public static ContextData Create(IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat)
                => new ContextData(clrIndex, resources, format, cilFormat);

            ContextData(IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat)
            {
                this.ClrIndex = clrIndex;
                this.Resources = resources;
                this.AsmFormat = format;
                this.CilFormat = cilFormat;
            }

            public IClrIndex ClrIndex {get; set;}

            public DataResourceIndex Resources {get;set;}
            
            public AsmFormatConfig AsmFormat {get;set;}

            public CilFormatConfig CilFormat {get;set;}

            public ContextData WithFormat(AsmFormatConfig config)
            {
                this.AsmFormat = config;
                return this;
            }                

            public ContextData WithFormat(CilFormatConfig config)
            {
                this.CilFormat = config;
                return this;
            }

            public ContextData WithEmptyClrIndex()
            {
                this.ClrIndex = ClrMetadataIndex.Empty;
                return this;
            }                
        }
    }   
}