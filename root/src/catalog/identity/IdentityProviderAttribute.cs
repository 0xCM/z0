//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

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

