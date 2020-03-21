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

    public class AsmContext : IAsmContext 
    {            
        readonly AsmContextData State;

        readonly Option<IAppContext> RootContext;

        /// <summary>
        /// Creates a rooted context with a specified composition
        /// </summary>
        /// <param name="root">The root context</param>
        /// <param name="assemblies">The composition</param>
        public static IAsmContext Rooted(IAppContext root, IApiComposition assemblies, IAppSettings settings = null, IPolyrand random = null)
            => new AsmContext(root, CreateState(assemblies, AsmFormatConfig.New, settings, random));

        public static IAsmContext Rooted(IComposedApiContext composed, AsmFormatConfig format = null, IAppSettings settings = null,  IPolyrand random = null)
            => new AsmContext(composed, CreateState(composed.Compostion, format, settings, random));

        /// <summary>
        /// Creates a base context with a specified composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        public static IAsmContext New(IApiComposition assemblies, IAppSettings settings = null, IPolyrand random = null)
            => new AsmContext(null, CreateState(assemblies, AsmFormatConfig.New, settings, random));

        public static IAsmContext New(IPolyrand random = null)
            => new AsmContext(null, CreateState(random:random));

        static AsmContextData CreateState(IApiComposition assemblies = null, AsmFormatConfig format = null, IAppSettings settings = null, IPolyrand random = null)
            => AsmContextData.New(assemblies ?? ApiComposition.Empty, format ?? AsmFormatConfig.New, settings, random);

        protected AsmContext(IAppContext root, AsmContextData state)
        {
            this.RootContext = root != null ? some(root) : none<IAppContext>();
            this.State = state;
        }

        Option<IAppMsgContext> MsgContext 
            => RootContext.TryMap(c => c as IAppMsgContext);

        Option<IAppMsgQueue> MsgSink 
            => MsgContext.TryMap(c => c as IAppMsgQueue);
        
        public IAppSettings Settings 
            => State.Settings;

        public Option<IPolyrand> Random 
            => State.Random;
                
        public AsmFormatConfig AsmFormat 
            => State.AsmFormat;
        
        public IApiComposition Compostion
            => State.Assemblies;

        public IAsmContext WithFormat(AsmFormatConfig config)
            => new AsmContext(RootContext.ValueOrDefault(), AsmContextData.New(Compostion, config, Settings, Random.Value));

        public void Notify(AppMsg msg)
            => MsgSink.OnSome(sink => sink.Notify(msg));

        public void Notify(string msg, AppMsgKind? severity = null)
            => MsgSink.OnSome(sink => sink.Notify(msg, severity));

        public IReadOnlyList<AppMsg> Flush()
            => MsgSink ? MsgSink.Value.Flush() : array<AppMsg>();

        public IReadOnlyList<AppMsg> Flush(Exception e)
            => MsgSink ? MsgSink.Value.Flush(e) : array<AppMsg>();

        public void Flush(FilePath dst) 
            => MsgSink.OnSome(q => q.Flush(dst));

    }   
}