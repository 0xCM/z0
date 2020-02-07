//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    
    public interface IDynamicImmediate : IAsmService
    {
        /// <summary>
        /// Embeds an immediate value within a dynamic method that wraps a call to a method that requires an immediate value
        /// </summary>
        /// <param name="method">The source method that requires an immediate parameter</param>
        /// <param name="imm">The immediate value to embed</param>
        DynamicDelegate Specialize(MethodInfo method, byte imm);
    }

    public interface IDynamicImmediate<D> : IDynamicImmediate
        where D : Delegate
    {

    }
}