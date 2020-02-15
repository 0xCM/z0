//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    
    using static zfunc;

    public interface IEncodingExtractor : IAppService
    {
        CapturedEncodings Extract(ApiHost src);
    }

    readonly struct EncodingExtractor : IEncodingExtractor
    {
        public IContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IEncodingExtractor Create(IContext context, int? bufferlen = null)
            => new EncodingExtractor(context,bufferlen);
            
        [MethodImpl(Inline)]
        EncodingExtractor(IContext context, int? bufferlen)            
        {
            this.Context = context;
            this.BufferLength = bufferlen ?? Pow2.T14;
        }

        public CapturedEncodings Extract(ApiHost src)
        {
            var methods = src.EncodedMethods().ToArray();
            var dst = new CapturedEncoding[methods.Length];
            var buffer = span<byte>(BufferLength);
            var reader = Context.ByteReader();

            for(var i=0; i< methods.Length; i++)
            {
                buffer.Clear();                

                var method = methods[i];
                var length = reader.Read(method.Location, BufferLength, buffer);                
                var record = new CapturedEncoding
                {
                    Sequence = i,
                    Length = length,
                    Host = src.Path,
                    Address = method.Location,
                    OpSig = method.Source.Signature().Format(),
                    OpId = method.Id,
                    OpName = method.Source.Name,
                    Data = buffer.Slice(0,length).ToArray()
                };
                dst[i] = record;
            }    

            return CapturedEncodings.Create(src,dst);
        }
    }
}