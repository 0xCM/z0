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

    public readonly struct TableSet
    {
        readonly Type[] TableTypes;

        [MethodImpl(Inline)]
        public TableSet(Type[] types)
        {
            TableTypes = types;
        }
    }
}