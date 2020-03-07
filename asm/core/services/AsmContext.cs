//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Z0.Asm;

    using static Root;


    public sealed class AsmContext : IAsmContext 
    {               
        /// <summary>
        /// Creates a rooted context with selected assemblies
        /// </summary>
        /// <param name="root">The root context</param>
        /// <param name="resolutions">The assemblies to share with the context</param>
        public static IAsmContext Rooted(IContext root, params IAssemblyResolution[] resolutions)
            => new AsmContext(root, resolutions.Assemble(), default(EmptyClrIndex), DataResourceIndex.Empty, AsmFormatConfig.New, CilFormatConfig.Default);

        /// <summary>
        /// Creates a rooted context with a specified composition
        /// </summary>
        /// <param name="root">The root context</param>
        /// <param name="assemblies">The composition</param>
        public static IAsmContext Rooted(IContext root, IAssemblyComposition assemblies)
            => new AsmContext(root, assemblies, default(EmptyClrIndex), DataResourceIndex.Empty, AsmFormatConfig.New, CilFormatConfig.Default);

        /// <summary>
        /// Creates a rooted context with specified indexes
        /// </summary>
        /// <param name="root">The root context</param>
        /// <param name="clrindex">The clr index</param>
        /// <param name="resources">The resource index</param>
        public static IAsmContext Rooted(IContext root, IClrIndexer clrindex, DataResourceIndex resources)             
            => new AsmContext(root, AssemblyComposition.Empty, clrindex, resources, AsmFormatConfig.New, CilFormatConfig.Default);

        /// <summary>
        /// Creates a rooted context with specified indexes and format configuration
        /// </summary>
        /// <param name="root">The root context</param>
        /// <param name="clrindex">The clr index</param>
        /// <param name="resources">The resource index</param>
        /// <param name="format">The context format configuration</param>
        public static IAsmContext Rooted(IContext root, IClrIndexer clrindex, DataResourceIndex resources,  AsmFormatConfig format)             
            => new AsmContext(root, AssemblyComposition.Empty, clrindex, resources, format, CilFormatConfig.Default);

        /// <summary>
        /// Creates a base context with a specified composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        public static IAsmContext New(IAssemblyComposition assemblies)
            => new AsmContext(assemblies, default(EmptyClrIndex), DataResourceIndex.Empty, AsmFormatConfig.New, CilFormatConfig.Default);

        /// <summary>
        /// Creates a base context with selected assemblies
        /// </summary>
        /// <param name="resolutions">The assemblies to share with the context</param>
        public static IAsmContext New(params IAssemblyResolution[] resolutions)
            => new AsmContext(resolutions.Assemble(), default(EmptyClrIndex), DataResourceIndex.Empty, AsmFormatConfig.New, CilFormatConfig.Default);

        /// <summary>
        /// Creates a base context with specified indexes and format configuration
        /// </summary>
        /// <param name="clrindex">The clr index</param>
        /// <param name="resources">The resource index</param>
        /// <param name="format">The context format configuration</param>
        public static IAsmContext New(IClrIndexer clrindex, DataResourceIndex resources,  AsmFormatConfig format)             
            => new AsmContext(AssemblyComposition.Empty, clrindex, resources, format, CilFormatConfig.Default);

        /// <summary>
        /// Creates a base context with specified indexes
        /// </summary>
        /// <param name="clrindex">The clr index</param>
        /// <param name="resources">The resource index</param>
        public static IAsmContext New(IClrIndexer clrindex, DataResourceIndex resources)             
            => new AsmContext(AssemblyComposition.Empty, clrindex, resources, AsmFormatConfig.New, CilFormatConfig.Default);

        AsmContext(IContext root, IAssemblyComposition assemblies, IClrIndexer clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat)
        {
            this.RootContext = root != null ? some(root) : none<IContext>();
            this.State = AsmContextData.New(assemblies ?? AssemblyComposition.Empty, clrIndex, resources,format,cilFormat);
            this.Identity = Context.NextId();
        }

        AsmContext(IAssemblyComposition assemblies, IClrIndexer clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat)
            : this(null,assemblies, clrIndex, resources, format, cilFormat)
        {

        }

        AsmContext(IContext root, int id, AsmContextData data)
        {
            this.RootContext = root != null ? some(root) : none<IContext>();
            this.State = data;
            this.Identity = id;
        }

        readonly AsmContextData State;

        readonly Option<IContext> RootContext;

        Option<IAppMsgContext> MsgContext => RootContext.TryMap(c => c as IAppMsgContext);

        Option<IAppMsgQueue> MsgSink => MsgContext.TryMap(c => c as IAppMsgQueue);
        
        public int Identity {get;}

        public IClrIndexer ClrIndex 
            => State.ClrIndex;
        
        public AsmFormatConfig AsmFormat 
            => State.AsmFormat;

        public CilFormatConfig CilFormat
            => State.CilFormat;
        
        public IAssemblyComposition Compostion
            => State.Assemblies;

        public IAsmContext WithFormat(AsmFormatConfig config)
            => new AsmContext(
                RootContext.ValueOrDefault(),
                Context.NextId(),
                AsmContextData.New(Compostion, ClrIndex, State.Resources, config, CilFormat)
                );

        public void Notify(AppMsg msg)
            => MsgSink.OnSome(sink => sink.Notify(msg));

        public void Notify(string msg, AppMsgKind? severity = null)
            => MsgSink.OnSome(sink => sink.Notify(msg, severity));

        public IReadOnlyList<AppMsg> Flush()
            => MsgSink ? MsgSink.Value.Flush() : array<AppMsg>();

        public IReadOnlyList<AppMsg> Flush(Exception e)
            => MsgSink ? MsgSink.Value.Flush(e) : array<AppMsg>();
    }   
}