//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Core;

    public static class AsmServices
    {                
        /// <summary>
        /// Instantiates a contextual archive service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmAssemblyArchiver Archiver(this IAsmContext context)
            => AssemblyArchiverService.Create(context);

        /// <summary>
        /// Instantiates a contextual function archive service that is specialized for an assembly and api host
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog identity</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IAsmContext context, PartId catalog, string host)
            => AsmFunctionArchive.Create(context, catalog, host);

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IAsmContext context, ApiHostUri host, bool imm)
            => AsmFunctionArchive.Create(context, host, imm);

        /// <summary>
        /// Instantiates a contextual catalog-level emitter service
        /// </summary>
        /// <param name="context">The source context</param>
        public static IAsmCatalogEmitter CatalogEmitter(this IAsmContext context, IApiCatalog catalog, AsmEmissionObserver observer)
            => AsmCatalogEmitter.Create(context, catalog, observer);

        [MethodImpl(Inline)]
        public static IAssemblyCapture AssemblyCapture(this IAsmContext context)
            => AssemblyCaptureService.Create(context);
 
        /// <summary>
        /// Creates a capture workflow where the unit-of-work is determined by an api host
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IHostCapture HostCapture(this IAsmContext context)
            => HostCaptureService.Create(context);
 
        [MethodImpl(Inline)]
        public static IMemoryCapture MemoryCapture(this IAsmContext context)
            => MemoryCaptureService.Create(context);

        [MethodImpl(Inline)]
        public static IOpExtractParser ExtractParser(this IAsmContext context, byte[] buffer)
            => OpExtractParser.New(context, buffer);

        [MethodImpl(Inline)]
        public static IOpExtractParser ExtractParser(this IAsmContext context, int? bufferlen = null)
            => OpExtractParser.New(context, bufferlen);

        [MethodImpl(Inline)]
        public static IAsmHostArchive HostArchive(this IAsmContext context, ApiHostUri host)
            => AsmHostArchive.Create(context, host);    
    }
}