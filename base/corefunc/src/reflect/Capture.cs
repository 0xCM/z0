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
    using System.IO;

    using static zfunc;

    public static class NativeCapture
    {
        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static MethodData capture(MethodInfo m, int buffersize)
        {
            var buffer = new byte[buffersize];
            return MethodReader.read(m, buffer);
        }

        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static MethodData capture(MethodInfo m)
            => capture(m,MethodReader.DefaultBufferLen);

        /// <summary>
        /// Captures jitted x86 data for a method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static MethodData capture(MethodInfo m, Span<byte> buffer)
            => MethodReader.read(m, buffer);

        /// <summary>
        /// Captures jitted x86 data for non-generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        public static void capture(IEnumerable<MethodInfo> methods, StreamWriter dst)
        {
            var buffer = new byte[MethodReader.DefaultBufferLen];
            foreach(var m in methods)
            {                
                var data = MethodReader.read(m,buffer);
                dst.WriteLine(data.Format(4));                            
            }
        }

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static MethodData generic(MethodInfo m, Type arg)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return MethodReader.generic(def, arg);
        }

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static MethodData generic(MethodInfo m, Type arg, Span<byte> buffer)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return MethodReader.generic(def, arg, buffer);
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<MethodData> generic(IEnumerable<MethodInfo> methods, Type arg)
        {
            var buffer = new byte[MethodReader.DefaultBufferLen];
            foreach(var m in methods)                
                yield return generic(m,arg,buffer);                    
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="arg">The type over which to close each method</param>
        /// <param name="buffersize">The size of the buffer that captures data for a single method 
        /// and which is cleared at the start of each iteration</param>
        public static IEnumerable<MethodData> generic(Type host, Type arg, int buffersize)
        {
            var buffer = new byte[buffersize];
            foreach(var m in MethodReader.generic(host, arg, buffer))
                yield return m;                    
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<MethodData> generic(Type host, Type arg)
            => generic(host, arg, MethodReader.DefaultBufferLen);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void generic(Type host, Type arg, StreamWriter dst)
        {
            dst.WriteLine($"; {DateTime.Now.ToLexicalString()}");
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
            var buffer = new byte[MethodReader.DefaultBufferLen];
            foreach(var m in methods)
            {                
                var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
                var data = MethodReader.generic(def, arg, buffer);
                dst.WriteLine(data.Format(4));                            
            }
        }

    }

    public static class CaptureX
    {
        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static MethodData CaptureAsm(this MethodInfo m, int buffersize)
            => NativeCapture.capture(m,buffersize);

        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static MethodData CaptureAsm(this MethodInfo m)
            => NativeCapture.capture(m);

        /// <summary>
        /// Captures jitted x86 data for a method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static MethodData CaptureAsm(this MethodInfo m, Span<byte> buffer)
            => NativeCapture.capture(m,buffer);

        /// <summary>
        /// Captures jitted x86 data for non-generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        public static void CaptureAsm(this IEnumerable<MethodInfo> methods, StreamWriter dst)
            => NativeCapture.capture(methods,dst);

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The parameter over which to close the method</typeparam>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static MethodData CaptureGenericAsm(this MethodInfo m, Type arg, Span<byte> buffer)
            => NativeCapture.generic(m, arg, buffer);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="buffersize">The size of the buffer that captures data for a single method and which is cleared before each iteration</param>
        public static IEnumerable<MethodData> CaptureGenericAsm(this Type host, Type arg, int buffersize)
            => NativeCapture.generic(host,arg,buffersize);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods defined by a specified type
        /// </summary>
        /// <param name="host">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<MethodData> CaptureGenericAsm(this Type host, Type arg)
            => NativeCapture.generic(host,arg);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter generic methods
        /// </summary>
        /// <param name="methods">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<MethodData> CaptureGenericAsm(this IEnumerable<MethodInfo> methods, Type arg)
            => NativeCapture.generic(methods,arg);

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void CaptureGenericAsm(this Type host, Type args, StreamWriter dst)
            => NativeCapture.generic(host,args, dst);

        /// <summary>
        /// Captures jitted x86 data for one-parameter generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="arg">The types over which to close each method</param>
        /// <param name="dst">The capture target</param>
        public static void CaptureGenericAsm(this IEnumerable<MethodInfo> methods, Type arg, StreamWriter dst)
            => NativeCapture.generic(methods,arg,dst);
            
        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static MethodData CaptureGenericAsm(this MethodInfo m, Type arg)
            => m.CaptureGenericAsm(arg,new byte[MethodReader.DefaultBufferLen]);        

        /// <summary>
        /// Captures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffersize">The size of the buffer used to capture the nated data</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static DelegateData CaptureDelegateAsm(this Delegate d, int buffersize)
        {
            var buffer = new byte[buffersize];
            return MethodReader.read(d, buffer);
        }    

        /// <summary>
        /// Captures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static DelegateData CaptureDelegateAsm(this Delegate d, Span<byte> buffer)
            => MethodReader.read(d, buffer);
    }
}