//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Applied to a type to identify an applicable conversion provider
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ConversionProviderAttribute : Attribute
    {
        public ConversionProviderAttribute(Type provider)
        {
            ProviderType = provider;
        }

        public readonly Type ProviderType;
    }
}