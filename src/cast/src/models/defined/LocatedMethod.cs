//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LocatedMethod
    {
        public MethodInfo Method {get;}

        public MemoryAddress Location {get;}

        [MethodImpl(Inline)]
        public static implicit operator LocatedMethod((MethodInfo method, MemoryAddress location) src)
            => new LocatedMethod(src.method, src.location);

        [MethodImpl(Inline)]
        public LocatedMethod(MethodInfo method, MemoryAddress location)
        {
            Method = method;
            Location = location;
        }
    }
}