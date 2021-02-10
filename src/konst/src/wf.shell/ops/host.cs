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

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        public static WfSelfHost host(Type self)
            => new WfSelfHost(self);

        [MethodImpl(Inline), Op]
        public static WfSelfHost host(Name name)
            => new WfSelfHost(name);

    }
}