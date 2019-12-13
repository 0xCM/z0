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

    using static zfunc;

    public static class MethodReaderX
    {
        /// <summary>
        /// Captures jitted x86 data for 1-parameter static generic methods define by a type
        /// </summary>
        /// <param name="host">The type that defines the methods to deconstruct</param>
        /// <param name="buffersize">The size of the buffer that captures data for a single method and which is cleared before each iteration</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static IEnumerable<MethodData> CaptureX86<T>(this Type host, int buffersize = 1024)
        {
            var buffer = new byte[4094];
            foreach(var m in MethodReader.generic<T>(host,buffer))
                yield return m;                    
        }

        /// <summary>
        /// Caputures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static MethodData CaptureX86<T>(this MethodInfo m, Span<byte> buffer)
        {
            var def = m.IsGenericMethodDefinition ? m : m.GetGenericMethodDefinition();
            return MethodReader.generic<T>(def, buffer);
        }
        
        /// <summary>
        /// Caputures jitted x86 data for a one-parameter generic method
        /// </summary>
        /// <param name="m">The generic method (or definition)</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        /// <typeparam name="T">The parameter over which to close the method</typeparam>
        public static MethodData CaptureX86<T>(this MethodInfo m, int buffersize = 1024)
            => m.CaptureX86<T>(new byte[buffersize]);
        
        /// <summary>
        /// Captures jitted x86 data for a method
        /// </summary>
        /// <param name="m">The method to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the native data</param>
        public static MethodData CaptureX86(this MethodInfo m, int buffersize = 1024)
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
        /// <param name="d">The delegate to deconstruct</param>
        /// <param name="buffersize">The size of the buffer used to capture the nated data</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static DelegateData CaptureX86<T>(this T d, int buffersize = 1024)
            where T : Delegate
        {
            var buffer = new byte[buffersize];
            return MethodReader.read(d, buffer);
        }

        /// <summary>
        /// Caputures jitted x86 data for a delegate
        /// </summary>
        /// <param name="d"></param>
        /// <param name="buffer">The buffer to which native data will be written</param>
        /// <typeparam name="T">The delegate type</typeparam>
        public static DelegateData CaptureX86<T>(this T d, Span<byte> buffer)
            where T : Delegate
                => MethodReader.read(d, buffer);

    }

}