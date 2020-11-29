//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct CmdArgs
    {
        /// <summary>
        /// Populates a <see cref='CmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref CmdArg data<T>(in CmdArg<T> src, ref CmdArg dst)
        {
            dst = new CmdArg(src.Name, src.Value.ToString());
            return ref dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="K">The option kind type</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static ref CmdArg data<K,T>(in CmdArg<K,T> src, ref CmdArg dst)
            where K : unmanaged
        {
            dst = new CmdArg(src.Key.ToString(), src.Value.ToString());
            return ref dst;
        }
    }
}