//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;
    using static CmdVarTypes;

    partial struct WfScripts
    {
        /// <summary>
        /// Creates a non-valued <see cref='DirVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        [MethodImpl(Inline), Op]
        public static DirVar dir(CmdVarSymbol symbol)
            => new DirVar(symbol);

        /// <summary>
        /// Creates a valued <see cref='DirVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        /// <param name="value">The variable value</param>
        [MethodImpl(Inline), Op]
        public static DirVar dir(CmdVarSymbol symbol, FS.FolderPath value)
            => new DirVar(symbol, value);
    }
}