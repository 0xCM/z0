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

    public readonly struct NeedAttribute<S,T>
    {
        public readonly asci32 Name;

        public readonly variant Value;

        public static implicit operator NeedAttribute<S,T>(Paired<asci32,variant> src)
            => new NeedAttribute<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public NeedAttribute(asci32 name, variant value)
        {
            Name = name;
            Value = value;
        }
    }
}