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
        public static Option<object> Write(this PropertyInfo p, object src, object dst)
        {
            try
            {
                p.SetValue(dst,src);
                return dst;
            }
            catch(Exception e)
            {
                Console.Error.Write(e);
                return default;
            }
        }
    }
}