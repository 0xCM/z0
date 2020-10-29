//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Applied to a type to advertise type literal definitions
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class TypedLiteralProviderAttribute : Attribute
    {
        public TypedLiteralProviderAttribute(Type literal)
        {
            LiteralType = literal;
        }

        /// <summary>
        /// The defining literal type
        /// </summary>
        public Type LiteralType {get;}
    }
}