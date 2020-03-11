//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Z0.Asm;
    
    using static Root;

    public static class AsmCoreServices
    {            
        [MethodImpl(Inline)]
        public static IAsmFunctionBuilder FunctionBuilder(this IAsmContext context)
            => AsmFunctionBuilder.Create(context);        

        [MethodImpl(Inline)]
        public static AsmEmissionPaths EmissionPaths(this IAsmContext context)    
            => AsmEmissionPaths.The;

        [MethodImpl(Inline)]
        public static IHostOpExtractor HostExtractor(this IAsmContext context, int? bufferlen = null)
            => HostOpExtractor.New(context, bufferlen);

        [MethodImpl(Inline)]
        public static IMemoryExtractor MemoryExtractor(this IAsmContext context, byte[] buffer)
            => Z0.MemoryExtractor.New(context, buffer);

        [MethodImpl(Inline)]
        public static IMemoryExtractParser MemoryExtractParser(this IAsmContext context, byte[] buffer)
            => Z0.Asm.MemoryExtractParser.New(context, buffer);

        [MethodImpl(Inline)]
        public static ByteParser<EncodingPatternKind> PatternParser(this IAsmContext context, byte[] buffer)
            => ByteParser<EncodingPatternKind>.New(context, EncodingPatterns.Default,  buffer);

        [MethodImpl(Inline)]
        public static ICaptureService Capture(this IAsmContext context)
            => CaptureService.New(context);

        /// <summary>
        /// Instantiates a contextual code writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static IAsmCodeWriter CodeWriter(this IAsmContext context, FilePath dst)
            => AsmCodeWriter.New(context, dst);

        /// <summary>
        /// Instantiates a contextual code reader service
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="idsep">The identifer/code delimiter</param>
        /// <param name="bytesep">The byte delimiter</param>
        [MethodImpl(Inline)]
        public static IAsmCodeReader CodeReader(this IAsmContext context, char? idsep = null, char? bytesep = null)
            => AsmCodeReader.New(context,idsep, bytesep);

        /// <summary>
        /// Instantiates a contextual service allocation that streams lines of operation hex to a target file
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target file</param>
        [MethodImpl(Inline)]
        public static IAsmHexWriter HexWriter(this IAsmContext context, FilePath dst)
            => AsmHexWriter.New(context, dst);

        /// <summary>
        /// Instantiates a contextual service allocation that streams lines of operation hex to a target file
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target file</param>
        [MethodImpl(Inline)]
        public static IAsmHexReader HexReader(this IAsmContext context)
            => AsmHexReader.New(context);

        /// <summary>
        /// Creates an asm buffer set, which is considered an asm service but cannot be contracted since it is a ref struct
        /// </summary>
        /// <param name="context">The context assubmed by the buffers</param>
        /// <param name="sink">The target to which capture events are routed</param>
        /// <param name="size">The (uniform) buffer length</param>
        [MethodImpl(Inline)]
        public static AsmBuffers Buffers(this IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
            => AsmBuffers.New(context,observer,size);

        /// <summary>
        /// Instantiates a contextual buffered client
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="client">The client to interwine</param>
        [MethodImpl(Inline)]
        public static IAsmBufferClient BufferedClient(this IAsmContext context, AsmBufferClient client)
            => AsmBufferedClient.New(context, client);

        /// <summary>
        /// Instantiates a contextual archive service that is specialized for an assembly
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="id">The assembly identifier</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IAsmContext context, AssemblyId id)
            => AsmCodeArchive.New(context,id);

        /// <summary>
        /// Instantiates a contextual code archive service that is specialized for an assembly and api host
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog name</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IAsmContext context, AssemblyId assembly, string host)
            => AsmCodeArchive.New(context, assembly, host);

        /// <summary>
        /// Creates a flow over an instruction source
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        /// <param name="triggers">The triggers that fire when instructions satisfy criterea of interest</param>
        public static IAsmInstructionFlow InstructionFlow(this IAsmContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => AsmInstructionFlow.Create(context, source, triggers);

        [MethodImpl(Inline)]
        public static IMemberLocator MemberLocator(this IAsmContext src)
            => Z0.MemberLocator.New(src);

        public static OpExtractExchange ExtractExchange(this IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
        {
            const int DefaultBufferLen = 1024*8;

            var control = ExtractControl.New(context, observer);
            var cBuffer = new byte[size ?? DefaultBufferLen];
            var sBuffer = new byte[size ?? DefaultBufferLen];
            return OpExtractExchange.New(control, cBuffer, sBuffer);
        }        

        public static Option<Assembly> ResolvedAssembly(this IAsmContext context, AssemblyId id)
            =>  (from r in  context.Compostion.Resolved
                where r.Id == id
                select r.Resolved).FirstOrDefault();

        public static IEnumerable<AssemblyId> ActiveAssemblies(this IAsmContext context)
        {
            return context.Compostion.Resolved.Select(r => r.Id);
            // var settings = AppSettings.Load("z0.control").Pairs;
            // foreach(var (key,value) in settings)
            // {
            //     var index = key.Split(text.colon());            
            //     if(index.Length == 2 && bit.Parse(index[1]))
            //     {
            //         var id = Enums.parse<AssemblyId>(value, AssemblyId.None);
            //         if(id != AssemblyId.None)
            //             yield return id;                        
            //     }
            // }
        }
    }
}