//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum VisibilityKind : byte
    {
        None = 0,

        Public = 1,

        Protected = 2,

        Private = 4,

        Internal = 8,
    }
}