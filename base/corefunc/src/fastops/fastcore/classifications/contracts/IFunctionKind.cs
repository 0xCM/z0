//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Characterizes a higher-kinded function
    /// </summary>
    public interface IFunctionKind : IKind<FunctionKind>
    {

    }

    public interface IFunctionKind<K> : IFunctionKind
        where K : IFunctionKind<K>
    {

    }

}
