//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static root;

    public static class ImmCaptureServices
    {
        [MethodImpl(Inline)]
        public static IImmCapture<T> ImmVCapture<R,T>(this IAsmContext context, R resolver)
            where T : unmanaged        
            where R : ISImm8ResolverApi<T>
            => resolver switch {
                ISVImm8UnaryResolver128Api<T> r => ImmV128UnaryCaptureService<T>.New(context,r),
                ISVImm8UnaryResolver256Api<T> r => ImmV256UnaryCaptureService<T>.New(context,r),
                ISVImm8BinaryResolver128Api<T> r => ImmV128BinaryCaptureService<T>.New(context,r),
                ISVImm8BinaryResolver256Api<T> r => ImmV256BinaryCaptureService<T>.New(context,r),
                _ => throw unsupported(resolver.GetType())
            };           

        /// <summary>
        /// Instantiates a contextual immediate capture service for a unary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmCapture ImmUnaryCapture(this IAsmContext context, MethodInfo src, OpIdentity baseid)
            => ImmUnaryCaptureService.New(context,src,baseid);

        /// <summary>
        /// Instantiates a contextual immediate capture service for a binary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmCapture ImmBinaryCapture(this IAsmContext context, MethodInfo src, OpIdentity baseid)
            => ImmBinaryCaptureService.New(context,src,baseid);

        [MethodImpl(Inline)]
        internal static AsmFunction Decode(this IAsmContext context, IAsmFunctionDecoder decoder, in OpExtractExchange exchange, OpIdentity id, DynamicDelegate src)
            => decoder.DecodeFunction(context.Capture().Capture(in exchange, id, src));

    }
}