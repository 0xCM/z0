//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a stateless service
    /// </summary>
    public class StatelessAttribute : Attribute
    {
        public Type ContractType {get;}

        public StatelessAttribute()
        {
            ContractType = typeof(object);
        }

        public StatelessAttribute(Type src)
        {
            ContractType = src;
        }
    }
}