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

    using static Root;

    public static class AsmCoreServices
    {
        public static Option<ParsedEncodingReport> LoadParsedEncodings(this IAsmContext context, ApiHostPath host, char? delimiter = null)
        {
            var path = context.EmissionPaths().ParsedCapturePath(host);
            var sep = delimiter ?? text.pipe();
            var model = ParsedEncodingReport.Empty;
            
            try
            {            
                var records = new List<ParsedEncodingRecord>();
                var headers = Reports.headers<ParsedEncodingRecord>();
                var count = 0;
                
                using var reader = path.Reader();
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if(count != 0)
                    {
                        var fields = line.SplitClean(sep);
                        if(fields.Length != model.FieldCount)
                            throw new Exception($"A line had an unexpected number of fields. Expected = {model.FieldCount}, Actual = {fields.Length}");                        
                        //records.Add(ParsedEncodingRecord.FromFields(fields));
                    }
                        
                    count++;                    
                }                

                return default;
            }
            catch(Exception e)
            {
                term.error(e);
                return none<ParsedEncodingReport>();
            }
        }

        public static IAsmCodeIndex ToCodeIndex(this IEnumerable<AsmCode> code)
            => AsmCodeIndex.Create(code);

        /// <summary>
        /// Instantiates a contextual asm capture service service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmCaptureService Capture(this IAsmContext context, IAsmCaptureOps ops)
            => AsmCaptureService.Create(context, ops);
        

        [MethodImpl(Inline)]
        public static IAsmFunctionBuilder FunctionBuilder(this IAsmContext context)
            => AsmFunctionBuilder.Create(context);        

        [MethodImpl(Inline)]
        public static AsmEmissionPaths EmissionPaths(this IAsmContext context)    
            => AsmEmissionPaths.Current;

        /// <summary>
        /// Instantiates a contextual cil formatter
        /// </summary>
        /// <param name="context">The source context</param>
        public static ICilFunctionFormatter CilFormatter(this IAsmContext context)
            => CilFunctionFormatter.Create(context);

        /// <summary>
        /// Instantiates a contextual asm function emitter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionEmitter AsmEmitter(this IAsmContext context, IAsmFunctionFormatter formatter)
            => AsmFunctionEmitter.Create(context, formatter);

        [MethodImpl(Inline)]
        public static IAsmHostExtractor HostExtractor(this IAsmContext context, int? bufferlen = null)
            => AsmHostCapture.Create(context, bufferlen);

        [MethodImpl(Inline)]
        public static IAsmMemoryExtractor MemoryExtractor(this IAsmContext context, byte[] buffer)
            => AsmMemoryExtractor.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IAsmEncodingParser EncodingParser(this IAsmContext context, byte[] buffer)
            => AsmEncodingParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static ByteParser<EncodingPatternKind> PatternParser(this IAsmContext context, byte[] buffer)
            => ByteParser<EncodingPatternKind>.Create(context, EncodingPatterns.Default,  buffer);

        [MethodImpl(Inline)]
        public static IAsmBaseAddressProvider BaseAddressProvider(this IAsmContext context, params MemoryAddress[] addresses)
            => AsmBaseAddressProvider.Create(context,addresses);

        [MethodImpl(Inline)]
        public static IAsmCaptureOps CaptureOps(this IAsmContext context)
            => AsmCaptureOps.Create(context);

        /// <summary>
        /// Instantiates a contextual code writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static IAsmCodeWriter CodeWriter(this IAsmContext context, FilePath dst)
            => AsmCodeWriter.Create(context, dst);

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
        /// Creates an asm buffer set, which is considered an asm service but cannot be contracted since it is a ref struct
        /// </summary>
        /// <param name="context">The context assubmed by the buffers</param>
        /// <param name="sink">The target to which capture events are routed</param>
        /// <param name="size">The (uniform) buffer length</param>
        [MethodImpl(Inline)]
        public static AsmBuffers Buffers(this IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
            => AsmBuffers.Create(context,observer,size);

        /// <summary>
        /// Instantiates a contextual buffered client
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="client">The client to interwine</param>
        [MethodImpl(Inline)]
        public static IAsmBufferClient BufferedClient(this IAsmContext context, AsmBufferClient client)
            => AsmBufferedClient.Create(context, client);

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
        /// Instantiates a contextual raw buffer writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static IAsmRawWriter RawWriter(this IAsmContext context, FilePath dst)
            => AsmRawWriter.Create(context, dst);

        public static AsmCaptureExchange CaptureExchange(this IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
        {
            const int DefaultBufferLen = 1024*8;

            var control = AsmCaptureControl.Create(context, observer);
            var cBuffer = new byte[size ?? DefaultBufferLen];
            var sBuffer = new byte[size ?? DefaultBufferLen];
            return AsmCaptureExchange.Define(control, cBuffer, sBuffer);
        }        

        public static IEnumerable<AssemblyId> ActiveAssemblies(this IAsmContext context)
        {
            var settings = AppSettings.Load("z0.control").Pairs;
            foreach(var (key,value) in settings)
            {
                var index = key.Split(text.colon());            
                if(index.Length == 2 && bit.Parse(index[1]))
                {
                    var id = Enums.parse<AssemblyId>(value);
                    if(id != AssemblyId.None)
                        yield return id;                        
                }
            }
        }
    }
}