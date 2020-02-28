//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;

    readonly struct AsmHostCapture : IAsmHostCapture
    {
        public IAsmContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IAsmHostCapture Create(IAsmContext context, int? bufferlen = null)
            => new AsmHostCapture(context,bufferlen);
            
        [MethodImpl(Inline)]
        AsmHostCapture(IAsmContext context, int? bufferlen)            
        {
            this.Context = context;
            this.BufferLength = bufferlen ?? Pow2.T14;
        }

        public CapturedEncodingReport CaptureHostOps(ApiHost src)
        {
            var ops = DefinedHostOps(src).ToArray();
            var records = new CapturedEncodingRecord[ops.Length];
            var buffer = alloc<byte>(BufferLength);
            var reader = Context.ByteReader();

            for(var i=0; i< ops.Length; i++)
            {
                buffer.Clear();                

                var op = ops[i];
                var length = reader.Read(op.Address, BufferLength, buffer);                
                var record = new CapturedEncodingRecord(                
                    Sequence : i,
                    Address : op.Address,
                    Length : length,
                    Uri : OpUri.Hex(src.Path, op.Source.Name, op.Id),
                    OpSig : op.Source.Signature().Format(),
                    Data : EncodedData.Define(op.Address, buffer.Slice(0,length).ToArray())
                    );
                records[i] = record;
            }    
            var report = CapturedEncodingReport.Create(src.Path, records);
            return report;
        }

        public IEnumerable<EncodedOp> DefinedHostOps(ApiHost host)
        {
            var generic = from m in host.DeclaredMethods.OpenGeneric()                
                          where 
                               m.Tagged<OpAttribute>() 
                            && m.Tagged<NumericClosuresAttribute>() 
                            && !m.AcceptsImmediate()
                          let c = m.Tag<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                          where c != NumericKind.None
                          from t in c.DistinctKinds().Select(x => x.ToClrType())
                          where t.IsSome()
                          let concrete = m.MakeGenericMethod(t.Value)
                          let address =  MemoryAddress.Define(concrete.Jit())
                          select EncodedOp.Define(concrete.Identify(), concrete, address);
            
            var direct = from m in host.DeclaredMethods.NonGeneric()
                          where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                          let address =  MemoryAddress.Define(m.Jit())
                          select EncodedOp.Define(m.Identify(), m, address);
                          
            return generic.Union(direct).OrderBy(x => x.Address);
        }            
    }
}