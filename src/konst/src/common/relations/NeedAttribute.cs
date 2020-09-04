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

    public readonly struct NeedAttribute
    {
        public readonly asci32 Need;

        public readonly variant Value;

        [MethodImpl(Inline)]
        public static implicit operator NeedAttribute((asci32 need, variant value) src)
            => new NeedAttribute(src.need, src.value);

        [MethodImpl(Inline)]
        public NeedAttribute(asci32 need, variant value)
        {
            Need = need;
            Value = value;
        }
    }
}