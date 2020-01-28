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
        readonly FolderPath Folder;

        readonly string Catalog;

        readonly string Subject;

        public static IAsmCodeArchive Create(string catalog, string subject)
            => new AsmCodeArchive(catalog, subject);

        AsmCodeArchive(string catalog, string subject)
        {
            this.Catalog = catalog;
            this.Subject = subject;
            this.Folder = LogPaths.The.AsmDataDir(RelativeLocation.Define(catalog, subject));
        }

        /// <summary>
        /// Materializes an untyped code block
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public Option<AsmCode> ReadBlock(Moniker id)
            => Read(Folder, id);
    
        /// <summary>
        /// Reads a hex-line formatted file
        /// </summary>
        /// <param name="src">The source file path</param>
        /// <param name="idsep">The id delimiter</param>
        /// <param name="bytesep">The hex byte delimiter</param>
        public IEnumerable<AsmCode> Read(FilePath src, char idsep, char bytesep)
        {
            foreach(var line in src.ReadLines())
            {
                var hex = AsmHexLine.Parse(line,idsep,bytesep);
                if(hex.OnNone(() => errout($"Could not parse the line {line} from {src}")))
                    yield return hex.MapRequired(h => AsmCode.Define(h.Id, h.Encoded));
            }
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
            => Read(Folder + FileName.Define(id, AsmHexLine.FileExt));

        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="id">The identifying moniker</param>
        public Option<AsmCode<T>> ReadBlock<T>(Moniker id, T t = default)
            where T : unmanaged
                => Read(Folder,id, t);

        /// <summary>
        /// Returns the assembly hex file paths with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="match">The match predicate</param>
        public IEnumerable<FilePath> Files(string match)        
            => Folder.Files(Paths.HexExt, match);

        static Option<AsmCode<T>> Read<T>(FolderPath location, Moniker m, T t = default)
            where T : unmanaged
                => Try(() => AsmCode.Parse(Paths.AsmHexPath(location, m).ReadText(),m,t));

        static Option<AsmCode> Read(FolderPath location, Moniker m)
            => Try(() => AsmCode.Parse(Paths.AsmHexPath(location, m).ReadText(),m));

        public IAsmCodeArchive Clear()
        {
            iter(Folder.Files(Paths.HexExt), f => f.Delete());
            return this;
        }
    }
}