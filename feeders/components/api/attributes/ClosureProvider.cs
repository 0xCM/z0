//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public class ClosureProviderAttribute : Attribute
    {
        public ClosureProviderAttribute(Type provider)
        {
            this.ProviderType = provider;
        }

        public Type ProviderType {get;}
    }

    public interface IClosureProvider : IService
    {
        Type[] GetTypeArguments(MethodInfo definition);
    }

}