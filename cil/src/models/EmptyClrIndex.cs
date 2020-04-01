//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Reflection;
    
    using static Core;

    public readonly struct EmptyClrIndex : IClrIndexer
    {
        public Option<CilFunction> FindCil(int id)
            => none<CilFunction>();

        public Option<MethodInfo> FindMethod(int id)
            => none<MethodInfo>();

        public Option<Type> FindType(int id)
            => none<Type>();
    }

}