//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.ClrData;
    
    using static Konst;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static Indexed<Type> interfaces(Type src)                   
            => src.GetInterfaces();

        [MethodImpl(Inline), Op]
        public static InterfaceMapping imap(Type src, Type iface)                   
            => src.GetInterfaceMap(iface);
    }
}