//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Flow
    {
        [MethodImpl(Inline), Op]
        public static WfToken token(WfPartKind kind, Type src)
            => new WfToken((((uint)src.MetadataToken & MaskLiterals.Lo24u) | ((uint)kind << 24) ) | hash2(src.AssemblyQualifiedName));
    }
}