//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public enum Multiplicity : byte
    {
        Unknown = 0,

        ZeroOrOne,

        One,

        MoreThanOne
    }
}