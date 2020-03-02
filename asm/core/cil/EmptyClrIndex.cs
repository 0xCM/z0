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
    
    using static Root;

    public readonly struct EmptyClrIndex : IClrIndex
    {
        public Option<CilFunction> FindCil(int id)
            => none<CilFunction>();

        public Option<MethodInfo> FindMethod(int id)
            => none<MethodInfo>();

        public Option<Type> FindType(int id)
            => none<Type>();
    }

}