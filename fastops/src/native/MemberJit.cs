//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines operations the JIT a target member that return a pointer to the resulting native bits
    /// </summary>
    public static unsafe class Jit
    {
        /// <summary>
        /// Jits the methd and returns a pointer to the resulting method
        /// </summary>
        /// <param name="src">The soruce method</param>
        [MethodImpl(Inline)]
        public static IntPtr jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }


        [MethodImpl(Inline)]
        public static IntPtr jit(Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return d.Method.MethodHandle.GetFunctionPointer();
        }    


        [MethodImpl(Inline)]
        public static DynamicPointer jit(DynamicDelegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer();
        }
    }
}