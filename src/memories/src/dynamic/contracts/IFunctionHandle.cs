//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    public interface IFunctionHandle
    {
        RuntimeMethodHandle Handle(DynamicMethod src)
            => FunctionHandle.from(src);

        RuntimeMethodHandle Handle(MethodInfo src)
            => FunctionHandle.from(src);

        RuntimeMethodHandle Handle(Delegate src)
            => FunctionHandle.from(src);

        MethodBase Method(RuntimeMethodHandle src)
            => FunctionHandle.from(src);
    }
}