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

    using static zfunc;

    public static class AsmServices
    {                                
        /// <summary>
        /// Instantiates a contextual archive service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmArchiver Archiver(this IAsmContext context)
            => AsmArchiver.Create(context);

        /// <summary>
        /// Instantiates a contextual decoder service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmDecoder Decoder(this IAsmContext context, bool emitcil = true)
            => AsmDecoder.Create(context, emitcil);                        

        /// <summary>
        /// Instantiates a contextual asm capture service service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static ICaptureService Capture(this IAsmContext context, ICaptureOps ops)
            => AsmCaptureService.Create(context, ops);

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
        /// Instantiates a contextual code writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static IAsmCodeWriter CodeWriter(this IAsmContext context, FilePath dst, bool append = false)
            => AsmCodeWriter.Create(context, dst, append);

        /// <summary>
        /// Instantiates a contextual code reader service
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="idsep">The identifer/code delimiter</param>
        /// <param name="bytesep">The byte delimiter</param>
        [MethodImpl(Inline)]
        public static IAsmCodeReader CodeReader(this IAsmContext context, char? idsep = null, char? bytesep = null)
            => AsmCodeReader.Create(context,idsep,bytesep);
    
        /// <summary>
        /// Instantiates a contextual exucution buffer
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="size">The buffer length</param>
        [MethodImpl(Inline)]
        public static IAsmExecBuffer ExecBuffer(this IAsmContext context, int? size = null)
            => AsmExecBuffer.Create(context,size);
        
        /// <summary>
        /// Instantiates a contextual buffered client
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="client">The client to interwine</param>
        [MethodImpl(Inline)]
        public static IAsmBufferedClient BufferedClient(this IAsmContext context, AsmBufferClient client)
            => AsmBufferedClient.Create(context, client);

        /// <summary>
        /// Creates an asm buffer set, which is considered an asm service but cannot be contracted since it is a ref struct
        /// </summary>
        /// <param name="context">The context assubmed by the buffers</param>
        /// <param name="sink">The target to which capture events are routed</param>
        /// <param name="size">The (uniform) buffer length</param>
        [MethodImpl(Inline)]
        public static AsmBuffers Buffers(this IAsmContext context, CaptureEventObserver observer, int? size = null)
            => AsmBuffers.Create(context,observer,size);

        /// <summary>
        /// Instantiates a contextual asm formatter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionFormatter AsmFormatter(this IAsmContext context)
            => AsmFunctionFormatter.Create(context);

        /// <summary>
        /// Instantiates a contextual archive service that is specialized for an assembly
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="id">The assembly identifier</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IAsmContext context, AssemblyId id)
            => AsmCodeArchive.Create(context,id);

        /// <summary>
        /// Instantiates a contextual code archive service that is specialized for an assembly and api host
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog name</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IAsmContext context, AssemblyId assembly, string host)
            => AsmCodeArchive.Create(context, assembly, host);

        /// <summary>
        /// Instantiates a contextual function archive service that is specialized for an assembly and api host
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog identity</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IAsmContext context, AssemblyId catalog, string host)
            => AsmFunctionArchive.Create(context, catalog, host);

        /// <summary>
        /// Instantiates a contextual asm function emitter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionEmitter AsmEmitter(this IAsmContext context)
            => AsmFunctionEmitter.Create(context);

        /// <summary>
        /// Allocates a caller-disposed asm text writer
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        public static IAsmFunctionWriter AsmWriter(this IAsmContext context, FilePath dst)
            => AsmFunctionWriter.Create(context, dst);

        /// <summary>
        /// Instantiates a contextual catalog-level emitter service
        /// </summary>
        /// <param name="context">The source context</param>
        public static IAsmCatalogEmitter CatalogEmitter(this IAsmContext context, IOperationCatalog catalog, CaptureEmissionObserver observer)
            => AsmCatalogEmitter.Create(context, catalog, observer);

        /// <summary>
        /// Instantiates a contextual cil formatter
        /// </summary>
        /// <param name="context">The source context</param>
        public static ICilFunctionFormatter CilFormatter(this IAsmContext context)
            => CilFunctionFormatter.Create(context);

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

        /// <summary>
        /// Instantiates an internal instruction formatter service
        /// </summary>
        /// <param name="context">The configuration to use</param>
        [MethodImpl(Inline)]
        internal static IAsmInstructionFormatter InstructionFormatter(this IAsmContext context)
            => AsmFunctionFormatter.BaseFormatter(context);
    }
}