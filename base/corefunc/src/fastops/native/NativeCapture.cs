//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class NativeCapture
    {
        /// <summary>
        /// Emits x86 encoded assembly that reifies a delegate to a caller-supplied buffer
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="dst">The target buffer</param>
        public static MemberCapture capture(Delegate src, Span<byte> dst)
            => NativeReader.read(src, dst);

        /// <summary>
        /// Emits x86 encoded assembly that reifies a delegate to a caller-supplied writer
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="dst">The target writer</param>
        public static void capture(Delegate src, INativeWriter dst)
        {
            var data = capture(src, dst.TakeBuffer());
            dst.WriteData(data);    
        }

        /// <summary>
        /// Emits x86 encoded assembly that reifies a method to a caller-supplied buffer
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="dst">The target buffer</param>
        public static MemberCapture capture(MethodInfo src, Span<byte> dst)
            => NativeReader.read(src, dst);

        /// <summary>
        /// Emits x86 encoded assembly that reifies a method to a caller-supplied writer
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="dst">The target writer</param>
        public static void capture(MethodInfo src, INativeWriter dst)
            => dst.WriteData(capture(src,dst.TakeBuffer()));

        /// <summary>
        /// Emits x86 encoded assembly that reifies a stream of methods to a caller-supplied writer
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        public static void capture(IEnumerable<MethodInfo> methods, INativeWriter dst)
        {
            foreach(var m in methods)
                capture(m,dst);
        }

        /// <summary>
        /// Captures jitted x86 data for static non-generic methods defined by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void capture(Type host, INativeWriter dst)
            => capture(host.DeclaredMethods().Public().Static().NonGeneric(), dst);

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <param name="dst">The buffer to which native data will be written</param>
        public static MemberCapture capture(MethodInfo m, Type arg, Span<byte> dst)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return NativeReader.generic(def, arg, dst);
        }

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <param name="dst">The buffer to which native data will be written</param>
        public static void capture(MethodInfo m, Type arg, INativeWriter dst)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            var data = NativeReader.generic(def, arg, dst.TakeBuffer());
            dst.WriteData(data);
        }

        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        public static IntPtr pointer(DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }

        /// <summary>
        /// Jits the methd and returns a pointer to the resulting method
        /// </summary>
        /// <param name="src">The soruce method</param>
        [MethodImpl(Inline)]
        public static IntPtr jit(MethodBase src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void capture(Type host, Type arg, INativeWriter dst)
        {
            foreach(var data in capture(host,arg))
                dst.WriteData(data);
        }

        /// <summary>
        /// Captures jitted x86 data for one-parameter generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        /// <param name="dst">The capture target</param>
        public static void capture(IEnumerable<MethodInfo> methods, Type arg, INativeWriter dst)
        {
            var buffer = new byte[NativeReader.DefaultBufferLen];
            foreach(var m in methods)
            {                
                var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
                var data = NativeReader.generic(def, arg, buffer);
                dst.WriteData(data);                            
            }
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="arg">The type over which to close each method</param>
        static IEnumerable<MemberCapture> capture(IEnumerable<MethodInfo> methods, Type arg)
        {
            var buffer = new byte[NativeReader.DefaultBufferLen];
            foreach(var m in methods)                
                yield return capture(m,arg,buffer);                    
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        static IEnumerable<MemberCapture> capture(Type host, Type arg)
        {
            foreach(var m in NativeReader.gmethods(host, arg))
                yield return m;                    
        }

    }
}