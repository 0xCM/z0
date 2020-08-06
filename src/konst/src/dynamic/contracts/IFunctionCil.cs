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
        CilCode ExtractCil(DynamicMethod src)
            => FunctionCil.extract(src);

        CilCode ExtractCil(MethodInfo src)
            => FunctionCil.extract(src);

        CilCode ExtractCil(DynamicDelegate src)
            => FunctionCil.extract(src);

        CilCode ExtractCil<D>(DynamicDelegate<D> src)
            where D : Delegate
                => FunctionCil.extract(src);
    }
}