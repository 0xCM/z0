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
    
    using static zfunc;

    readonly struct EncodingExtractor : IEncodingExtractor
    {
        public IAsmContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IEncodingExtractor Create(IAsmContext context, int? bufferlen = null)
            => new EncodingExtractor(context,bufferlen);
            
        [MethodImpl(Inline)]
        EncodingExtractor(IAsmContext context, int? bufferlen)            
        {
            this.Context = context;
            this.BufferLength = bufferlen ?? Pow2.T14;
        }

        public CapturedEncodingReport Extract(ApiHost src)
        {
            var ops = src.EncodedOps().ToArray();
            var dst = new CapturedEncodingRecord[ops.Length];
            var buffer = alloc<byte>(BufferLength);
            var reader = Context.ByteReader();

            for(var i=0; i< ops.Length; i++)
            {
                buffer.Clear();                

                var op = ops[i];
                var length = reader.Read(op.Location, BufferLength, buffer);                
                var record = new CapturedEncodingRecord
                {
                    Sequence = i,
                    Length = length,
                    Host = src.Path,
                    Address = op.Location,
                    OpSig = op.Source.Signature().Format(),
                    OpId = op.Id,
                    OpName = op.Source.Name,
                    Data = buffer.Slice(0,length).ToArray()
                };
                dst[i] = record;
            }    

            return CapturedEncodingReport.Create(src,dst);
        }
    }
}