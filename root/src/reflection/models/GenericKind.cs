//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum GenericKind
    {
        None = 0,

        Open = 1,

        Closed = 2,

        Definition
    }

    public static class GenericKindOps
    {            

        [MethodImpl(Inline)]
        public static bool IsSome(this GenericKind kind)
            => kind != GenericKind.None;
    }
}