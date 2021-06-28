//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;

    partial struct ApiIdentity
    {
        /// <summary>
        /// Defines the name of an api member predicated on a tag, if present, or the metadata-defined name if not
        /// </summary>
        /// <param name="m">The source method</param>
        [Op]
        public static string name(MethodInfo m)
        {
            var attrib = m.Tag<OpAttribute>();

            if(attrib.IsNone())
                return m.Name;
            else
            {
                var name = attrib.Value.GroupName;
                if(empty(name))
                    return m.Name;
                else
                    return name;
            }
        }
    }
}