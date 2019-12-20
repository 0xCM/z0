//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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

    public static class CaptureX
    {
        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="buffersize">The size of the buffer that captures data for a single method and which is cleared before each iteration</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static IEnumerable<MethodData> CaptureX86Generic<T>(this Type host, int buffersize = MethodReader.DefaultBufferLen)
        {
            var buffer = new byte[buffersize];
            foreach(var m in MethodReader.generic<T>(host,buffer))
                yield return m;                    
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="buffersize">The size of the buffer that captures data for a single method and which is cleared before each iteration</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static IEnumerable<MethodData> CaptureX86Generic(this Type host, Type arg, int buffersize = MethodReader.DefaultBufferLen)
        {
            var buffer = new byte[buffersize];
            foreach(var m in MethodReader.generic(host, arg, buffer))
                yield return m;                    
        }

        /// <summary>
        /// Caputures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static MethodData CaptureX86Generic<T>(this MethodInfo m, Span<byte> buffer)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return MethodReader.generic<T>(def, buffer);
        }

        /// <summary>
        /// Captures jitted x86 data for one-parameter generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="args">The types over which to close each method</param>
        /// <param name="dst">The capture target</param>
        public static void CaptureX86Generics(this IEnumerable<MethodInfo> methods, StreamWriter dst, params Type[] args)
        {
            var buffer = new byte[MethodReader.DefaultBufferLen];
            foreach(var m in methods)
            {                
                var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
                foreach(var arg in args)
                {
                    var data = MethodReader.generic(def, arg, buffer);
                    dst.WriteLine(data.Format(4));                            
                }
            }
        }

        /// <summary>
        /// Captures jitted x86 data for non-generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="args">The types over which to close each method</param>
        /// <param name="dst">The capture target</param>
        public static void CaptureX86(this IEnumerable<MethodInfo> methods, StreamWriter dst)
        {
            var buffer = new byte[MethodReader.DefaultBufferLen];
            foreach(var m in methods)
            {                
                var data = MethodReader.read(m,buffer);
                dst.WriteLine(data.Format(4));                            
            }
        }

        /// <summary>
        /// Captures jitted x86 data for one-parameter generic methods
        /// </summary>
        /// <param name="methods">The methods to capture</param>
        /// <param name="dst">The capture target</param>
        /// <typeparam name="T">The type over which to close each method</typeparam>
        public static void CaptureX86Generic<T>(this IEnumerable<MethodInfo> methods, StreamWriter dst)
            => methods.CaptureX86Generics(dst, typeof(T));
            
        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="dst">The path to the file</param>
        public static void CaptureX86Generics(this Type host, StreamWriter dst,  params Type[] types)
        {
            dst.WriteLine($"; {DateTime.Now.ToLexicalString()}");
            foreach(var type in types)
            foreach(var data in host.CaptureX86Generic(type))
                dst.WriteLine(data.Format(4));
        }

        /// <summary>
        /// Caputures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static MethodData CaptureX86Generic(this MethodInfo m, Type arg, Span<byte> buffer)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return MethodReader.generic(def, arg, buffer);
        }

        /// <summary>
        /// Caputures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static MethodData CaptureX86Generic<T>(this MethodInfo m, int buffersize = MethodReader.DefaultBufferLen)
            => m.CaptureX86Generic<T>(new byte[buffersize]);
        
        /// <summary>
        /// Caputures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffersize">The size of the buffer used to capture the nated data</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static DelegateData CaptureX86Delegate<T>(this T d, int buffersize = MethodReader.DefaultBufferLen)
            where T : Delegate
        {
            var buffer = new byte[buffersize];
            return MethodReader.read(d, buffer);
        }

        /// <summary>
        /// Caputures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static DelegateData CaptureX86Delegate<T>(this T d, Span<byte> buffer)
            where T : Delegate
                => MethodReader.read(d, buffer);

        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static MethodData CaptureX86(this MethodInfo m, int buffersize = MethodReader.DefaultBufferLen)
        {
            var buffer = new byte[buffersize];
            return MethodReader.read(m, buffer);
        }

        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static MethodData CaptureX86(this MethodInfo m, Span<byte> buffer)
            => MethodReader.read(m, buffer);

        /// <summary>
        /// Caputures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static DelegateData CaptureX86(this Delegate d, Span<byte> buffer)
            => MethodReader.read(d, buffer);

    }

}