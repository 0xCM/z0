//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Returns the source method's kind identifier if it exists
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static OpKindId? KindId(this MethodInfo m)
        {
            var attrib = m.Tag<OpKindAttribute>();
            return attrib.IsSome() ? attrib.Value.KindId : (OpKindId?)null;
        }
    }
}