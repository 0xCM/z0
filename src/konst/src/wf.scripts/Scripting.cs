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
    public readonly partial struct CmdScripts
    {
        const NumericKind Closure = UnsignedInts;

        static ScriptSymbol PathSep => '\\';

        const BindingFlags MemberSelector = BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly;
    }
}