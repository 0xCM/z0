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

    /// <summary>
    /// Captures an attribute relation value
    /// </summary>
    public readonly struct NeedAttribute<T>
    {
        public readonly Need<T> Relation;

        public readonly asci32 Name;

        public readonly variant Value;

        [MethodImpl(Inline)]
        public static implicit operator NeedAttribute<T>((Need<T> r, asci32 name, variant value) src)
            => new NeedAttribute<T>(src.r, src.name, src.value);

        [MethodImpl(Inline)]
        public NeedAttribute(Need<T> r, asci32 name, variant value)
        {
            Relation = r;
            Name = name;
            Value = value;
        }
    }
}