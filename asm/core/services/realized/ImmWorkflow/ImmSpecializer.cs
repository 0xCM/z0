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

        static void OnEmbeddingFailure(OpIdentity id)
            => term.error($"Embedding failure for {id}");

        [MethodImpl(Inline)]
        ImmSpecializer(IContext context, IAsmFunctionDecoder decoder)
        {            
            this.Decoder = decoder;
            this.Capture = context.Capture();
        }

        public Option<AsmFunction> UnaryOp(in OpExtractExchange exchange, MethodInfo src, OpIdentity id, byte imm)
        {
            var f = Dynop.EmbedVUnaryOpImm(src, imm, id).OnNone(() => OnEmbeddingFailure(id));
            if(f)
              return     
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.DecodeCaptured(c)
                    select d;
            else
                return none<AsmFunction>();
        }

        public AsmFunction[] UnaryOps(in OpExtractExchange exchange, MethodInfo src, OpIdentity id, params byte[] imm)
        {   
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = UnaryOp(exchange,src,id,imm[i]).OnNone(() => OnCaptureFailed(id)).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> BinaryOp(in OpExtractExchange exchange, MethodInfo src, OpIdentity id, byte imm)
        {
            var f = Dynop.EmbedVBinaryOpImm(src, imm, id).OnNone(() => OnEmbeddingFailure(id));
            if(f)
              return     
                    from c in Capture.Capture(exchange, f.Value.Id, f.Value)
                    from d in Decoder.DecodeCaptured(c)
                    select d;
            else
                return none<AsmFunction>();
        }

        public AsmFunction[] BinaryOps(in OpExtractExchange exchange, MethodInfo src, OpIdentity id, params byte[] imm)
        {   
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = BinaryOp(exchange,src,id,imm[i]).OnNone(() => OnCaptureFailed(id )).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> Single<T>(in OpExtractExchange exchange, ISVImm8UnaryResolver128Api<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.DecodeCaptured(c)
                   select d;

        public AsmFunction[] Many<T>(in OpExtractExchange exchange, ISVImm8UnaryResolver128Api<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> Single<T>(in OpExtractExchange exchange, ISVImm8UnaryResolver256Api<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.DecodeCaptured(c)
                   select d;

        public AsmFunction[] Many<T>(in OpExtractExchange exchange, ISVImm8UnaryResolver256Api<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> Single<T>(in OpExtractExchange exchange, ISVImm8BinaryResolver128Api<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.DecodeCaptured(c)
                   select d;

        public AsmFunction[] Many<T>(in OpExtractExchange exchange, ISVImm8BinaryResolver128Api<T> resolver, params byte[] imm)
            where T : unmanaged
        {
            var count = imm.Length;
            var dst = new AsmFunction[count];
            for(var i=0; i<count; i++)
                dst[i] = Single(exchange, resolver, imm[i]).ValueOrDefault(AsmFunction.Empty);
            return dst;
        }

        public Option<AsmFunction> Single<T>(in OpExtractExchange exchange, ISVImm8BinaryResolver256Api<T> resolver, byte imm)
            where T : unmanaged
                => from c in Capture.Capture(exchange, resolver.Id.WithImm8(imm), resolver.@delegate(imm))
                   from d in Decoder.DecodeCaptured(c)
                   select d;

        public AsmFunction[] Many<T>(in OpExtractExchange exchange, ISVImm8BinaryResolver256Api<T> resolver, params byte[] imm)
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