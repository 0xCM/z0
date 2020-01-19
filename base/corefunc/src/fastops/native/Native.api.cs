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
    using System.IO;

    using static zfunc;

    public static class Native
    {
        /// <summary>
        /// Captures jitted x86 data for a method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="dst">The buffer to which native data will be written</param>
        public static INativeMemberData capture(MethodInfo m, Span<byte> dst)
            => NativeReader.read(m, dst);

        /// <summary>
        /// Captures jitted x86 data for non-generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        public static void capture(IEnumerable<MethodInfo> methods, StreamWriter dst)
        {
            var buffer = new byte[NativeReader.DefaultBufferLen];
            foreach(var m in methods)
            {                
                var data = NativeReader.read(m,buffer);
                dst.WriteLine(data.Format(4));                            
            }
        }

        /// <summary>
        /// Captures jitted x86 data for static non-generic methods defined by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void capture(Type host, StreamWriter dst)
            => capture(host.DeclaredMethods().Public().Static().NonGeneric(), dst);

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <param name="dst">The buffer to which native data will be written</param>
        public static INativeMemberData generic(MethodInfo m, Type arg, Span<byte> dst)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return NativeReader.generic(def, arg, dst);
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
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<INativeMemberData> generic(IEnumerable<MethodInfo> methods, Type arg)
        {
            var buffer = new byte[NativeReader.DefaultBufferLen];
            foreach(var m in methods)                
                yield return generic(m,arg,buffer);                    
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<INativeMemberData> generic(Type host, Type arg)
        {
            foreach(var m in NativeReader.gmethods(host, arg))
                yield return m;                    
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void generic(Type host, Type arg, StreamWriter dst)
        {
            foreach(var data in generic(host,arg))
                dst.WriteLine(data.Format(4));
        }

        /// <summary>
        /// Captures jitted x86 data for one-parameter generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        /// <param name="dst">The capture target</param>
        public static void generic(IEnumerable<MethodInfo> methods, Type arg, StreamWriter dst)
        {
            var buffer = new byte[NativeReader.DefaultBufferLen];
            foreach(var m in methods)
            {                
                var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
                var data = NativeReader.generic(def, arg, buffer);
                dst.WriteLine(data.Format(4));                            
            }
        }

        /// <summary>
        /// Captures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffersize">The size of the buffer used to capture the nated data</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static INativeMemberData capture(Delegate d, Span<byte> dst)
            => NativeReader.read(d, dst);
    }
}