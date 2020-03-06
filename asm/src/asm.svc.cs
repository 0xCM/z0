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
        /// Instantiates a contextual archive service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmAssemblyArchiver Archiver(this IAsmContext context)
            => AsmAssemblyArchiver.Create(context);

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
        public static IAsmFunctionArchive FunctionArchive(this IAsmContext context, ApiHostUri host, bool imm)
            => AsmFunctionArchive.Create(context, host, imm);

        /// <summary>
        /// Instantiates a contextual catalog-level emitter service
        /// </summary>
        /// <param name="context">The source context</param>
        public static IAsmCatalogEmitter CatalogEmitter(this IAsmContext context, IOpCatalog catalog, AsmEmissionObserver observer)
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
        public static IAssemblyCapture AssemblyCapture(this IAsmContext context)
            => Z0.AssemblyCapture.Create(context);
 
        /// <summary>
        /// Creates a capture workflow where the unit-of-work is determined by an api host
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IHostCapture HostCaptureWorkflow(this IAsmContext context)
            => AsmHostCapture.Create(context);
 
        [MethodImpl(Inline)]
        public static IMemoryCapture MemoryCapture(this IAsmContext context)
            => Z0.MemoryCapture.Create(context);

        [MethodImpl(Inline)]
        public static IOpExtractParser ExtractParser(this IAsmContext context, byte[] buffer)
            => OpExtractParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IAsmHostArchive HostArchive(this IAsmContext context, ApiHostUri host)
            => AsmHostArchive.Create(context, host);    
    }
}