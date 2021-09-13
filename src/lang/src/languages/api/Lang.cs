//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct Lang
    {
        [MethodImpl(Inline), Op]
        internal static LangIdentifier identifier(LangKind kind, string name)
            => new LangIdentifier(kind,name);
    }
}