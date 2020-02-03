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
        /// Emits x86 encoded assembly that reifies a delegate to a caller-supplied writer
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="dst">The target writer</param>
        public static void capture(Delegate src, INativeWriter dst)
            => dst.WriteData(NativeReader.read(src.Identify(), src, dst.TakeBuffer()));    

        /// <summary>
        /// Emits x86 encoded assembly that reifies a method to a caller-supplied writer
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="dst">The target writer</param>
        public static void capture(MethodInfo src, INativeWriter dst)
            => dst.WriteData(NativeReader.read(src.Identify(), src,dst.TakeBuffer()));

        /// <summary>
        /// Emits x86 encoded assembly that reifies a method to a caller-supplied writer
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="dst">The target writer</param>
        public static void capture(OpIdentity id, MethodInfo src, INativeWriter dst)
            => dst.WriteData(NativeReader.read(id, src, dst.TakeBuffer()));

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
        /// <param name="src">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <param name="dst">The buffer to which native data will be written</param>
        public static CapturedMember capture(MethodInfo src, Type[] args, Span<byte> dst)
        {
            var def = src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();
            var m = def.MakeGenericMethod(args);
            return NativeReader.read(m.Identify(), m, dst);
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

        public static void capture(MethodInfo src, Type[] args, INativeWriter dst)
        {
            var def = src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();
            var m = def.MakeGenericMethod(args);
            var data = NativeReader.read(m.Identify(), m, dst.TakeBuffer());
            dst.WriteData(data);                            
        }
    }
}