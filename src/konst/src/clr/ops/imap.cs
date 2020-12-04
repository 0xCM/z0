//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static z;

    partial struct ClrQuery
    {
        /// <summary>
        /// Queries the host type for a <see cref='ClrInterfaceMap'/>
        /// </summary>
        /// <param name="host"></param>
        /// <param name="contract"></param>
        [MethodImpl(Inline), Op]
        public static ClrInterfaceMap imap(Type host, Type contract)
            => @as<InterfaceMapping,ClrInterfaceMap>(host.GetInterfaceMap(contract));
    }
}