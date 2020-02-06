//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Reflection;
    using System.Linq;

    using static zfunc;

    public sealed class AsmContext : OpContext<AsmContext>, IAsmContext
    {   
        static int LastId = 0;

        public static IAsmContext New()
            => New(ClrMetadataIndex.Empty, DataResourceIndex.Empty, AsmFormatConfig.Default);

        public static IAsmContext New(IClrIndex clrindex, DataResourceIndex resources,  AsmFormatConfig format)             
            => new AsmContext(clrindex, resources, format, CilFormatConfig.Default, Rng.WyHash64(Seed64.Seed10));
        
        public static IAsmContext New(IClrIndex clrindex, DataResourceIndex resources)             
            => new AsmContext(clrindex, resources, AsmFormatConfig.Default, CilFormatConfig.Default, Rng.WyHash64(Seed64.Seed10));

        AsmContext(IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat, IPolyrand random)
            : base(random)            
        {
            this.Data = ContextData.Create(clrIndex, resources,format,cilFormat);
            this.ContextId = Interlocked.Increment(ref LastId);
        }

        AsmContext(int parent, ContextData data, IPolyrand random)
            : base(random)            
        {
            this.ParentId = parent;
            this.Data = data;
            this.ContextId = Interlocked.Increment(ref LastId);
        }

        ContextData Data;

        public int ContextId {get;}

        public int ParentId {get;}

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

        public IAsmContext WithClrIndex(Assembly src)
        {
            var copy = Replicate();            
            copy.Data.WithClrIndex(ClrMetadataIndex.Create(src.Modules.ToArray()));
            return copy;
        }

        AsmContext Replicate()
            => new AsmContext(ContextId, Data,Random);

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

            public ContextData WithClrIndex(IClrIndex index)
            {
                this.ClrIndex = index;
                return this;
            }                

        }
    }   
}