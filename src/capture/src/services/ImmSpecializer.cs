//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    using static Memories;

    class ImmSpecializer : IImmSpecializer
    {        
        readonly IAsmFunctionDecoder Decoder;

        readonly ICaptureService Capture;

        readonly IDynexus Dynamic;

        /// <summary>
        /// Instantiates a contextual immediate capture service for a unary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmSpecializer Create(IContext context, IAsmFunctionDecoder decoder)
            => new ImmSpecializer(context, decoder);

        static void OnCaptureFailed(OpIdentity id)
            => term.error($"Capture failure for {id}");

        static void OnEmbeddingFailure(MethodInfo src)
            => term.error($"Embedding failure for {src.Name}");

        [MethodImpl(Inline)]
        ImmSpecializer(IContext context, IAsmFunctionDecoder decoder)
        {            
            this.Decoder = decoder;
            this.Capture = AsmStatelessCore.Factory.CaptureService();
            this.Dynamic = Dynops.Services.Nexus;
        }

        public Option<AsmFunction> UnaryOp(in CaptureExchange exchange, MethodInfo src, byte imm)
        {
            var width = VectorType.width(src.ReturnType);
            var f = Dynamic.EmbedUnaryImm(width,src, imm).OnNone(() => OnEmbeddingFailure(src));
            if(f)
              return     
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.Decode(c)
                    select d;
            else
                return none<AsmFunction>();
        }

        public Option<AsmFunction> UnaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm)
        {
            var width = VectorType.width(src.ReturnType);
            var f = Dynamic.EmbedUnaryImm(width, src, imm).OnNone(() => OnEmbeddingFailure(src));
            if(f)
              return     
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.Decode(c)
                    select d;
            else
                return none<AsmFunction>();
        }

        public AsmFunction[] UnaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, params Imm8Value[] imm)
        {   
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = UnaryOp(exchange,src, id, imm[i]).OnNone(() => OnCaptureFailed(id)).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> BinaryOp(in CaptureExchange exchange, MethodInfo src, OpIdentity id, byte imm)
        {
            var width = VectorType.width(src.ReturnType);
            var f = Dynamic.EmbedBinaryImm(width,src, imm).OnNone(() => OnEmbeddingFailure(src));
            if(f)
              return     
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.Decode(c)
                    select d;
            else
                return none<AsmFunction>();
        }

        public AsmFunction[] BinaryOps(in CaptureExchange exchange, MethodInfo src, OpIdentity id, params Imm8Value[] imm)
        {   
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = BinaryOp(exchange,src,id,imm[i]).OnNone(() => OnCaptureFailed(id)).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> Single<T>(in CaptureExchange exchange, IImm8UnaryResolver128<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.Decode(c)
                   select d;

        public AsmFunction[] Many<T>(in CaptureExchange exchange, IImm8UnaryResolver128<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> Single<T>(in CaptureExchange exchange, IImm8UnaryResolver256<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.Decode(c)
                   select d;

        public AsmFunction[] Many<T>(in CaptureExchange exchange, IImm8UnaryResolver256<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> Single<T>(in CaptureExchange exchange, IImm8BinaryResolver128<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.Decode(c)
                   select d;

        public AsmFunction[] Many<T>(in CaptureExchange exchange, IImm8BinaryResolver128<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> Single<T>(in CaptureExchange exchange, IImm8BinaryResolver256<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.Decode(c)
                   select d;

        public AsmFunction[] Many<T>(in CaptureExchange exchange, IImm8BinaryResolver256<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }
    }
}