//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    readonly struct Msg
    {
        public static RenderPattern<Type,Type> ContractMismatch => "The source type {0} does not reify {1}";
    }
}