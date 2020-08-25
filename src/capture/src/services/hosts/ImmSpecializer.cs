//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static Memories;

    class ImmSpecializer : IImmSpecializer
    {        
        readonly IAsmDecoder Decoder;

        readonly ICaptureCore Capture;

        readonly IDynexus Dynamic;

        static void OnCaptureFailed(OpIdentity id)
            => term.error($"Capture failure for {id}");

        static void OnEmbeddingFailure(MethodInfo src)
            => term.error($"Embedding failure for {src.Name}");

        [MethodImpl(Inline)]
        internal ImmSpecializer(IAsmDecoder decoder)
        {            
            Decoder = decoder;
            Capture = new CaptureCore();
            Dynamic = Dynops.Services.Dynexus;
        }

        public Option<AsmRoutine> UnaryOp(in CaptureExchange exchange, MethodInfo src, byte imm)
        {
            var width = VectorType.width(src.ReturnType);
            var f = Dynamic.CreateUnaryOp(width,src, imm).OnNone(() => OnEmbeddingFailure(src));
            if(f)
              return     
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.Decode(c)
                    select d;
            else
                return none<AsmRoutine>();
        }

        public Option<AsmRoutine> UnaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm)
        {
            var width = VectorType.width(src.ReturnType);
            var f = Dynamic.CreateUnaryOp(width, src, imm).OnNone(() => OnEmbeddingFailure(src));
            if(f)
              return     
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.Decode(c)
                    select d;
            else
                return none<AsmRoutine>();
        }

        public AsmRoutine[] UnaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, params Imm8R[] imm)
        {   
            var count = imm.Length;
            var dst = new AsmRoutine[count];
            for(var i=0; i<count; i++)
                dst[i] = UnaryOp(exchange,src, id, imm[i]).OnNone(() => OnCaptureFailed(id)).ValueOrDefault(AsmRoutine.Empty);
            return dst;
        }

        public Option<AsmRoutine> BinaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm)
        {
            var width = VectorType.width(src.ReturnType);
            var f = Dynamic.CreateBinaryOp(width,src, imm).OnNone(() => OnEmbeddingFailure(src));
            if(f)
              return     
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.Decode(c)
                    select d;
            else
                return none<AsmRoutine>();
        }

        public AsmRoutine[] BinaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, params Imm8R[] imm)
        {   
            var count = imm.Length;
            var dst = new AsmRoutine[count];
            for(var i=0; i<count; i++)
                dst[i] = BinaryOp(exchange,src,id,imm[i]).OnNone(() => OnCaptureFailed(id)).ValueOrDefault(AsmRoutine.Empty);
            return dst;
        }

        public Option<AsmRoutine> Single<T>(in CaptureExchange exchange, IImm8UnaryResolver128<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.Decode(c)
                   select d;

        public AsmRoutine[] Many<T>(in CaptureExchange exchange, IImm8UnaryResolver128<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmRoutine[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmRoutine.Empty);
            return dst;
        }

        public Option<AsmRoutine> Single<T>(in CaptureExchange exchange, IImm8UnaryResolver256<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.Decode(c)
                   select d;

        public AsmRoutine[] Many<T>(in CaptureExchange exchange, IImm8UnaryResolver256<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmRoutine[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmRoutine.Empty);
            return dst;
        }

        public Option<AsmRoutine> Single<T>(in CaptureExchange exchange, IImm8BinaryResolver128<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.Decode(c)
                   select d;

        public AsmRoutine[] Many<T>(in CaptureExchange exchange, IImm8BinaryResolver128<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmRoutine[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmRoutine.Empty);
            return dst;
        }

        public Option<AsmRoutine> Single<T>(in CaptureExchange exchange, IImm8BinaryResolver256<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.Decode(c)
                   select d;

        public AsmRoutine[] Many<T>(in CaptureExchange exchange, IImm8BinaryResolver256<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmRoutine[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmRoutine.Empty);
            return dst;
        }
    }
}