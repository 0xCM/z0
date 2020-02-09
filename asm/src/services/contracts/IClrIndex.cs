//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public interface IClrIndex
    {
        Option<CilFunction> FindCil(MethodInfo mi);

        Option<Type> FindType(int id);

        Option<MethodInfo> FindMethod(int id);

    }
}