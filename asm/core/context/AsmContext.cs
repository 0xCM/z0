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
        /// <summary>
        /// Creates a rooted context with a specified composition
        /// </summary>
        /// <param name="root">The root context</param>
        /// <param name="assemblies">The composition</param>
        public static IAsmContext Rooted(IContext root, IAssemblyComposition assemblies)
            => new AsmContext(root, assemblies, AsmFormatConfig.New);

        /// <summary>
        /// Creates a base context with a specified composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        public static IAsmContext New(IAssemblyComposition assemblies)
            => new AsmContext(assemblies, AsmFormatConfig.New);

        public static IAsmContext New()
            => new AsmContext(AssemblyComposition.Empty, AsmFormatConfig.New);

        AsmContext(IContext root, IAssemblyComposition assemblies, AsmFormatConfig format)
        {
            require(root != null);
            this.RootContext = some(root);
            this.State = AsmContextData.New(assemblies ?? AssemblyComposition.Empty, format);
            this.Identity = Context.NextId();
        }

        protected AsmContext(IContext root, AsmContextData state)
        {
            this.RootContext = some(root);
            this.State = state;
            this.Identity = Context.NextId();
        }

        AsmContext(IAssemblyComposition assemblies, AsmFormatConfig format)
        {
            require(assemblies != null && format != null);
            this.RootContext = none<IContext>();
            this.State = AsmContextData.New(assemblies, format);
            this.Identity = Context.NextId();
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
        
        public AsmFormatConfig AsmFormat 
            => State.AsmFormat;
        
        public IAssemblyComposition Compostion
            => State.Assemblies;

        public IAsmContext WithFormat(AsmFormatConfig config)
            => new AsmContext(RootContext.ValueOrDefault(),Context.NextId(), AsmContextData.New(Compostion, config));

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