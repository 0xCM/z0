//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using A = PartIdAttribute;

    partial struct Part
    {
        /// <summary>
        /// Retrieves the part identifier, if any, of a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static PartId id(Assembly src)
        {
            if(src != null && test(src))
                return ((A)Attribute.GetCustomAttribute(src, typeof(A))).Id;
            else
                return PartId.None;
        }
    }
}