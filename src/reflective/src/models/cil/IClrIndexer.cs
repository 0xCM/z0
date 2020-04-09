//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;

    public interface IClrIndexer
    {
        Option<CilFunction> FindCil(int id);

        Option<Type> FindType(int id);

        Option<MethodInfo> FindMethod(int id);
    }
}