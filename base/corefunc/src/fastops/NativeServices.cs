//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;        

    using static zfunc;

    public static class NativeServices
    {
        public static INativeExecBuffer ExecBuffer(int? size = null)
            => NativeExecBuffer.Create(size);

    }

}