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

    public readonly struct IdentifiedMethod : ITextual
    {
        public OpIdentity Id {get;}

        public MethodInfo Method {get;}

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

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedMethod((OpIdentity id, MethodInfo method) src)
            => new IdentifiedMethod(src.id,src.method);
    }
}