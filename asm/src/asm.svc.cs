//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;

    public static class AsmServices
    {                
        /// <summary>
        /// Instantiates a contextual asm function emitter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionEmitter AsmEmitter(this IAsmContext context)
            => context.AsmEmitter(context.AsmFormatter());

        /// <summary>
        /// Instantiates a contextual archive service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmArchiver Archiver(this IAsmContext context)
            => AsmArchiver.Create(context);

        /// <summary>
        /// Instantiates a contextual immediate capture service for a unary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IAsmImmCapture UnaryImmCapture(this IAsmContext context, MethodInfo src, OpIdentity baseid)
            => AsmImmCapture.Unary(context,src,baseid);

        /// <summary>
        /// Instantiates a contextual immediate capture service for a binary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IAsmImmCapture BinaryImmCapture(this IAsmContext context, MethodInfo src, OpIdentity baseid)
            => AsmImmCapture.Binary(context,src,baseid);

        /// <summary>
        /// Instantiates a contextual function archive service that is specialized for an assembly and api host
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog identity</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IAsmContext context, AssemblyId catalog, string host)
            => AsmFunctionArchive.Create(context, catalog, host);

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IAsmContext context, ApiHostPath host, bool imm)
            => AsmFunctionArchive.Create(context, host, imm);

        /// <summary>
        /// Instantiates a contextual catalog-level emitter service
        /// </summary>
        /// <param name="context">The source context</param>
        public static IAsmCatalogEmitter CatalogEmitter(this IAsmContext context, IOperationCatalog catalog, AsmCaptureEmissionObserver observer)
            => AsmCatalogEmitter.Create(context, catalog, observer);

        /// <summary>
        /// Instantiates a contextual cil function emitter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static ICilFunctionEmitter CilEmitter(this IAsmContext context)
            => CilFunctionEmitter.Create(context);

        /// <summary>
        /// Allocates a caller-disposed cil text writer
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static ICilFunctionWriter CilWriter(this IAsmContext context, FilePath dst)
            => CilFunctionWriter.Create(context,dst);

        [MethodImpl(Inline)]
        public static IAsmHostCaptureFlow HostCaptureFlow(this IAsmContext context)
            => AsmHostCaptureFlow.Create(context);
 
        [MethodImpl(Inline)]
        public static IAsmMemoryCaptureFlow MemoryCaptureFlow(this IAsmContext context, IAsmBaseAddressProvider provider)
            => AsmMemoryCaptureFlow.Create(context, provider);

        [MethodImpl(Inline)]
        public static IAsmMemoryCaptureFlow MemoryCaptureFlow(this IAsmContext context, params MemoryAddress[] addresses)
            => context.MemoryCaptureFlow(context.BaseAddressProvider(addresses));

        [MethodImpl(Inline)]
        public static IExtractionReportParser ExtractReportParser(this IAsmContext context, byte[] buffer)
            => ExtractionReportParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IAsmHostArchive HostArchive(this IAsmContext context, ApiHostPath host)
            => AsmHostArchive.Create(context, host);    
    }
}