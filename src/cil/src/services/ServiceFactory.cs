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

    public static class ServiceFactory
    {        
        public static IClrIndexer CreateClrIndex(this Assembly src)
            => ClrIndexer.Create(src);
    }
}