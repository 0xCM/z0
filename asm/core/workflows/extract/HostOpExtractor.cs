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
    readonly struct HostOpExtractor : IHostOpExtractor
    {
        public IAsmContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IHostOpExtractor Create(IAsmContext context, int? bufferlen = null)
            => new HostOpExtractor(context,bufferlen);
            
        [MethodImpl(Inline)]
        HostOpExtractor(IAsmContext context, int? bufferlen)            
        {
            this.Context = context;
            this.BufferLength = bufferlen ?? Context.DefaultBufferLength;
        }

        public OpExtracts Extract(ApiHost src)
        {
            var members = Context.LocatedMembers(src.HostingType).ToArray();
            var buffer = alloc<byte>(BufferLength);
            var reader = Context.MemoryReader();
            var extracts = new OpExtract[members.Length];

            for(var i=0; i< members.Length; i++)
            {
                buffer.Clear();                

                var op = members[i];
                var length = reader.Read(op.Address, BufferLength, buffer);
                var data = MemoryExtract.Define(op.Address, buffer.Slice(0,length).ToArray());
                var uri = OpUri.Hex(src.Path, op.Member.Name, op.Id);
                extracts[i] = OpExtract.Defne(op.Id, uri, op, data);
            }  
            return extracts;  

        }

        public OpExtractReport ExtractOps(ApiHost src)
        {
            var ops = Context.LocatedMembers(src.HostingType).ToArray();
            var records = new OpExtractRecord[ops.Length];
            var buffer = alloc<byte>(BufferLength);
            var reader = Context.MemoryReader();


            for(var i=0; i< ops.Length; i++)
            {
                buffer.Clear();                

                var op = ops[i];
                var length = reader.Read(op.Address, BufferLength, buffer);
                var record = new OpExtractRecord(                
                    Sequence : i,
                    Address : op.Address,
                    Length : length,
                    Uri : OpUri.Hex(src.Path, op.Member.Name, op.Id),
                    OpSig : op.Member.Signature().Format(),
                    Data : MemoryExtract.Define(op.Address, buffer.Slice(0,length).ToArray())
                    );
                records[i] = record;
            }    
         
            return OpExtractReport.Create(records);
        }
    }
}