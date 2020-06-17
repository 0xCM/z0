//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public static partial class XTend
    {
        [MethodImpl(Inline)]
        public static PartId Id(this Assembly src)
            =>  Part.id(src);
    }

    public readonly struct Part
    {
        /// <summary>
        /// Retrieves the part identifier, if any, of the entry assembly
        /// </summary>
        public static PartId ExecutingPart        
            => id(Assembly.GetEntryAssembly());
        
        public static PartId CallingPart
            => id(Assembly.GetCallingAssembly());

        /// <summary>
        /// Retrieves the part identifier, if any, of a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        public static PartId id(Assembly src)
        {
            if(Attribute.IsDefined(src, typeof(PartIdAttribute)))
            {
                var attrib = (PartIdAttribute)Attribute.GetCustomAttribute(src, typeof(PartIdAttribute));
                return attrib.Id;
            }
            else return PartId.None;     
        }
    }
}