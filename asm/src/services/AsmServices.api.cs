//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using AsmSpecs;

    using static zfunc;

    public static class AsmServices
    {        
        public static IAsmSpecBuilder SpecBuilder()
            => default(AsmSpecBuilder);

        public static IAsmImmCapture<T> ImmCapture<T>(IImm8Resolver<T> resolver)
            where T : unmanaged        
            => resolver switch {
                IVUnaryImm8Resolver128<T> r => AsmV128ImmUnaryCapture<T>.Create(r),
                IVUnaryImm8Resolver256<T> r => AsmV256ImmUnaryCapture<T>.Create(r),
                IVBinaryImm8Resolver128<T> r => AsmV128ImmBinaryCapture<T>.Create(r),
                IVBinaryImm8Resolver256<T> r => AsmV256ImmBinaryCapture<T>.Create(r),
                _ => throw unsupported(resolver.GetType())
            };   

        [MethodImpl(Inline)]
        public static IAsmImmCapture ImmCapture(MethodInfo src, Moniker baseid)
            => AsmImmUnaryCapture.Create(src,baseid);

        /// <summary>
        /// Instantiates a catalog emitter service
        /// </summary>
        /// <param name="src">The catalog over which the emitter will be created</param>
        [MethodImpl(Inline)]
        public static IAsmCatalogEmitter CatalogEmitter(IOperationCatalog src)
            => AsmCatalogEmitter.Create(src);

        /// <summary>
        /// Instantiates a code emitter service over a target folder
        /// </summary>
        /// <param name="dst">The target folder</param>
        [MethodImpl(Inline)]
        public static IAsmCodeEmitter CodeEmitter(FolderPath dst, AsmFormatConfig config = null)
            => AsmCodeEmitter.Create(dst, config ?? AsmFormatConfig.Default.WithoutHeaderTimestamp());

        /// <summary>
        /// Instantiates a function flow service over a source catalog
        /// </summary>
        /// <param name="src">The soruce catalog</param>
        public static IAsmFunctionFlow Flow(IOperationCatalog src)
            => AsmFunctionFlow.Create(src);
        
        /// <summary>
        /// Instantiates an asm formatter service with the default configuration
        /// </summary>
        [MethodImpl(Inline)]
        public static IAsmFormatter Formatter()
            => AsmSpecFormatter.Create(AsmFormatConfig.Default);

        /// <summary>
        /// Instantiates an asm formatter service with a specified configuration
        /// </summary>
        /// <param name="config">The configuration to use</param>
        [MethodImpl(Inline)]
        public static IAsmFormatter Formatter(AsmFormatConfig config)
            => AsmSpecFormatter.Create(config);
        
        /// <summary>
        /// Instantiates an internal/first-round asm formatter service
        /// </summary>
        /// <param name="config">The configuration to use</param>
        [MethodImpl(Inline)]
        internal static IIcedAsmFormatter BaseFormatter()
            => AsmSpecFormatter.BaseFormatter();

        /// <summary>
        /// Instantiates a subject-specific function catalog archive service
        /// </summary>
        /// <param name="catalog">The catalog name</param>
        /// <param name="subject">The subject</param>
        /// <param name="config">The archive configuration</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(string catalog, string subject, AsmArchiveConfig? config = null)
            => AsmFunctionArchive.Create(catalog,subject,config);

        /// <summary>
        /// Instantiates a subject-specific code catalog archive service
        /// </summary>
        /// <param name="catalog">The catalog name</param>
        /// <param name="subject">The subject</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(string catalog, string subject)
            => AsmCodeArchive.Create(catalog,subject);

        /// <summary>
        /// Instantiates an asm decoder service
        /// </summary>
        /// <param name="metadata">If specified, defines the clr metadata index that the decoder can use to associate native code with cil code</param>
        /// <param name="bufferlen">If specified, the lenght of the decoder's buffer; if unspecified a default value will be chosen</param>
        [MethodImpl(Inline)]
        public static IAsmDecoder Decoder(ClrMetadataIndex metadata = null, int? bufferlen = null)
            => AsmDecoder.Create(metadata, bufferlen);

        /// <summary>
        /// Allocates a caller-disposed asm text writer
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        public static IAsmWriter Writer(FilePath dst, bool header)
        {
            var fmt = AsmFormatConfig.Default;
            dst.FolderPath.CreateIfMissing();            
            var writer = new AsmWriter(dst);            
            if(header)
            {
                writer.WriteLine($"; {now().ToLexicalString()}");
                writer.WriteLine(fmt.SectionDelimiter);
            }
            return writer;
        }

        public static Func<AsmStats> StatsEmitter(IOperationCatalog catalog)
        {
            AsmStats collect()
            {
                var collector = new  AsmStatsCollector();
                var pipe = AsmStatsPipe.Create(collector);
                var flow = Flow(catalog);
                flow.Flow(pipe).Force();
                return collector.Collected;
            }
            return collect;
        }
    }
}