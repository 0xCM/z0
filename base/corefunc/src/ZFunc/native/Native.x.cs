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

        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        public static IntPtr GetFunctionPointer(this DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }

        public static unsafe DynamicPointer GetDynamicPointer(this DynamicDelegate src)
        {
            var ptr = src.DynamicMethod.GetFunctionPointer();
            return new DynamicPointer(src, (byte*)ptr.ToPointer());
        }

        public static unsafe DynamicPointer GetDynamicPointer<D>(this DynamicDelegate<D> src)
            where D : Delegate
        {
            var ptr = src.DynamicMethod.GetFunctionPointer();
            return new DynamicPointer(src, (byte*)ptr.ToPointer());
        }

        /// <summary>
        /// See https://stackoverflow.com/questions/4148297/resolving-the-tokens-found-in-the-il-from-a-dynamic-method/35711376#35711376
        /// </summary>
        public static byte[] CilBody(this DynamicMethod src)
        {
            
            var resolver = typeof(DynamicMethod).GetField("m_resolver", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
            if (resolver == null) throw new ArgumentException("The dynamic method's IL has not been finalized.");
            return (byte[])resolver.GetType().GetField("m_code", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(resolver);
        }

        public static byte[] CilBody(this DynamicDelegate src)
            => src.DynamicMethod.CilBody();

        public static byte[] CilBody<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => src.DynamicMethod.CilBody();

        public static byte[] CilBody(this MethodInfo src)
            => src.GetMethodBody().GetILAsByteArray();

        public static CilFunction CilFunc(this DynamicMethod src)
            => CilFunction.From(src);

        public static CilFunction CilFunc(this DynamicDelegate src)
            => src.DynamicMethod.CilFunc();

        public static CilFunction CilFunc<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => src.DynamicMethod.CilFunc();

        /// <summary>
        /// JIT's the delegate and returns a pointer to the native body
        /// </summary>
        /// <param name="d">The delegate to JIT</param>
        public static DynamicPointer Jit(this DynamicDelegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer();
        }

        /// <summary>
        /// JIT's the delegate and returns a pointer to the native body
        /// </summary>
        /// <param name="d">The delegate to JIT</param>
        public static DynamicPointer Jit<D>(this DynamicDelegate<D> d)
            where D : Delegate
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer();
        }

        /// <summary>
        /// JIT's the delegate and returns a pointer to the native body
        /// </summary>
        /// <param name="d">The delegate to JIT</param>
        public static unsafe byte* Jit(this Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return (byte*)d.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        public static IntPtr Jit(this MethodBase method)
        {
            RuntimeHelpers.PrepareMethod(method.MethodHandle);
            return method.MethodHandle.GetFunctionPointer();
        }

        public static void JitMethods(this IEnumerable<MethodBase> methods)
        {
            foreach(var m in methods)
            {
                m.Jit();                
            }
        } 

        static string MethodSep => new string('_',80);

        public static string Format<T>(this T data, int linebytes = 8, bool linelabels = true)
            where T : INativeMemberData
        {
            if(data.IsEmpty)
                return "<no_data>";

            var format = text();
            var range = bracket(concat(data.StartAddress.FormatHex(false,true), AsciSym.Comma, data.EndAddress.FormatHex(false,true)));
            format.AppendLine($"; function: {data.Method.Signature().Format()}");
            format.AppendLine($"; location: {range}, code length: {data.Length} bytes");

            for(ushort i=0; i< data.Length; i++)
            {
                if(i % linebytes == 0)
                {
                    if(i != 0)
                        format.AppendLine();

                    if(linelabels)
                    {
                        format.Append(i.FormatHex(true,false));
                        format.Append(AsciLower.h);
                        format.Append(AsciSym.Space);
                    }
                }
                format.Append(data.Content[i].FormatHex(true, true));
                format.Append(AsciSym.Space);
            }
            format.AppendLine();   
            format.AppendLine(MethodSep);
            return format.ToString();
        }         
    }
}