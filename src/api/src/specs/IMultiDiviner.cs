//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IMultiDiviner : ITypeIdentityDiviner, IMethodIdentityDiviner, IDelegateIdentityDiviner
    {
        OpIdentity Identify(MethodInfo src)
            => DivineIdentity(src);

        TypeIdentity Identify(Type src)
            => DivineIdentity(src);

        OpIdentity Identify(Delegate src)
            => DivineIdentity(src);

        GenericOpIdentity GenericIdentity(MethodInfo src);
    }
}