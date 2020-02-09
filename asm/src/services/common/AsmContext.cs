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

        /// <summary>
        /// Creates a new context with selected assemblies
        /// </summary>
        /// <param name="assemblies">The assemblies to share with the context</param>
        public static IAsmContext New(params IAssemblyDesignator[] assemblies)
            => New(AssemblyComposition.Define(assemblies));

        /// <summary>
        /// Creates a new context with an assembly composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        public static IAsmContext New(IAssemblyComposition assemblies)
            => new AsmContext(assemblies, ClrMetadataIndex.Empty, DataResourceIndex.Empty, AsmFormatConfig.Default, CilFormatConfig.Default, Rng.WyHash64(Seed64.Seed10));

        /// <summary>
        /// Creates an empty context
        /// </summary>
        public static IAsmContext New()
            => New(ClrMetadataIndex.Empty, DataResourceIndex.Empty, AsmFormatConfig.Default);

        public static IAsmContext New(IClrIndex clrindex, DataResourceIndex resources,  AsmFormatConfig format)             
            => new AsmContext(AssemblyComposition.Empty, clrindex, resources, format, CilFormatConfig.Default, Rng.WyHash64(Seed64.Seed10));
        
        public static IAsmContext New(IClrIndex clrindex, DataResourceIndex resources)             
            => new AsmContext(AssemblyComposition.Empty, clrindex, resources, AsmFormatConfig.Default, CilFormatConfig.Default, Rng.WyHash64(Seed64.Seed10));

        AsmContext(IAssemblyComposition assemblies, IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat, IPolyrand random)
            : base(random)            
        {
            this.Data = AsmContextData.Create(assemblies ?? AssemblyComposition.Empty, clrIndex, resources,format,cilFormat);
            this.ContextId = Interlocked.Increment(ref LastId);
        }

        AsmContext(int parentid, AsmContextData data, IPolyrand random)
            : base(random)            
        {
            this.ParentId = parentid;
            this.Data = data;
            this.ContextId = Interlocked.Increment(ref LastId);
        }

        AsmContextData Data;
        
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
        
        public IAssemblyComposition Assemblies
            => Data.Assemblies;

        public IAsmContext WithFormat(AsmFormatConfig config)
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
            => new AsmContext(ContextId, Data ,Random);
    }   
}