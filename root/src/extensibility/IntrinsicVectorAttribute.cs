//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Applied to a user-defined type to identify it as an intrinsic vector (or, rather, should be treated/classified as one)
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class IntrinsicVectorAttribute : Attribute
    {
        public static bool Test(Type src)
            => Attribute.IsDefined(src, typeof(IntrinsicVectorAttribute));

        public IntrinsicVectorAttribute(int width)
        {
            this.Width = width;
        }

        /// <summary>
        /// The vector width
        /// </summary>
        public BitSize Width {get;}
    }

}