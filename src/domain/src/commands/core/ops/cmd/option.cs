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
        /// Defines a <see cref='CmdOption'/>
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="value">The option value</param>
        [MethodImpl(Inline), Op]
        public static CmdOption option(string name, string value)
            => new CmdOption(name,value);

        /// <summary>
        /// Defines a <see cref='CmdOption{T}'/>
        /// </summary>
        /// <param name="name">The option identifier</param>
        /// <param name="value">The option value</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdOption<T> option<T>(string name, T value)
            => new CmdOption<T>(name,value);

        /// <summary>
        /// Defines a <see cref='CmdOption{K,T}'/>
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="value"></param>
        /// <typeparam name="K">The option kind</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static CmdOption<K,T> option<K,T>(K kind, T value)
            where K : unmanaged
                => new CmdOption<K,T>(kind,value);
        [Op]
        public static ParseResult<CmdOption> option(string src)
        {
            try
            {
                var i = src.IndexOf(DefaultSpecifier);
                if(i == NotFound)
                    return parsed(src,new CmdOption(src));
                else
                    return parsed(src, new CmdOption(src.LeftOfIndex(i), src.RightOfIndex(i)));
            }
            catch(Exception e)
            {
                return unparsed<CmdOption>(src,e);
            }
        }
    }
}