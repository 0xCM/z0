//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    public static class AsmServices
    {        
        public static IAsmCatalogEmitter CatalogEmitter(IOperationCatalog catalog)
            => AsmCatalogEmitter.Create(catalog);

        public static IAsmFormatter Formatter(AsmFormatConfig config = null)
            => AsmSpecFormatter.Create(config);

        public static IAsmFunctionArchive FunctionArchive(string catalog, string subject, AsmArchiveConfig? config = null)
            => AsmFunctionArchive.Create(catalog,subject,config);

        public static IAsmCodeArchive CodeArchive(string catalog, string subject)
            => AsmCodeArchive.Create(catalog,subject);
            
        public static IAsmFunctionBuilder FunctionBuilder()
            => AsmFunctionBuilder.Create();

        public static IAsmDecoder Decoder(ClrMetadataIndex metadata = null, int? bufferlen = null)
            => AsmDecoder.Create(metadata, bufferlen);

        /// <summary>
        /// Allocates a caller-disposed asm text writer
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        /// <param name="append">Whether to append to or overwrite an existing file</param>
        public static IAsmWriter Writer(FilePath dst, bool header = true, bool append = false)
        {
            dst.FolderPath.CreateIfMissing();            
            var exists = dst.Exists();
            var writer = new AsmWriter(dst, append);
            if(!exists || !append && header)
                writer.WriteHeader(AsmFormatConfig.Default);
            return writer;
        }
    }
}