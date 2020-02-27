//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    using static zfunc;

    internal interface IDynamicImmediate : IAsmService
    {
        /// <summary>
        /// Embeds an immediate value within a dynamic method that wraps a call to a method that requires an immediate value
        /// </summary>
        /// <param name="method">The source method that requires an immediate parameter</param>
        /// <param name="imm">The immediate value to embed</param>
        DynamicDelegate Specialize(MethodInfo method, byte imm);
    }

    internal interface IDynamicImmediate<D> : IDynamicImmediate
        where D : Delegate
    {

    }
}