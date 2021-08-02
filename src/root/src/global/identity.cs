//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial struct Root
    {
        public static PartId id(Assembly src)
        {
            if(src != null && Attribute.IsDefined(src, typeof(PartIdAttribute)))
                return ((PartIdAttribute)Attribute.GetCustomAttribute(src, typeof(PartIdAttribute))).Id;
            else
                return PartId.None;
        }
    }
}