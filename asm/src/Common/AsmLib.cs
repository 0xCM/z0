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
    public readonly struct AsmLib
    {
        readonly FolderPath Folder;

        public static AsmLib Create(string catalog, string subject)
            => new AsmLib(catalog, subject);

        public AsmLib(string catalog, string subject)
        {
            this.Folder = LogPaths.The.AsmDataDir(RelativeLocation.Define(catalog, subject));
        }

        /// <summary>
        /// Materializes an untyped code block from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        public AsmCode Read(Moniker m)
            => AsmCode.Parse(Paths.AsmHexPath(Folder, m).ReadText(),m);

        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        public AsmCode<T> Read<T>(Moniker m, T t = default)
            where T : unmanaged
                => AsmCode.Parse(Paths.AsmHexPath(Folder, m).ReadText(),m,t);

        /// <summary>
        /// Returns the assembly hex file paths with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="match">The match predicate</param>
        public IEnumerable<FilePath> HexFiles(string match)        
            => Folder.Files(Paths.HexExt, match);

    }
}