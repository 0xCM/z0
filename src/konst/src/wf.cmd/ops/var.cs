//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {
        /// <summary>
        /// Creates a non-valued <see cref='CmdScriptVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        [MethodImpl(Inline), Op]
        public static CmdScriptVar var(CmdVarSymbol symbol)
            => new CmdScriptVar(symbol);

        /// <summary>
        /// Creates a valued <see cref='CmdScriptVar'/>
        /// </summary>
        /// <param name="symbol">The variable symbol</param>
        /// <param name="value">The variable value</param>
        [MethodImpl(Inline), Op]
        public static CmdScriptVar var(CmdVarSymbol symbol, CmdVarValue value)
            => new CmdScriptVar(symbol, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdVar<K> var<K>(K id, in Cell128 value)
            where K : unmanaged
                => new CmdVar<K>(id, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdVar<K> var<K>(K id, string value)
            where K : unmanaged
                => new CmdVar<K>(id, value);
    }
}