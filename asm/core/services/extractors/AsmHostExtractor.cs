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

    /// <summary>
    /// Extracts operations from an api host
    /// </summary>
    readonly struct AsmHostExtractor : IAsmHostExtractor
    {
        public IAsmContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IAsmHostExtractor Create(IAsmContext context, int? bufferlen = null)
            => new AsmHostExtractor(context,bufferlen);
            
        [MethodImpl(Inline)]
        AsmHostExtractor(IAsmContext context, int? bufferlen)            
        {
            this.Context = context;
            this.BufferLength = bufferlen ?? Context.DefaultBufferLength;
        }

        public AsmOpExtractReport ExtractOps(ApiHost src)
        {
            var ops = Addresses(src).ToArray();
            var records = new AsmOpExtractRecord[ops.Length];
            var buffer = alloc<byte>(BufferLength);
            var reader = Context.ByteReader();

            for(var i=0; i< ops.Length; i++)
            {
                buffer.Clear();                

                var op = ops[i];
                var length = reader.Read(op.Address, BufferLength, buffer);
                var record = new AsmOpExtractRecord(                
                    Sequence : i,
                    Address : op.Address,
                    Length : length,
                    Uri : OpUri.Hex(src.Path, op.Source.Name, op.Id),
                    OpSig : op.Source.Signature().Format(),
                    Data : EncodedData.Define(op.Address, buffer.Slice(0,length).ToArray())
                    );
                records[i] = record;
            }    
            return AsmOpExtractReport.Create(records);
        }

        public IEnumerable<OpAddress> Addresses(ApiHost host)
        {
            var generic = from m in host.DeclaredMethods.OpenGeneric(1)
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
                          select OpAddress.Define(concrete.Identify(), concrete, address);
            
            var direct = from m in host.DeclaredMethods.NonGeneric()
                          where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                          let address =  MemoryAddress.Define(m.Jit())
                          select OpAddress.Define(m.Identify(), m, address);
                          
            return generic.Union(direct).OrderBy(x => x.Address);
        }            
    }
}