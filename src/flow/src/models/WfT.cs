//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    public struct Wf<T> : IWorkflowContext<T>
    {
        long Correlation;

        readonly ulong SessionId;

        readonly WorkflowBroker Broker;

        public IAppContext ContextRoot {get;}
        
        public T ContextData {get;}

        [MethodImpl(Inline)]
        public static implicit operator Wf<T>(WorkflowContext<T> src)
            => new Wf<T>(src.ContextRoot, src.ContextData);
        
        [MethodImpl(Inline)]
        public Wf(IAppContext root, T config)
        {
            SessionId = (ulong)now().Ticks;
            ContextRoot = root;
            ContextData = config;
            Correlation = 0;
            Broker = new WorkflowBroker(root.AppPaths.AppStandardOutPath.ChangeExtension(FileExtensions.Csv));
            Broker.Receive(SessionId, OnEvent);
        }

        void OnEvent(IWorkflowEvent e)
        {
            term.print(e, e.Flair);
        }

        public TAppPaths AppPaths
        {
            [MethodImpl(Inline)]
            get => ContextRoot.AppPaths;
        }

        public void Raise<E>(E @event)
            where E : IAppEvent
        {
            ContextRoot.Deposit(@event);
        }

        public void Emitted<D>(uint count, FilePath dst, D d = default)
            => Raise(new EmittedDataset(typeof(D).Name, count, dst));

        public CorrelationToken Running(string worker)
        {
            var ct = CorrelationToken.define((ulong)z.atomic(ref Correlation));
            Raise(new StepExecuting(worker, ct));
            return ct;
        }

        public CorrelationToken Running(string worker, string detail, CorrelationToken? ct = null)
        {
            var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref Correlation));
            Raise(new StepExecuting(worker, detail, correlation));
            return correlation;
        }

        public CorrelationToken Running<D>(string worker, D detail, CorrelationToken? ct = null)
            where D : ITextual
        {
            var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref Correlation));
            Raise(new StepExecuting(worker, detail.Format(), correlation));
            return correlation;
        }

        public CorrelationToken Running(string worker, object detail, CorrelationToken? ct = null)
        {
            var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref Correlation));
            Raise(new StepExecuting(worker, (detail ?? EmptyString).ToString(), correlation));
            return correlation;
        }

        public void Ran(string worker, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref Correlation));         
            Raise(new StepExecuted(worker, correlation));            
        }

        public void Ran(string worker, string detail, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref Correlation));            
            Raise(new StepExecuted(worker, detail, correlation));
        }

        public void Ran<D>(string worker, D detail, CorrelationToken? ct = null)
            where D : ITextual
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref Correlation));            
            Raise(new StepExecuted(worker, detail.Format(), correlation));
        }        

        public void Ran(string worker, object detail, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref Correlation));            
            Raise(new StepExecuted(worker, (detail ?? EmptyString).ToString(), correlation));
        }
    }
}