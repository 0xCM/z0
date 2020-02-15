//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    public class IdentityProviderAttribute : Attribute
    {
        public IdentityProviderAttribute(Type host)
        {
            this.Host = host;
        }

        public Type Host;
    }
}

