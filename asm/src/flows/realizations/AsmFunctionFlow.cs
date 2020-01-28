//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;

    class AsmFunctionFlow : IAsmFunctionFlow
    {
        public static AsmFunctionFlow Create(IAsmContext context, IOperationCatalog catalog)
            => new AsmFunctionFlow(context, catalog);

        AsmFunctionFlow(IAsmContext context, IOperationCatalog catalog)
        {
            this.Context = context;
            this.Catalog = catalog;
            this.Decoder = AsmServices.Decoder(context, NativeServices.DefaultBufferLen);
        }

        readonly IAsmContext Context;

        IClrIndex ClrIndex
            => Context.ClrIndex;

        public IOperationCatalog Catalog {get;}

        public IAsmDecoder Decoder {get;}

        static ReadOnlySpan<byte> ImmSelection => new byte[]{5,9,13};

        IAsmImmCapture ImmCaptureSvc(MethodInfo src, Moniker baseid)
            => AsmServices.UnaryImmCapture(Context,src, baseid);

        AsmFunction Flow(AsmFunction src, IAsmFunctionPipe dst)
        {
            return dst.Flow(src);
        }

        AsmFunction WithCil(AsmFunction f, MethodInfo m)       
            => f.WithCil(ClrIndex.FincCil(m));
            
        IEnumerable<AsmFunction> FlowImm(GenericOpSpec op, IAsmFunctionPipe pipe)
        {
            if(FunctionType.vunaryImm(op.Method))
            {
                var functions = from closure in OpFactory.close(op)
                            let svc = ImmCaptureSvc(closure.ClosedMethod, closure.Id)
                            from f in svc.Capture(ImmSelection.ToArray())
                            select Flow(WithCil(f,closure.ClosedMethod),pipe);
                
                foreach(var f in functions)
                    yield return f;
            }                        
        }

        IEnumerable<AsmFunction> FlowImm(DirectOpSpec op, IAsmFunctionPipe pipe)
        {
            if(FunctionType.vunaryImm(op.Method))
                foreach(var f in ImmCaptureSvc(op.Method, op.Id).Capture(ImmSelection.ToArray()))
                    yield return Flow(WithCil(f,op.Method), pipe);                                
        }

        IEnumerable<AsmFunction> Flow(DirectOpSpec op, IAsmFunctionPipe pipe)
            => from f in items(Decoder.DecodeFunction(op.Id, op.Method))
                select Flow(WithCil(f, op.Method), pipe);

        IEnumerable<AsmFunction> Flow(GenericOpSpec op, IAsmFunctionPipe pipe)
            => from closure in OpFactory.close(op)
                    let f = Decoder.DecodeFunction(closure.Id, closure.ClosedMethod)
                        select Flow(WithCil(f, closure.ClosedMethod), pipe);       
       
        IEnumerable<AsmFunction> BranchImm(DirectOpSpec op, IAsmFunctionPipe pipe)
            => FunctionType.immneeds(op.Method) ? FlowImm(op, pipe) : Flow(op,pipe);

        IEnumerable<AsmFunction> BranchImm(GenericOpSpec op, IAsmFunctionPipe pipe)
            => FunctionType.immneeds(op.Method) ? FlowImm(op,pipe) : Flow(op,pipe);

        IEnumerable<AsmFunction> FlowGeneric(Type host, IAsmFunctionPipe pipe)
            => from op in OpSpecs.generic(host)
               from emission in BranchImm(op, pipe)
                select emission.WithCil(ClrIndex.FincCil(op.Method));
        
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