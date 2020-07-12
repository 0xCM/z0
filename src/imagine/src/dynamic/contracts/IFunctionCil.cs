//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    public interface IFunctionCil
    {
        CilBody ExtractCil(DynamicMethod src)
            => FunctionCil.extract(src);

        CilBody ExtractCil(MethodInfo src)
            => FunctionCil.extract(src);

        CilBody ExtractCil(DynamicDelegate src)
            => FunctionCil.extract(src);

        CilBody ExtractCil<D>(DynamicDelegate<D> src)
            where D : Delegate
                => FunctionCil.extract(src);
    }
}