//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.AsmSpecs;

    using static zfunc;

    /// <summary>
    /// Defines lookup capability over the asm archive logs
    /// </summary>
    public readonly struct AsmCodeArchive : IAsmCodeArchive
    {
        public FolderPath Root {get;}

        public IAsmContext Context {get;}
        
        readonly string Catalog;

        readonly string Subject;

        public static IAsmCodeArchive Create(IAsmContext context, string catalog, string subject)
            => new AsmCodeArchive(context, catalog, subject);

        public static IAsmCodeArchive Create(IAsmContext context, AssemblyId catalog)
            => new AsmCodeArchive(context, catalog);

        public static IAsmCodeArchive Create(IAsmContext context, AssemblyId catalog, string subject)
            => new AsmCodeArchive(context, catalog, subject);

        AsmCodeArchive(IAsmContext context, AssemblyId catalog, string subject)
        {
            this.Catalog = catalog.ToString().ToLower();
            this.Subject = subject;
            this.Context = context;
            this.Root = LogPaths.The.AsmDataDir(RelativeLocation.Define(Catalog, subject));
        }

        AsmCodeArchive(IAsmContext context, AssemblyId catalog)
        {
            this.Catalog = catalog.ToString().ToLower();
            this.Subject = string.Empty;
            this.Context = context;
            this.Root = LogPaths.The.AsmDataDir(FolderName.Define(Catalog));
        }

        AsmCodeArchive(IAsmContext context, string catalog, string subject)
        {
            this.Context = context;
            this.Catalog = catalog;
            this.Subject = subject;
            this.Root = LogPaths.The.AsmDataDir(RelativeLocation.Define(catalog, subject));
        }

        /// <summary>
        /// Enumerates the files in the archive
        /// </summary>
        IEnumerable<FilePath> Files 
            => Root.Files(FileExtensions.Hex,true);
            
        
        /// <summary>
        /// Reads a hex-line formatted file
        /// </summary>
        /// <param name="src">The source file path</param>
        /// <param name="idsep">The id delimiter</param>
        /// <param name="bytesep">The hex byte delimiter</param>
        public IEnumerable<AsmCode> Read(FilePath src, char idsep, char bytesep)
        {
            return Context.HexReader(idsep,bytesep).Read(src);
            // foreach(var line in src.ReadLines())
            // {
            //     var hex = AsmHexLine.Parse(line,idsep,bytesep);
            //     if(hex.OnNone(() => errout($"Could not parse the line {line} from {src}")))
            //         yield return hex.MapRequired(h => AsmCode.Define(h.Id, h.Encoded));
            // }
        }

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
        public IEnumerable<AsmCode> Read(Moniker id)
            => Read(Root + FileName.Define(id, AsmHexLine.FileExt));

        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="id">The identifying moniker</param>
        public Option<AsmCode<T>> Read<T>(Moniker id, T t = default)
            where T : unmanaged
                => Read(Root,id, t);
        
        static Option<AsmCode<T>> Read<T>(FolderPath location, Moniker m, T t = default)
            where T : unmanaged
                => Try(() => AsmCode.Parse(Paths.AsmHexPath(location, m).ReadText(),m,t));

        public IAsmCodeArchive Clear()
        {
            iter(Root.Files(Paths.HexExt), f => f.Delete());
            return this;
        }
    }
}