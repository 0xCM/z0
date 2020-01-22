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

    using static zfunc;

    /// <summary>
    /// Defines lookup capability over the asm archive logs
    /// </summary>
    public readonly struct AsmCodeArchive : IAsmCodeArchive
    {
        readonly FolderPath Folder;

        public string Catalog {get;}

        public string Subject {get;}

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
        public Option<AsmCode> ReadCode(Moniker id)
            => Read(Folder, id);
    
        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="id">The identifying moniker</param>
        public Option<AsmCode<T>> ReadCode<T>(Moniker id, T t = default)
            where T : unmanaged
                => Read(Folder,id, t);

        /// <summary>
        /// Returns the assembly hex file paths with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="match">The match predicate</param>
        public IEnumerable<FilePath> CodeFiles(string match)        
            => Folder.Files(Paths.HexExt, match);

        static Option<AsmCode<T>> Read<T>(FolderPath location, Moniker m, T t = default)
            where T : unmanaged
                => Try(() => AsmCode.Parse(Paths.AsmHexPath(location, m).ReadText(),m,t));

        static Option<AsmCode> Read(FolderPath location, Moniker m)
            => Try(() => AsmCode.Parse(Paths.AsmHexPath(location, m).ReadText(),m));

    }
}