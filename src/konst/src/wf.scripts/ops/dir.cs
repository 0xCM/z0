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

    partial struct Scripts
    {
        /// <summary>
        /// Creates a non-valued <see cref='ScriptDirVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        [MethodImpl(Inline), Op]
        public static ScriptDirVar dir(ScriptSymbol symbol)
            => new ScriptDirVar(symbol);

        /// <summary>
        /// Creates a valued <see cref='ScriptDirVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        /// <param name="value">The variable value</param>
        [MethodImpl(Inline), Op]
        public static ScriptDirVar dir(ScriptSymbol symbol, FS.FolderPath value)
            => new ScriptDirVar(symbol, value);
    }
}