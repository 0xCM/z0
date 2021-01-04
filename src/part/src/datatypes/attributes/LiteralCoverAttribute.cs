//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a specialized literal cover
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = true)]
    public class IsomorphicAttribute : Attribute
    {
        public IsomorphicAttribute(Type literal)
        {
            LiteralType = literal;
        }

        public Type LiteralType {get;}
    }
}