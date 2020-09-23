//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Identifies a factory method which, by definition, is an emitter or a unary function
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class)]
    public class EnumApiAttribute : Attribute
    {

        public EnumApiAttribute(Type src)
        {
            EnumType = src;
        }

        public EnumApiAttribute(object src)
        {
            EnumType = src.GetType();
        }

        public Type EnumType {get;}
    }
}