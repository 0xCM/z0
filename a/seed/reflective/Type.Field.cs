//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static ReflectionFlags;

    partial class XTend
    {
        /// <summary>
        /// Attempts to retrieve a name-identified field from a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="declared">Whether the field is required to be declared by the source type</param>
        public static Option<FieldInfo> Field(this Type src, string name)        
            => src.GetFields(BF_All).FirstOrDefault(f => f.Name == name);
    }
}