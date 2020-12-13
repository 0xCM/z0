//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XCli
    {
        [MethodImpl(Inline), Op]
        public static ClrMemberIdentity Identity(this PropertyInfo src)
            => new ClrMemberIdentity(src);
    }
}