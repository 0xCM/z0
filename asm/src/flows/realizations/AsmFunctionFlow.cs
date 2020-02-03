//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;

    class AsmFunctionFlow : IAsmFunctionFlow
    {
        public static IAsmFunctionFlow Create(IAsmContext context, IOperationCatalog catalog)
            => new AsmFunctionFlow(context, catalog, AsmTriggerSet.Empty);

        public static AsmFunctionFlow Create(IAsmContext context, IOperationCatalog catalog, AsmTriggerSet triggers)
            => new AsmFunctionFlow(context, catalog,triggers);

        AsmFunctionFlow(IAsmContext context, IOperationCatalog catalog, AsmTriggerSet triggers)
        {
            this.Context = context;
            this.Catalog = catalog;
            this.Decoder = Context.Decoder();
            this.Triggers = triggers;
            this.FireTriggers = !triggers.IsEmpty;
        }

        readonly bool FireTriggers;
        
        public IAsmContext Context {get;}

        readonly AsmTriggerSet Triggers;

        public IOperationCatalog Catalog {get;}

        public IAsmDecoder Decoder {get;}

        IClrIndex ClrIndex
            => Context.ClrIndex;

        static ReadOnlySpan<byte> ImmSelection => new byte[]{5,9,13};

        IAsmImmCapture UnaryImmCapture(MethodInfo src, OpIdentity baseid)
            => Context.ImmCapture(src, baseid,n1);

        AsmFunction Flow(AsmFunction src, IAsmFunctionPipe dst)
        {
            return dst.Flow(src);
        }

        AsmFunction WithCil(AsmFunction f, MethodInfo m)       
            => f.WithCil(ClrIndex.FincCil(m));
            
        IEnumerable<AsmFunction> FlowImm(GenericOpSpec op, IAsmFunctionPipe pipe)
        {
            if(FunctionType.vunaryImm(op.Root))
            {
                var functions = from closure in op.Close()
                            let svc = UnaryImmCapture(closure.ClosedMethod, closure.Id)
                            from f in svc.Capture(ImmSelection.ToArray())
                            select Flow(WithCil(f,closure.ClosedMethod),pipe);
                
                foreach(var f in functions)
                    yield return f;
            }                        
        }

        IEnumerable<AsmFunction> FlowImm(DirectOpSpec op, IAsmFunctionPipe pipe)
        {
            if(FunctionType.vunaryImm(op.Root))
                foreach(var f in UnaryImmCapture(op.Root, op.Id).Capture(ImmSelection.ToArray()))
                    yield return Flow(WithCil(f,op.Root), pipe);                                
        }

        IEnumerable<AsmFunction> Flow(DirectOpSpec op, IAsmFunctionPipe pipe)
            => from f in items(Decoder.DecodeFunction(op.Id, op.Root))
                select Flow(WithCil(f, op.Root), pipe);

        IEnumerable<AsmFunction> Flow(GenericOpSpec op, IAsmFunctionPipe pipe)
            => from closure in op.Close()
                    let f = Decoder.DecodeFunction(closure.Id, closure.ClosedMethod)
                        select Flow(WithCil(f, closure.ClosedMethod), pipe);       
       
        IEnumerable<AsmFunction> BranchImm(DirectOpSpec op, IAsmFunctionPipe pipe)
            => FunctionType.immneeds(op.Root) ? FlowImm(op, pipe) : Flow(op,pipe);

        IEnumerable<AsmFunction> BranchImm(GenericOpSpec op, IAsmFunctionPipe pipe)
            => FunctionType.immneeds(op.Root) ? FlowImm(op,pipe) : Flow(op,pipe);

        IEnumerable<AsmFunction> FlowGeneric(Type host, IAsmFunctionPipe pipe)
            => from op in OpSpecs.generic(host)
               from emission in BranchImm(op, pipe)
                select emission.WithCil(ClrIndex.FincCil(op.Root));
        
        IEnumerable<AsmFunction> FlowDirect(Type host, IAsmFunctionPipe pipe)
            => from op in OpSpecs.direct(host)
               from emission in BranchImm(op, pipe)
                select emission;

        public IEnumerable<AsmFunction> FlowDirect(IAsmFunctionPipe pipe)
            => from h in Catalog.DirectApiHosts
              from emission in FlowDirect(h,pipe)
              select emission;

        public IEnumerable<AsmFunction> FlowGeneric(IAsmFunctionPipe pipe)
            => from h in Catalog.GenericApiHosts
                from emission in FlowGeneric(h,pipe)
                    select emission;        
        
        public IEnumerable<AsmFunction> Flow(IAsmFunctionPipe pipe)
            => FlowDirect(pipe).Union(FlowGeneric(pipe));
    }
}