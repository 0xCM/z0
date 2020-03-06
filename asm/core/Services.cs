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

    using Z0.Asm;
    
    using static Root;

    public static class AsmCoreServices
    {
        public static Option<ParsedOpReport> LoadParsedEncodings(this IAsmContext context, ApiHostUri host, char? delimiter = null)
        {
            var path = context.EmissionPaths().ParsedPath(host);
            var sep = delimiter ?? text.pipe();
            var model = ParsedOpReport.Empty;
            
            try
            {            
                var records = new List<ParsedOpRecord>();
                var headers = Reports.headers<ParsedOpRecord>();
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
                return none<ParsedOpReport>();
            }
        }

        /// <summary>
        /// Instantiates a contextual asm capture service service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IOpCaptureService Capture(this IAsmContext context, IOpCaptureService ops)
            => ops;

            //=> AsmCaptureService.Create(context, ops);

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
        public static IAsmFunctionEmitter AsmEmitter(this IAsmContext context, IAsmFormatter formatter)
            => AsmFunctionEmitter.Create(context, formatter);

        [MethodImpl(Inline)]
        public static IHostOpExtractor HostExtractor(this IAsmContext context, int? bufferlen = null)
            => HostOpExtractor.Create(context, bufferlen);

        [MethodImpl(Inline)]
        public static IMemoryExtractor MemoryExtractor(this IAsmContext context, byte[] buffer)
            => Z0.MemoryExtractor.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IMemoryExtractParser EncodingParser(this IAsmContext context, byte[] buffer)
            => MemoryExtractParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static ByteParser<EncodingPatternKind> PatternParser(this IAsmContext context, byte[] buffer)
            => ByteParser<EncodingPatternKind>.Create(context, EncodingPatterns.Default,  buffer);

        [MethodImpl(Inline)]
        public static IOpCaptureService OpExtractor(this IAsmContext context)
            => OpCaptureService.Create(context);

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
        /// Creates a flow over an instruction source
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        /// <param name="triggers">The triggers that fire when instructions satisfy criterea of interest</param>
        public static IAsmInstructionFlow InstructionFlow(this IAsmContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => AsmInstructionFlow.Create(context, source, triggers);

        /// <summary>
        /// Instantiates a contextual raw buffer writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static IAsmEncodingWriter EncodingWriter(this IAsmContext context, FilePath dst)
            => AsmEncodingWriter.Create(context, dst);

        [MethodImpl(Inline)]
        public static IMemberLocator MemberLocator(this IAsmContext src)
            => Z0.MemberLocator.Create(src);

        public static IEnumerable<LocatedMember> LocatedMembers(this IAsmContext context, AssemblyId src)
            => context.ResolvedAssembly(src).MapValueOrElse(a => Z0.MemberLocator.Create(context).Members(a), () => array<LocatedMember>());

        public static IEnumerable<LocatedMember> LocatedMembers(this IAsmContext context, Type host)
            => Z0.MemberLocator.Create(context).Members(host);

        public static OpExtractExchange ExtractExchange(this IAsmContext context, AsmCaptureEventObserver observer, int? size = null)
        {
            const int DefaultBufferLen = 1024*8;

            var control = ExtractControl.Create(context, observer);
            var cBuffer = new byte[size ?? DefaultBufferLen];
            var sBuffer = new byte[size ?? DefaultBufferLen];
            return OpExtractExchange.Define(control, cBuffer, sBuffer);
        }        

        public static IEnumerable<AssemblyId> ActiveAssemblies(this IAsmContext context)
        {
            var settings = AppSettings.Load("z0.control").Pairs;
            foreach(var (key,value) in settings)
            {
                var index = key.Split(text.colon());            
                if(index.Length == 2 && bit.Parse(index[1]))
                {
                    var id = Enums.parse<AssemblyId>(value, AssemblyId.None);
                    if(id != AssemblyId.None)
                        yield return id;                        
                }
            }
        }
    }
}