//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    partial class XTend
    {
        public static object[] Values(this FieldInfo[] src, object o = null)
            => src.Select(x => x.GetValue(o));

        public static T[] Values<T>(this FieldInfo[] src, object o = null)
            => src.Select(x => x.GetValue(o)).Where(x => x is T).Cast<T>();
    }
}