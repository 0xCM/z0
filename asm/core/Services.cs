//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Svc = Z0.Asm;
    
    using static Seed;

    public static class ServiceFactory
    {                       
        [MethodImpl(Inline)]
        public static IImmCapture<T> ImmVCapture<R,T>(this IContext context, R resolver, IAsmFunctionDecoder decoder)
            where T : unmanaged        
            where R : ISFImm8ResolverApi<T>
            => resolver switch {
                ISVImm8UnaryResolver128Api<T> r => ImmV128UnaryCaptureService<T>.New(context,r, decoder),
                ISVImm8UnaryResolver256Api<T> r => ImmV256UnaryCaptureService<T>.New(context,r, decoder),
                ISVImm8BinaryResolver128Api<T> r => ImmV128BinaryCaptureService<T>.New(context,r, decoder),
                ISVImm8BinaryResolver256Api<T> r => ImmV256BinaryCaptureService<T>.New(context,r, decoder),
                _ => throw Unsupported.define(resolver.GetType())
            };           

        /// <summary>
        /// Instantiates a contextual immediate capture service for a unary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmCapture ImmUnaryCapture(this IContext context, MethodInfo src, OpIdentity baseid, IAsmFunctionDecoder decoder)
            => ImmUnaryCaptureService.Create(context,src,baseid, decoder);

        /// <summary>
        /// Instantiates a contextual immediate capture service for a binary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmCapture ImmBinaryCapture(this IContext context, MethodInfo src, OpIdentity baseid, IAsmFunctionDecoder decoder)
            => ImmBinaryCaptureService.Create(context,src,baseid, decoder);


        [MethodImpl(Inline)]
        public static IOpExtractParser ExtractParser(this IAsmContext context, byte[] buffer)
            => OpExtractParser.New(context, buffer);

        [MethodImpl(Inline)]
        public static IOpExtractParser ExtractParser(this IAsmContext context, int? bufferlen = null)
            => OpExtractParser.New(context, bufferlen);

        [MethodImpl(Inline)]
        public static IMemoryCapture MemoryCapture(this IContext context, IAsmInstructionDecoder decoder,  int? bufferlen = null)
            => MemoryCaptureService.Create(context, decoder, bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        public static IAsmFunctionBuilder FunctionBuilder(this IContext context)
            => AsmFunctionBuilder.Create(context);        

        [MethodImpl(Inline)]
        public static AsmEmissionPaths EmissionPaths(this IContext context)    
            => AsmEmissionPaths.The;

        [MethodImpl(Inline)]
        public static IHostOpExtractor HostExtractor(this IContext context, int? bufferlen = null)
            => HostOpExtractor.New(context, bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        public static IMemoryExtractor MemoryExtractor(this IContext context, byte[] buffer)
            => Svc.MemoryExtractor.New(context, buffer);

        [MethodImpl(Inline)]
        public static IMemoryExtractParser MemoryExtractParser(this IContext context, byte[] buffer)
            => Svc.MemoryExtractParser.New(context, buffer);

        [MethodImpl(Inline)]
        public static IMemberExtractReader MemberExtractReader(this IContext context)
            => Svc.MemberExtractReader.Create(context);

        [MethodImpl(Inline)]
        public static ByteParser<EncodingPatternKind> PatternParser(this IContext context, byte[] buffer)
            => ByteParser<EncodingPatternKind>.New(context, EncodingPatterns.Default,  buffer);

        [MethodImpl(Inline)]
        public static ICaptureService Capture(this IContext context)
            => CaptureService.New(context);

        /// <summary>
        /// Instantiates a contextual code writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static IAsmCodeWriter CodeWriter(this IContext context, FilePath dst)
            => AsmCodeWriter.New(context, dst);

        /// <summary>
        /// Instantiates a contextual code reader service
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="idsep">The identifer/code delimiter</param>
        /// <param name="bytesep">The byte delimiter</param>
        [MethodImpl(Inline)]
        public static IAsmCodeReader CodeReader(this IContext context)
            => AsmCodeReader.New(context);

        /// <summary>
        /// Instantiates a contextual service allocation that streams lines of operation hex to a target file
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target file</param>
        [MethodImpl(Inline)]
        public static IAsmHexWriter HexWriter(this IContext context, FilePath dst)
            => AsmHexWriter.New(context, dst);

        /// <summary>
        /// Instantiates a contextual service allocation that streams lines of operation hex to a target file
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target file</param>
        [MethodImpl(Inline)]
        public static IAsmHexReader HexReader(this IContext context)
            => AsmHexReader.New(context);

        /// <summary>
        /// Creates an asm buffer set, which is considered an asm service but cannot be contracted since it is a ref struct
        /// </summary>
        /// <param name="context">The context assubmed by the buffers</param>
        /// <param name="sink">The target to which capture events are routed</param>
        /// <param name="size">The (uniform) buffer length</param>
        [MethodImpl(Inline)]
        public static AsmBuffers Buffers(this IContext context, AsmCaptureEventObserver observer, int? size = null)
            => AsmBuffers.New(context, observer, size);

        /// <summary>
        /// Instantiates a contextual archive service that is specialized for an assembly
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="id">The assembly identifier</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IContext context, PartId id)
            => AsmCodeArchive.New(context,id);

        /// <summary>
        /// Instantiates a contextual code archive service that is specialized for an assembly and api host
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog name</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IContext context, PartId assembly, string host)
            => AsmCodeArchive.New(context, assembly, host);

        /// <summary>
        /// Creates a flow over an instruction source
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        /// <param name="triggers">The triggers that fire when instructions satisfy criterea of interest</param>
        public static IAsmInstructionFlow InstructionFlow(this IContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => AsmInstructionFlow.Create(context, source, triggers);

        public static OpExtractExchange ExtractExchange(this IContext context, AsmCaptureEventObserver observer, int? size = null)
        {
            const int DefaultBufferLen = 1024*8;

            var control = ExtractControl.New(context, observer);
            var cBuffer = new byte[size ?? DefaultBufferLen];
            var sBuffer = new byte[size ?? DefaultBufferLen];
            return OpExtractExchange.New(control, cBuffer, sBuffer);
        }        

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IContext context, ApiHostUri host, bool imm, IAsmFormatter formatter)
            => AsmFunctionArchive.Create(context,host,imm,formatter);
        
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IContext context, PartId catalog, string host, IAsmFormatter formatter)
            => AsmFunctionArchive.Create(context,catalog,host,formatter);

        [MethodImpl(Inline)]
        public static IApiCorrelator ApiCorrelator(this IApiContext c)
            => Svc.ApiCorrelator.Create(c);

        public static Option<Assembly> ResolvedAssembly(this IApiContext context, PartId id)
            =>  (from r in  context.Compostion.Resolved
                where r.Id == id
                select r.Owner).FirstOrDefault();

        public static IEnumerable<PartId> ActiveAssemblies(this IApiContext context)
            => context.Compostion.Resolved.Select(r => r.Id);
    }
}