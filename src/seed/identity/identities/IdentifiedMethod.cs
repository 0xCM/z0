//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct IdentifiedMethod : IFormattable<IdentifiedMethod>
    {
        [MethodImpl(Inline)]
        public static IdentifiedMethod Define(OpIdentity id, MethodInfo method)
            => new IdentifiedMethod(id,method);
        
        public readonly OpIdentity Id;

        public readonly MethodInfo Method;

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedMethod((OpIdentity id, MethodInfo method) src)
            => Define(src.id,src.method);

        [MethodImpl(Inline)]
        public IdentifiedMethod(OpIdentity id, MethodInfo method)
        {
            Id = id;
            Method = method;
        }

        public string Format()
            => Id.ToString();
 
        public override string ToString()
            => Format();
    }
}