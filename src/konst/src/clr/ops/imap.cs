//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Clr
    {
        /// <summary>
        /// Queries the host type for a <see cref='ClrInterfaceMap'/>
        /// </summary>
        /// <param name="host">The reifying type</param>
        /// <param name="contract">The contract type</param>
        [MethodImpl(Inline), Op]
        public static ClrInterfaceMap imap(Type host, Type contract)
            => memory.@as<InterfaceMapping, ClrInterfaceMap>(host.InterfaceMap(contract));
    }
}