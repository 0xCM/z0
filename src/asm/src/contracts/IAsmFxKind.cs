//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IAsmFxKind : IKind, ITextual
    {

    }

    public interface IAsmFxKind<K> : IAsmFxKind, IKinded<K>
        where K : unmanaged, Enum
    {

    }
}