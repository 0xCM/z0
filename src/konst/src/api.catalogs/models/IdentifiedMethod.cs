//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct IdentifiedMethod : ITextual
    {
        public readonly OpIdentity Id;

        public readonly MethodInfo Method;

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedMethod((OpIdentity id, MethodInfo method) src)
            => new IdentifiedMethod(src.id,src.method);

        [MethodImpl(Inline)]
        public IdentifiedMethod(OpIdentity id, MethodInfo method)
        {
            Id = id;
            Method = method;
        }
        public RuntimeMethodHandle MethodHandle
        {
            [MethodImpl(Inline)]
            get => Method.MethodHandle;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Id.ToString();

        public override string ToString()
            => Format();
    }
}