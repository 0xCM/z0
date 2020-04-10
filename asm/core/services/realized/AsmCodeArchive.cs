//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    readonly struct AsmCodeArchive : IAsmCodeArchive
    {
        public FolderPath RootFolder {get;}

        readonly IContext Context;
        
        public PartId SourcePart {get;}

        public string HostName {get;}

        [MethodImpl(Inline)]
        public static IAsmCodeArchive Create(IContext context, PartId catalog)
            => new AsmCodeArchive(context, catalog);

        [MethodImpl(Inline)]
        public static IAsmCodeArchive Create(IContext context, PartId catalog, string host)
            => new AsmCodeArchive(context, catalog, host);

        [MethodImpl(Inline)]
        AsmCodeArchive(IContext context, PartId catalog, string host)
        {
            this.Context = context;
            this.SourcePart = catalog;
            this.HostName = host;
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(SourcePart.Format(),host));
        }

        AsmCodeArchive(IContext context, PartId catalog)
        {
            this.Context = context;
            this.SourcePart = catalog;
            this.HostName = string.Empty;
            this.RootFolder = context.EmissionPaths().DataSubDir(FolderName.Define(SourcePart.Format()));
        }

        /// <summary>
        /// Enumerates the files in the archive
        /// </summary>
        IEnumerable<FilePath> Files 
            => RootFolder.Files(FileExtensions.Hex,true);
                    
        public IEnumerable<AsmCode> Read(string name)
            => Read(fn => fn.NoExtension == name);
        
        public IEnumerable<AsmCode> Read()
            => Read(_ => true);

        public IEnumerable<AsmCode> Read(Func<FileName,bool> predicate)
        {
            foreach(var file in Files.Where(f => predicate(f.FileName)))
            foreach(var item in Read(file))
            {
                if(item.IsNonEmpty)
                    yield return item;
            }
        }

        /// <summary>        
        /// Reads a default-formatted hex-line file
        /// </summary>
        /// <param name="src">The source file path</param>
        /// <param name="idsep">The id delimiter</param>
        /// <param name="bytesep">The hex byte delimiter</param>
        public IEnumerable<AsmCode> Read(FilePath src)
            => Context.CodeReader().Read(src);

        /// <summary>
        /// Reads a moniker-identified, default-formatted hex-line file
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public IEnumerable<AsmCode> Read(OpIdentity id)
            => Read(RootFolder + FileName.Define(id, AsmHexLine.FileExt));

        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="id">The identifying moniker</param>
        public Option<AsmCode> Read<T>(OpIdentity id, T t = default)
            where T : unmanaged
                => Read<T>(Context.EmissionPaths().HexPath(RootFolder, id), id);
        
        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        static AsmCode Parse<T>(string data, OpIdentity id)
            where T : unmanaged
                => AsmCode.Define(id, MemoryExtract.Define(MemoryAddress.Zero, HexParsers.Bytes.ParseBytes(data).ToArray()));

        Option<AsmCode> Read<T>(FilePath src, OpIdentity m)
            where T : unmanaged
                => Try(() => Parse<T>(src.ReadText(), m));

        public IAsmCodeArchive Clear()
        {
            iter(RootFolder.Files(FileExtensions.Hex), f => f.Delete());
            return this;
        }
    }
}