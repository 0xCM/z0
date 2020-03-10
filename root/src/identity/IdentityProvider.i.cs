//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IIdentityProvider
    {
        IdentityKind ProviderKind {get;}   
    }
    
    public interface IIdentityProvider<S,T> : IIdentityProvider
        where T : IIdentity
    {

    }

    public class IdentityProviderAttribute : Attribute
    {
        /// <summary>
        /// Use of this constructor implies that the attribution target is the provider
        /// </summary>
        public IdentityProviderAttribute()
        {
            Host = Option.none<Type>();
        }
        
        public IdentityProviderAttribute(Type host)
        {
            this.Host = host;
        }

        public Option<Type> Host;
    }    
}