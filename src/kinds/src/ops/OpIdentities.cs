//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public static class OpIdentities
    {
        public static string name(MethodInfo m)
        {
            var attrib = m.Tag<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;

            var attribVal = attrib.Value;              
            return !string.IsNullOrWhiteSpace(attribVal.Name) ? attribVal.Name : m.Name;                
        }
    }
}