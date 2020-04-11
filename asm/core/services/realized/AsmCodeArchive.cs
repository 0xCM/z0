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

        public ApiHostUri ApiHost {get;}

        [MethodImpl(Inline)]
        public static IAsmCodeArchive Create(IContext context, PartId catalog)
            => new AsmCodeArchive(context, catalog);

        [MethodImpl(Inline)]
        public static IAsmCodeArchive Create(IContext context, PartId catalog, ApiHostUri host)
            => new AsmCodeArchive(context, catalog, host);

        [MethodImpl(Inline)]
        AsmCodeArchive(IContext context, PartId catalog, ApiHostUri host)
        {
            this.Context = context;
            this.SourcePart = catalog;
            this.ApiHost = host;
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(SourcePart.Format(),host.Name));
        }

        AsmCodeArchive(IContext context, PartId catalog)
        {
            this.Context = context;
            this.SourcePart = catalog;
            this.ApiHost = ApiHostUri.Empty;
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
        

        public IAsmCodeArchive Clear()
        {
            iter(RootFolder.Files(FileExtensions.Hex), f => f.Delete());
            return this;
        }
    }
}