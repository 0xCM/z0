//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Svc = Z0.Asm;
    
    using static Seed;

    public interface IAsmCore : IAsmServiceFactory
    {
        IAsmStatelessCore StatelessCore => AsmStatelessCore.Factory;

    }

    public readonly struct AsmCore : IAsmCore
    {
        [MethodImpl(Inline)]
        public static IAsmCore Create(IAsmContext context)
            => new AsmCore(context);

        [MethodImpl(Inline)]
        public AsmCore(IAsmContext context)
        {
            this.Context = context;
        }
        
        public IAsmContext Context {get;}
    }

    public static class AsmCoreServices
    {                       
        [MethodImpl(Inline)]
        public static CaptureExchange CaptureExchange(this IAsmContext context)
            => Svc.CaptureExchange.Create(context);
        
        [MethodImpl(Inline)]
        public static IHostAsmArchiver ImmFunctionArchive(this IContext context, ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => HostAsmArchiver.ImmArchive(context, host, formatter, dst);

        [MethodImpl(Inline)]
        public static IImmSpecializer ImmSpecializer(this IContext context, IAsmFunctionDecoder decoder)
            => Svc.ImmSpecializer.Create(context, decoder);

        /// <summary>
        /// Instantiates a basic capture service that supports the extract/parse/decode workflow
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IHostCaptureService HostCaptureService(this IAsmContext context, FolderName area = null, FolderName subject = null)
            => Svc.HostCaptureService.Create(context, area, subject);

        [MethodImpl(Inline)]
        public static IAsmFunctionDecoder AsmFunctionDecoder(this IContext context, AsmFormatSpec? format = null)
            => AsmDecoder.FunctionDecoder(format);
    }
}