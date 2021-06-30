//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Cmd
    {
        /// <summary>
        /// Defines option specification prefix and optionally an value qualifier
        /// </summary>
        /// <param name="prefix">The character(s) immediately precede the option name</param>
        /// <param name="qualifier">An optional character that delimits the option name and a specified value</param>
        [MethodImpl(Inline), Factory]
        public static ArgProtocol protocol(ArgPrefix prefix, AsciSymbol qualifier = default)
            => new ArgProtocol(prefix, qualifier == 0 ? AsciCode.Space : qualifier);
    }
}