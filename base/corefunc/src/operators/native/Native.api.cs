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

    public static class Native
    {
        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static INativeMemberData capture(MethodInfo m, int buffersize)
        {
            var buffer = new byte[buffersize];
            return NativeReader.read(m, buffer);
        }

        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static INativeMemberData capture(MethodInfo m)
            => capture(m,NativeReader.DefaultBufferLen);

        /// <summary>
        /// Captures jitted x86 data for a method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static INativeMemberData capture(MethodInfo m, Span<byte> buffer)
            => NativeReader.read(m, buffer);

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
        /// Captures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static INativeMemberData generic(MethodInfo m, Type arg)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return NativeReader.generic(def, arg);
        }

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method to a caller-supplied buffer
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <param name="buffer">The buffer to which native data will be written</param>
        public static INativeMemberData generic(MethodInfo m, Type arg, Span<byte> buffer)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return NativeReader.generic(def, arg, buffer);
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
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="arg">The type over which to close each method</param>
        /// <param name="buffersize">The size of the buffer that captures data for a single method 
        /// and which is cleared at the start of each iteration</param>
        public static IEnumerable<INativeMemberData> generic(Type host, Type arg, int buffersize)
        {
            var buffer = new byte[buffersize];
            foreach(var m in NativeReader.generic(host, arg, buffer))
                yield return m;                    
        }

        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to capture</param>
        /// <param name="arg">The type over which to close each method</param>
        public static IEnumerable<INativeMemberData> generic(Type host, Type arg)
            => generic(host, arg, NativeReader.DefaultBufferLen);

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
        public static INativeMemberData capture(Delegate d)
            => NativeReader.read(d, new byte[NativeReader.DefaultBufferLen]);

        /// <summary>
        /// Captures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d">The delegate to capture</param>
        /// <param name="buffersize">The size of the buffer used to capture the nated data</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static INativeMemberData capture(Delegate d, int buffersize)
            => NativeReader.read(d, new byte[buffersize]);

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