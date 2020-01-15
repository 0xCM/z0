//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Emit;
    using System.Runtime.Intrinsics;
    using System.IO;

    using static zfunc;

    public static class NativeX
    {
        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static INativeMemberData CaptureAsm(this MethodInfo m, int buffersize)
            => Native.capture(m,buffersize);

        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static INativeMemberData CaptureAsm(this MethodInfo m)
            => Native.capture(m);

        /// <summary>
        /// Captures jitted x86 data for a method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static INativeMemberData CaptureAsm(this MethodInfo m, Span<byte> buffer)
            => Native.capture(m,buffer);

        /// <summary>
        /// Captures jitted x86 data for non-generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        public static void CaptureAsm(this IEnumerable<MethodInfo> methods, StreamWriter dst)
            => Native.capture(methods,dst);

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The parameter over which to close the method</typeparam>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static INativeMemberData CaptureGenericAsm(this MethodInfo m, Type arg, Span<byte> buffer)
            => Native.generic(m, arg, buffer);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="buffersize">The size of the buffer that captures data for a single method and which is cleared before each iteration</param>
        public static IEnumerable<INativeMemberData> CaptureGenericAsm(this Type host, Type arg, int buffersize)
            => Native.generic(host,arg,buffersize);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods defined by a specified type
        /// </summary>
        /// <param name="host">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<INativeMemberData> CaptureGenericAsm(this Type host, Type arg)
            => Native.generic(host,arg);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter generic methods
        /// </summary>
        /// <param name="methods">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<INativeMemberData> CaptureGenericAsm(this IEnumerable<MethodInfo> methods, Type arg)
            => Native.generic(methods,arg);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void CaptureGenericAsm(this Type host, Type args, StreamWriter dst)
            => Native.generic(host,args, dst);

        /// <summary>
        /// Captures jitted x86 data for one-parameter generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="arg">The types over which to close each method</param>
        /// <param name="dst">The capture target</param>
        public static void CaptureGenericAsm(this IEnumerable<MethodInfo> methods, Type arg, StreamWriter dst)
            => Native.generic(methods,arg,dst);
            
        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static INativeMemberData CaptureGenericAsm(this MethodInfo m, Type arg)
            => Native.generic(m, arg, new byte[NativeReader.DefaultBufferLen]);

        /// <summary>
        /// Captures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffersize">The size of the buffer used to capture the nated data</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static INativeMemberData CaptureDelegateAsm(this Delegate d, int buffersize)
            => Native.capture(d,buffersize);

        /// <summary>
        /// Captures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static INativeMemberData CaptureDelegateAsm(this Delegate d, Span<byte> buffer)
            => Native.capture(d,buffer);
 
        /// <summary>
        /// JIT's the method and returns a pointer to the native body
        /// </summary>
        /// <param name="m">The method to JIT</param>
        public static IntPtr Prepare(this MethodInfo m)
        {   
            RuntimeHelpers.PrepareMethod(m.MethodHandle);
            var ptr = m.MethodHandle.GetFunctionPointer();
            return ptr;
        }    

        /// <summary>
        /// JIT's the delegate and returns a pointer to the native body
        /// </summary>
        /// <param name="d">The delegate to JIT</param>
        public static void Prepare(this Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
        }

        public static byte[] CilBody(this MethodInfo src)
            => src.GetMethodBody().GetILAsByteArray();

        /// <summary>
        /// JIT's the delegate and returns a pointer to the native body
        /// </summary>
        /// <param name="d">The delegate to JIT</param>
        public static unsafe byte* Jit(this Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return (byte*)d.Method.MethodHandle.GetFunctionPointer();
        }    

        public static IntPtr Jit(this MethodBase method)
        {
            RuntimeHelpers.PrepareMethod(method.MethodHandle);
            return method.MethodHandle.GetFunctionPointer();
        }

        public static void JitMethods(this IEnumerable<MethodBase> methods)
        {
            foreach(var m in methods)
                m.Jit();                
        } 

    }
}