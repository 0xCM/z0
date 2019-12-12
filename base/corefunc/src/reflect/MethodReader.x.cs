//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public static class MethodReaderX
    {
        public static IEnumerable<MethodData> ReifyGeneric<T>(this Type host)
        {
            var buffer = new byte[4094];
            foreach(var m in MethodReader.generic<T>(host,buffer))
                yield return m;
                    
        }
    }

}