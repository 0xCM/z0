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

    public interface IMultiDiviner : ITypeIdentityDiviner, IMethodIdentityDiviner, IDelegateIdentityDiviner
    {
        [MethodImpl(Inline)]
        OpIdentity Identify(MethodInfo src)
            => DivineIdentity(src);

        [MethodImpl(Inline)]
        TypeIdentity Identify(Type src)
            => DivineIdentity(src);

        [MethodImpl(Inline)]
        OpIdentity Identify(Delegate src)
            => DivineIdentity(src);

        GenericOpIdentity GenericIdentity(MethodInfo src);
    }
}