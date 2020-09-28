//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using Xed;

    partial struct XedContext
    {
        public static XedContext create()
            => new XedContext(data());

        [MethodImpl(Inline), Op]
        public static ClrTypes types()
            => types(Assembly.GetExecutingAssembly());

        [MethodImpl(Inline), Op]
        public static ClrTypes types(Assembly a)
            => Reflex.index(a.GetTypes());
    }
}