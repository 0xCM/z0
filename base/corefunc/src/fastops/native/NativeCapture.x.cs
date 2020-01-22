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

    using static zfunc;

    public static class NativeCaptureX
    {
        /// <summary>
        /// Captures jitted x86 data for a method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="dst">The buffer to which native data will be written</param>
        public static NativeMemberCapture CaptureNative(this MethodInfo m, Span<byte> dst)
            => NativeCapture.capture(m,dst);

        /// <summary>
        /// Captures jitted x86 data for a method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="dst">The buffer to which native data will be written</param>
        public static void CaptureNative(this MethodInfo m, INativeWriter dst)
            => NativeCapture.capture(m,dst);

        /// <summary>
        /// Captures jitted x86 data for public, static, non-generic methods defined by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void CaptureNative(this Type host, INativeWriter dst)
            => NativeCapture.capture(host, dst);

        /// <summary>
        /// Captures jitted x86 data for non-generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        public static void CaptureNative(this IEnumerable<MethodInfo> methods, INativeWriter dst)
            => NativeCapture.capture(methods,dst);

        /// <summary>
        /// Captures jitted x86 delegate data using a caller-supplied buffer
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="dst">The buffer to which native data will be written</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static NativeMemberCapture CaptureNative(this Delegate d, Span<byte> dst)
            => NativeCapture.capture(d,dst);

        /// <summary>
        /// Captures jitted x86 data to a caller-supplied writer
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="dst">The buffer to which native data will be written</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static void CaptureNative(this Delegate d, INativeWriter dst)
            => NativeCapture.capture(d, dst);

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The parameter over which to close the method</typeparam>
        /// <param name="dst">The buffer to which native data will be written</param>
        public static NativeMemberCapture CaptureNative(this MethodInfo m, Type arg, Span<byte> dst)
            => NativeCapture.capture(m, arg, dst);

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static NativeMemberCapture CaptureNative(this MethodInfo m, Type arg)
            => NativeCapture.capture(m, arg, new byte[NativeReader.DefaultBufferLen]);

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static void CaptureNative(this MethodInfo m, Type arg, NativeWriter dst)
            => NativeCapture.capture(m,arg,dst);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods defined by a specified type
        /// </summary>
        /// <param name="host">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<NativeMemberCapture> CaptureNative(this Type host, Type arg)
            => NativeCapture.capture(host,arg);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter generic methods
        /// </summary>
        /// <param name="methods">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<NativeMemberCapture> CaptureNative(this IEnumerable<MethodInfo> methods, Type arg)
            => NativeCapture.capture(methods,arg);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter public static generic methods defined by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void CaptureNative(this Type host, Type args, INativeWriter dst)
            => NativeCapture.capture(host,args, dst);

        /// <summary>
        /// Captures jitted x86 data for one-parameter generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="arg">The types over which to close each method</param>
        /// <param name="dst">The capture target</param>
        public static void CaptureNative(this IEnumerable<MethodInfo> methods, Type arg, INativeWriter dst)
            => NativeCapture.capture(methods,arg,dst);
            
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

        /// <summary>
        /// Allocates a caller-disposed native text writer
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        /// <param name="append">Whether to append to or overwrite an existing file</param>
        public static INativeWriter NativeWriter(this FilePath dst, bool header = true, bool append = false)
        {
            dst.FolderPath.CreateIfMissing();            
            var exists = dst.Exists();
            var writer = NativeServices.Writer(dst, append);
            if(!exists || !append && header)
                writer.WriteHeader();
            return writer;
        }
    }
}