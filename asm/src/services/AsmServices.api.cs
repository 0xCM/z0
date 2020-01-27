//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using AsmSpecs;

    using static zfunc;

    public static class AsmServices
    {        
        public static IClrIndex IndexAssembly(Assembly assembly)
            => ClrMetadataIndex.Create(assembly.Modules.ToArray());
            
        public static IAsmContext Context()
            => Context(ClrMetadataIndex.Empty, DataResourceIndex.Empty, AsmFormatConfig.Default);
            
        public static IAsmContext Context(IClrIndex index, DataResourceIndex residx, AsmFormatConfig format)
            => AsmContext.Define(index, residx, format);

        public static IAsmImmCapture<T> ImmCapture<T>(IAsmContext context, IImm8Resolver<T> resolver)
            where T : unmanaged        
            => resolver switch {
                IVUnaryImm8Resolver128<T> r => AsmV128ImmUnaryCapture<T>.Create(context,r),
                IVUnaryImm8Resolver256<T> r => AsmV256ImmUnaryCapture<T>.Create(context,r),
                IVBinaryImm8Resolver128<T> r => AsmV128ImmBinaryCapture<T>.Create(context,r),
                IVBinaryImm8Resolver256<T> r => AsmV256ImmBinaryCapture<T>.Create(context,r),
                _ => throw unsupported(resolver.GetType())
            };   

        [MethodImpl(Inline)]
        public static IAsmImmCapture UnaryImmCapture(IAsmContext context, MethodInfo src, Moniker baseid)
            => AsmImmUnaryCapture.Create(context, src,baseid);

        /// <summary>
        /// Instantiates a catalog emitter service
        /// </summary>
        /// <param name="context">The context that specifies the catalog over which the emitter will be created</param>
        [MethodImpl(Inline)]
        public static IAsmCatalogEmitter CatalogEmitter(IAsmContext context, IOperationCatalog catalog)
            => AsmCatalogEmitter.Create(context,catalog);

        /// <summary>
        /// Instantiates a code emitter service over a target folder
        /// </summary>
        /// <param name="dst">The target folder</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionEmitter CodeEmitter(IAsmContext context, FolderPath dst)
            => AsmFunctionEmitter.Create(context, dst);

        /// <summary>
        /// Instantiates a function flow service over a source catalog
        /// </summary>
        /// <param name="src">The source catalog</param>
        public static IAsmFunctionFlow Flow(IAsmContext src, IOperationCatalog catalog)
            => AsmFunctionFlow.Create(src,catalog);        

        /// <summary>
        /// Instantiates an asm formatter service with a specified configuration
        /// </summary>
        /// <param name="config">The configuration to use</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionFormatter Formatter(IAsmContext context)
            => AsmContentFormatter.Create(context);
        
        /// <summary>
        /// Instantiates an internal/first-round asm formatter service
        /// </summary>
        /// <param name="config">The configuration to use</param>
        [MethodImpl(Inline)]
        internal static IIcedAsmFormatter BaseFormatter(IAsmContext context)
            => AsmContentFormatter.BaseFormatter(context);

        /// <summary>
        /// Instantiates a subject-specific function catalog archive service
        /// </summary>
        /// <param name="catalog">The catalog name</param>
        /// <param name="subject">The subject</param>
        /// <param name="config">The archive configuration</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(IAsmContext context, string catalog, string subject)
            => AsmFunctionArchive.Create(context, catalog,subject);

        /// <summary>
        /// Instantiates a subject-specific code catalog archive service
        /// </summary>
        /// <param name="catalog">The catalog name</param>
        /// <param name="subject">The subject</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(string catalog, string subject)
            => AsmCodeArchive.Create(catalog,subject);

        /// <summary>
        /// Instantiates a code archive service specific to an an assembly and subject
        /// </summary>
        /// <param name="assembly">The originating assembly</param>
        /// <param name="subject">The subject</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(AssemblyId assembly, string subject)
            => AsmCodeArchive.Create(assembly.ToString().ToLower(), subject);

        /// <summary>
        /// Instantiates an asm decoder service
        /// </summary>
        /// <param name="metadata">If specified, defines the clr metadata index that the decoder can use to associate native code with cil code</param>
        /// <param name="bufferlen">If specified, the lenght of the decoder's buffer; if unspecified a default value will be chosen</param>
        [MethodImpl(Inline)]
        public static IAsmDecoder Decoder()
            => AsmDecoder.Create(Context(ClrMetadataIndex.Empty, DataResourceIndex.Empty, AsmFormatConfig.Default));

        /// <summary>
        /// Instantiates an asm decoder service
        /// </summary>
        /// <param name="clridx">If specified, defines the clr metadata index that the decoder can use to associate native code with cil code</param>
        /// <param name="bufferlen">If specified, the lenght of the decoder's buffer; if unspecified a default value will be chosen</param>
        [MethodImpl(Inline)]
        public static IAsmDecoder Decoder(IAsmContext context, int? bufferlen = null)
            => AsmDecoder.Create(context);
        

        /// <summary>
        /// Allocates a caller-disposed asm text writer and, as determined by the configuration, emits a file header
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        public static IAsmWriter Writer(IAsmContext context, FilePath dst)
        {
            dst.FolderPath.CreateIfMissing();            
            var writer = AsmWriter.Create(context, dst);            
            if(context.AsmFormat.EmitFileHeader)
                writer.WriteFileHeader();
            return writer;
        }

        public static Func<AsmStats> StatsEmitter(IAsmContext context, IOperationCatalog catalog)
        {
            AsmStats collect()
            {
                var collector = new  AsmStatsCollector();
                var pipe = AsmStatsPipe.Create(collector);
                var flow = Flow(context,catalog);
                flow.Flow(pipe).Force();
                return collector.Collected;
            }
            return collect;
        }
    }
}