//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;
    using static Konst;

    [ApiHost(ApiNames.Scripts, true)]
    public readonly partial struct Scripts
    {
        static Symbol PathSep => '\\';

        const BindingFlags MemberSelector = BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly;
    }
}