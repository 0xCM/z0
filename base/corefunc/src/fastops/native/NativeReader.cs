//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines basic capabilty to read native data for a jitted method
    /// </summary>
    public static unsafe class NativeReader
    {        
        public const int DefaultBufferLen = 1024;

        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static INativeMemberData read(MethodInfo m, Span<byte> dst)
        {            
            try
            {
                var pSrc = jit(m);
                var pSrcCurrent = pSrc;            
                var start = (ulong)pSrc;
                var end = capture(pSrc, dst);            
                var bytesRead = (int)(end - start);
                var code = dst.Slice(0, bytesRead).ToArray();
                return NativeMethodData.Define(m, (start, end), code);         
            }
            catch(Exception e)
            {
                error(e);
                return NativeMethodData.Empty;                    
            }
        }

        /// <summary>
        /// Captures native code produced by the JIT for a dynamic delegate
        /// </summary>
        /// <param name="d">The dynamic delegate</param>
        /// <param name="dst">The target buffer</param>
        public static unsafe INativeMemberData read(DynamicDelegate d, Span<byte> dst)
        {
            var pSrc = jit(d);
            var pSrcCurrent = pSrc;
            var start = (ulong)pSrc;         
            var end = capture(pSrc, dst);   
            var bytesRead = (int)(end - start);
            var code = dst.Slice(0, bytesRead).ToArray();
            return NativeMethodData.Define(d.SourceMethod, (start, end), code);
        }
        
        /// <summary>
        /// Runs the jitter on a delegate and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static unsafe INativeMemberData read(Delegate d, Span<byte> dst)
        {
            try
            {
                var pSrc = jit(d);
                var pSrcCurrent = pSrc;            
                var start = (ulong)pSrc;
                var end = capture(pSrc, dst);
                var bytesRead = (int)(end - start);
                var code = dst.Slice(0, bytesRead).ToArray();
                return NativeDelegateData.Define(d, (start, end), code);
            }
            catch(Exception e)
            {
                error(e);
                return NativeDelegateData.Empty;                    
            }
        }

        /// <summary>
        /// Closes a generic method definition over a supplied type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        public static INativeMemberData generic(MethodInfo def, Type arg, Span<byte> dst)
            => read(def.MakeGenericMethod(arg), dst);

        /// <summary>
        /// Reflects over the static generic methods declared by a type that accept one type argument, closes 
        /// the methods over the supplied parametric type and captures the binary assembly data emitted
        /// by the jitter for the reified methods
        /// </summary>
        /// <param name="host">The declaring type</param>
        /// <param name="arg">The type over which to close each method</param>
        /// <param name="buffer">The staging buffer, cleared after each iteration</param>
        /// <typeparam name="T">The type over which to close the methods</typeparam>
        public static IEnumerable<INativeMemberData> gmethods(Type host, Type arg)            
        {
            var buffer = new byte[NativeReader.DefaultBufferLen];     
            var definitions = host.StaticMethods().OpenGeneric(1).Select(m => m.GetGenericMethodDefinition());       
            foreach(var m in definitions)
                yield return NativeReader.generic(m, arg, buffer.Clear());                
        }

        /// <summary>
        /// Closes a generic type definition over a supplied type, reflects the declared static methods, and captures 
        /// the binary assembly data emitted by the jitter for the reified methods
        /// </summary>
        /// <param name="typedef">The generic type definition, obtained by typeof(generictype<>).GetGenericTypeDefinition()</param>
        /// <param name="arg">The type over which to close the generic type</param>
        /// <param name="captured">Callback to receive captured data</param>
        /// <param name="bufferlen">The length of the staging buffer</param>
        public static IEnumerable<INativeMemberData> gtype(Type typedef, Type arg)
        {
            var type = typedef.MakeGenericType(arg);
            var methods = type.StaticMethods().ToArray();
            var buffer = new byte[DefaultBufferLen];
            for(var i=0; i<methods.Length; i++)
                yield return NativeReader.read(methods[i], buffer.Clear());                
        }                

        [MethodImpl(Inline)]
        static byte* jit(MethodInfo m)
        {   
            RuntimeHelpers.PrepareMethod(m.MethodHandle);
            var ptr = m.MethodHandle.GetFunctionPointer();
            return (byte*)ptr.ToPointer();
        }    

        [MethodImpl(Inline)]
        static byte* jit(Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return (byte*)d.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        static byte* jit(DynamicDelegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer().Pointer;
        }

        [MethodImpl(Inline)]
        static DynamicPointer jit<D>(DynamicDelegate<D> d)
            where D : Delegate
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer();
        }

        [MethodImpl(Inline)]
        static ref byte Read(byte* pByte, ref byte dst)
        {
            dst = Unsafe.Read<byte>(pByte);
            return ref dst;
        }

        internal static ulong capture(byte* pSrc, Span<byte> dst)
        {
            const byte ZED = 0;
            const byte RET = 0xc3;
            const byte INTR = 0xcc;
            const byte SBB = 0x19;
 
            var maxcount = dst.Length - 1;
            var pSrcCurrent = pSrc;    
            var offset = 0;
                       
            while(offset < maxcount)
            {
                byte code = 0;
                dst[offset++] = Read(pSrcCurrent++, ref code);   

                if(offset >= 4)
                {
                    var x0 = dst[offset - 3];
                    var x1 = dst[offset - 2];
                    var x2 = dst[offset - 1];
                    var x3 = dst[offset];

                    if(x0 == RET && x1 == SBB)
                        return (ulong)pSrcCurrent - 2;

                    if(x0 == RET && x1 == INTR)
                        return (ulong)pSrcCurrent - 2;

                    if((x0 == RET && x1 == INTR && x2 == INTR))
                        return (ulong)pSrcCurrent - 2;

                    if((x0 == RET && x1 == ZED && x2 == SBB))
                        return (ulong)pSrcCurrent - 2;

                    if(x0 == RET && x1 == ZED && x2 == ZED && x3 == ZED)
                        return (ulong)pSrcCurrent - 2;

                    if((x0 == INTR && x1 == INTR))
                        return (ulong)pSrcCurrent - 2;

                    if((x0 == ZED && x1 == ZED && x2 == SBB))
                        return (ulong)pSrcCurrent - 3;                    
                }

                if(offset >= 5 
                    && (dst[offset - 4] == ZED) 
                    && (dst[offset - 3] == ZED) 
                    && (dst[offset - 2] == ZED) 
                    && (dst[offset - 1] == ZED)                     
                    && (dst[offset - 0] == ZED)                     
                    )
                return (ulong)pSrcCurrent - 4;
            }
            return (ulong)pSrcCurrent;
        }
    }
}