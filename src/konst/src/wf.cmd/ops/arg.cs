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
        /// Defines a <see cref='CmdArg'/>
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="value">The option value</param>
        [MethodImpl(Inline), Op]
        public static CmdArg arg(string name, string value)
            => new CmdArg(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(ushort pos, ArgPrefix prefix, string name, ArgQualifier qualifier, T value)
            => new CmdArg<T>(pos, prefix, name, qualifier, value);

        [Op]
        public static CmdArg arg(string name, string[] values)
            => new CmdArg(name, values.Concat(';'));

        /// <summary>
        /// Defines a <see cref='CmdArg{T}'/> predicated on a positional value
        /// </summary>
        /// <param name="pos">The argument position</param>
        /// <param name="value">The argument value</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(ushort pos, T value)
            => new CmdArg<T>(pos, value);

        /// <summary>
        /// Defines a <see cref='CmdArg{K,T}'/>
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="value"></param>
        /// <typeparam name="K">The option kind</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static CmdArg<K,T> arg<K,T>(K kind, T value)
            where K : unmanaged
                => new CmdArg<K,T>(kind,value);
    }
}