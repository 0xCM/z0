//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static Indexed<Type> interfaces(Type src)
            => src.GetInterfaces();

        [MethodImpl(Inline), Op]
        public static ClrInterfaceMap imap(Type host, Type contract)
            => @as<InterfaceMapping,ClrInterfaceMap>(host.GetInterfaceMap(contract));
    }
}