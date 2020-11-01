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

    partial struct Cmd
    {
        /// <summary>
        /// Populates a <see cref='CmdOption'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdOption data<T>(in CmdOption<T> src)
        {
            var dst = new CmdOption();
            data(src,ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdOption'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref CmdOption data<T>(in CmdOption<T> src, ref CmdOption dst)
        {
            dst = new CmdOption(src.Name, src.Value.ToString());
            return ref dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdOption'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The option kind type</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static CmdOption data<K,T>(in CmdOption<K,T> src)
            where K : unmanaged
        {
            var dst = new CmdOption();
            data(src,ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdOption'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="K">The option kind type</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static ref CmdOption data<K,T>(in CmdOption<K,T> src, ref CmdOption dst)
            where K : unmanaged
        {
            dst = new CmdOption(src.Kind.ToString(), src.Value.ToString());
            return ref dst;
        }
    }
}