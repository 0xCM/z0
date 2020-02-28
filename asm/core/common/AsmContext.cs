//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Reflection;

    using static Root;

    public sealed class AsmContext : IAsmContext 
    {   
        /// <summary>
        /// Creates a new context with selected assemblies
        /// </summary>
        /// <param name="assemblies">The assemblies to share with the context</param>
        public static IAsmContext New(params IAssemblyResolution[] assemblies)
            => New(assemblies.Assemble());

        /// <summary>
        /// Creates a new context with an assembly composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        public static IAsmContext New(IAssemblyComposition assemblies)
            => new AsmContext(assemblies, default(EmptyClrIndex), DataResourceIndex.Empty, AsmFormatConfig.Default, CilFormatConfig.Default);

        public static IAsmContext New(IClrIndex clrindex, DataResourceIndex resources,  AsmFormatConfig format)             
            => new AsmContext(AssemblyComposition.Empty, clrindex, resources, format, CilFormatConfig.Default);
        
        public static IAsmContext New(IClrIndex clrindex, DataResourceIndex resources)             
            => new AsmContext(AssemblyComposition.Empty, clrindex, resources, AsmFormatConfig.Default, CilFormatConfig.Default);

        [MethodImpl(Inline)]
        static AsmContext New(AsmContextData data)
            => new AsmContext(Context.NextId(), data);

        AsmContext(IAssemblyComposition assemblies, IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat)
        {
            this.State = AsmContextData.Create(assemblies ?? AssemblyComposition.Empty, clrIndex, resources,format,cilFormat);
            this.Identity = Context.NextId();
        }

        AsmContext(int id, AsmContextData data)
        {
            this.State = data;
            this.Identity = id;
        }

        readonly AsmContextData State;
        
        public int Identity {get;}

        public IClrIndex ClrIndex 
            => State.ClrIndex;
        
        public AsmFormatConfig AsmFormat 
            => State.AsmFormat;

        public CilFormatConfig CilFormat
            => State.CilFormat;
        
        public IAssemblyComposition Compostion
            => State.Assemblies;

        public IAsmContext WithFormat(AsmFormatConfig config)
            => New(AsmContextData.Create(Compostion, ClrIndex, State.Resources, config, CilFormat));            
    }   
}