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
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Globalization;

    using static zfunc;

    /// <summary>
    /// Defines lookup capability over the asm archive logs
    /// </summary>
    public readonly ref struct AsmLib
    {
        /// <summary>
        /// Materializes an untyped code block from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        public static AsmCode Read(FolderName subfolder, Moniker m)
            => AsmCode.Parse(Paths.AsmHexPath(subfolder, m).ReadText(),m);

        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        public static AsmCode<T> Read<T>(FolderName subfolder, Moniker m, T t = default)
            where T : unmanaged
                => AsmCode.Parse(Paths.AsmHexPath(subfolder, m).ReadText(),m,t);

        /// <summary>
        /// Returns the assembly hex file paths with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="subfolder">The asm log subfolder to search</param>
        /// <param name="match">The match predicate</param>
        public static IEnumerable<FilePath> Files(FolderName subfolder, string match)        
            => Paths.AsmDataDir(subfolder).Files(Paths.AsmHexExt, match);

        /// <summary>
        /// Reads a block of intrinsic assembly code
        /// </summary>
        /// <param name="m">The identifying moniker</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static AsmCode<T> Intrinsic<T>(Moniker m, T t = default)
            where T : unmanaged
                => AsmLib.Read<T>(FolderName.Define("dinx"), m);

    }

}