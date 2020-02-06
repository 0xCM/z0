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

        [MethodImpl(Inline)]
        public static byte* jit(MethodInfo m)
        {   
            RuntimeHelpers.PrepareMethod(m.MethodHandle);
            var ptr = m.MethodHandle.GetFunctionPointer();
            return (byte*)ptr.ToPointer();
        }    

        [MethodImpl(Inline)]
        public static byte* jit(Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return (byte*)d.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        public static byte* jit(DynamicDelegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer().Pointer;
        }

        /// <summary>
        /// Jits the methd and returns a pointer to the resulting method
        /// </summary>
        /// <param name="src">The soruce method</param>
        [MethodImpl(Inline)]
        public static IntPtr jitsafe(MethodBase src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

    }
}