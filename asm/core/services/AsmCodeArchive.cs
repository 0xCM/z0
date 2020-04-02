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

    using static Core;

    readonly struct AsmCodeArchive : IAsmCodeArchive
    {
        public FolderPath RootFolder {get;}

        public IAsmContext Context {get;}
        
        public PartId Origin {get;}

        public string HostName {get;}

        [MethodImpl(Inline)]
        public static IAsmCodeArchive New(IAsmContext context, PartId catalog)
            => new AsmCodeArchive(context, catalog);

        [MethodImpl(Inline)]
        public static IAsmCodeArchive New(IAsmContext context, PartId catalog, string host)
            => new AsmCodeArchive(context, catalog, host);

        [MethodImpl(Inline)]
        AsmCodeArchive(IAsmContext context, PartId catalog, string host)
        {
            this.Context = context;
            this.Origin = catalog;
            this.HostName = host;
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(Origin.Format(),host));
        }

        AsmCodeArchive(IAsmContext context, PartId catalog)
        {
            this.Context = context;
            this.Origin = catalog;
            this.HostName = string.Empty;
            this.RootFolder = context.EmissionPaths().DataSubDir(FolderName.Define(Origin.Format()));
        }

        /// <summary>
        /// Enumerates the files in the archive
        /// </summary>
        IEnumerable<FilePath> Files 
            => RootFolder.Files(FileExtensions.Hex,true);
                    
        /// <summary>
        /// Reads a hex-line formatted file
        /// </summary>
        /// <param name="src">The source file path</param>
        /// <param name="idsep">The id delimiter</param>
        /// <param name="bytesep">The hex byte delimiter</param>
        public IEnumerable<AsmCode> Read(FilePath src, char idsep, char bytesep)
            => Context.CodeReader(idsep,bytesep).Read(src);

        public IEnumerable<AsmCode> Read(string name)
            => Read(fn => fn.NoExtension == name);
        
        public IEnumerable<AsmCode> Read()
            => Read(_ => true);

        public IEnumerable<AsmCode> Read(Func<FileName,bool> predicate)
        {
            foreach(var file in Files.Where(f => predicate(f.FileName)))
            foreach(var item in Read(file))
                yield return item;
        }

        /// <summary>        
        /// Reads a default-formatted hex-line file
        /// </summary>
        /// <param name="src">The source file path</param>
        /// <param name="idsep">The id delimiter</param>
        /// <param name="bytesep">The hex byte delimiter</param>
        public IEnumerable<AsmCode> Read(FilePath src)
            => Read(src, AsmHexLine.DefaultIdSep, AsmHexLine.DefaultByteSep);

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
                => Read(Context.EmissionPaths().HexPath(RootFolder, id), id, t);
        
        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        static AsmCode Parse<T>(string data, OpIdentity id, T t = default)
            where T : unmanaged
                => new AsmCode(id, MemoryExtract.Define(MemoryAddress.Zero, HexParser.ByteParser.ParseBytes(data).ToArray()));

        Option<AsmCode> Read<T>(FilePath src, OpIdentity m, T t = default)
            where T : unmanaged
                => Try(() => Parse<T>(src.ReadText(), m,t ));

        public IAsmCodeArchive Clear()
        {
            iter(RootFolder.Files(FileExtensions.Hex), f => f.Delete());
            return this;
        }
    }
}