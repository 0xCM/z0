//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    public interface IFunctionJit
    {
        LocatedMethod Jit(MethodInfo src)
            => FunctionJit.jit(src);

        IntPtr Jit(Delegate src)
            => FunctionJit.jit(src);

        DynamicPointer Jit(DynamicDelegate src)
            => FunctionJit.jit(src);

        DynamicPointer Jit<D>(DynamicDelegate<D> src)            
            where D : Delegate
                => FunctionJit.jit(src);
    }
}