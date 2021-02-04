//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct IdentifiedMethod<I> : ITextual, IIdentified<I>
        where I : unmanaged
    {
        public I Id {get;}

        public readonly MethodInfo Method;

        [MethodImpl(Inline)]
        public IdentifiedMethod(I id, MethodInfo method)
        {
            Id = id;
            Method = method;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Id.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedMethod<I>((I id, MethodInfo method) src)
            => new IdentifiedMethod<I>(src.id, src.method);
    }
}