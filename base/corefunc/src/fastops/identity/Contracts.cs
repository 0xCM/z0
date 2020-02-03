//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;

    public class IdentityProviderAttribute : Attribute
    {
        public IdentityProviderAttribute(Type host)
        {
            this.Host = host;
        }

        public Type Host;
    }

    public interface ITypeIdentityProvider
    {
        TypeIdentity DefineIdentity(Type src);        
    }
    
    public interface IOpIdentityProvider
    {
        OpIdentity DefineIdentity(MethodInfo method);

        OpIdentity GroupIdentity(MethodInfo method);                    

        OpIdentity GenericIdentity(MethodInfo method);                    

        OpIdentity DefineIdentity(MethodInfo method, NumericKind k);
    }

    public interface IOpSpecifier<S>    
        where S : OpSpec
    {
        IEnumerable<S> FromHost(Type host);
    }    
}
