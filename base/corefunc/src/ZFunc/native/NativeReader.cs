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
    public static class NativeReader
    {        
        internal const int DefaultBufferLen = 512;

        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="bufferlen">The size of the target buffer</param>
        public static INativeMemberData read(MethodInfo m)
        {            
            var data = read(m, new byte[DefaultBufferLen]);
            return data;
        }
        
        /// <summary>
        /// Runs the jitter over a named method on a type and captures the emitted binary assembly data
        /// </summary>
        /// <param name="name">The name of the method</param>
        /// <param name="bufferlen">The size of the target buffer</param>
        /// <typeparam name="T">The declaring type</typeparam>
        public static INativeMemberData read<T>(string name)
            => read(method<T>(name),new byte[DefaultBufferLen]);

        /// <summary>
        /// Runs the jitter over a named method on a type and captures the emitted binary assembly data
        /// </summary>
        /// <param name="name">The name of the method</param>
        /// <param name="dst">The target buffer</param>
        /// <typeparam name="T">The declaring type</typeparam>
        public static INativeMemberData read<T>(string name, Span<byte> dst)
            => read(method<T>(name), dst);

        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static unsafe INativeMemberData read(MethodInfo m, Span<byte> dst)
        {            
            try
            {
                var pSrc = (byte*)m.Prepare().ToPointer();            
                var pSrcCurrent = pSrc;            
                var start = (ulong)pSrc;
                var end = capture(pSrc, dst);            
                var bytesRead = (int)(end - start);
                var code = dst.Slice(0, bytesRead).ToArray();
                return new NativeMethodData(m, start, end, code);         
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
            var pSrc = d.Jit().Pointer;
            var pSrcCurrent = pSrc;
            var start = (ulong)pSrc;         
            var end = capture(pSrc, dst);   
            var bytesRead = (int)(end - start);
            var code = dst.Slice(0, bytesRead).ToArray();
            return new NativeMethodData(d.SourceMethod, start, end, code);
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
                var pSrc = d.Jit();
                var pSrcCurrent = pSrc;            
                var start = capture(pSrc, dst);            
                var end = (ulong)pSrc;
                var bytesRead = (int)(start - end);
                var code = dst.Slice(0, bytesRead).ToArray();
                return new NativeDelegateData(d, end, start, code);                        
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
        /// Closes a generic method definition over supplied types and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        public static INativeMemberData generic(MethodInfo def, Type[] args, Span<byte> dst)
            => read(def.MakeGenericMethod(args), dst);

        /// <summary>
        /// Closes a generic method definition over a supplied type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        public static INativeMemberData generic(MethodInfo def, Type arg, int bufferlen)
            => read(def.MakeGenericMethod(arg), new byte[bufferlen]);

        /// <summary>
        /// Closes a generic method definition over a supplied type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        public static INativeMemberData generic(MethodInfo def, Type arg)
            => generic(def, arg, DefaultBufferLen);

        /// <summary>
        /// Closes a generic method definition over supplied type parameters and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        public static INativeMemberData generic(MethodInfo def, Type[] args, int bufferlen)
            => read(def.MakeGenericMethod(args), new byte[bufferlen]);

        /// <summary>
        /// Closes a generic method definition over a parametric type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        /// <typeparam name="T">The type over which to close the method</typeparam>
        public static INativeMemberData generic<T>(MethodInfo def, int bufferlen)
            => read(def.MakeGenericMethod(typeof(T)), new byte[bufferlen]);

        /// <summary>
        /// Closes a generic method definition over a parametric type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        /// <typeparam name="T">The type over which to close the method</typeparam>
        public static INativeMemberData generic<T>(MethodInfo def, Span<byte> buffer)
            => read(def.MakeGenericMethod(typeof(T)), buffer);

        /// <summary>
        /// Reflects over the static generic methods declared by a type that accept one type argument, closes 
        /// the methods over the supplied parametric type and captures the binary assembly data emitted
        /// by the gitter for the reified methods
        /// </summary>
        /// <param name="host">The declaring type</param>
        /// <param name="captured">Callback to receive captured data</param>
        /// <param name="bufferlen">The length of the staging buffer</param>
        /// <typeparam name="T">The type over which to close the methods</typeparam>
        public static void generic<T>(Type host, Action<MethodInfo,INativeMemberData> captured, int bufferlen)            
            => iter(definitions(host), m => captured(m, NativeReader.generic<T>(m, bufferlen)));

        /// <summary>
        /// Reflects over the static generic methods declared by a type that accept one type argument, closes 
        /// the methods over the supplied parametric type and captures the binary assembly data emitted
        /// by the gitter for the reified methods
        /// </summary>
        /// <param name="host">The declaring type</param>
        /// <param name="arg">The type over which to close each method</param>
        /// <param name="buffer">The staging buffer, cleared after each iteration</param>
        /// <typeparam name="T">The type over which to close the methods</typeparam>
        public static IEnumerable<INativeMemberData> generic(Type host, Type arg, byte[] buffer)            
        {
            foreach(var m in definitions(host))
                yield return NativeReader.generic(m,arg, buffer);                
        }

        /// <summary>
        /// Closes a generic type definition over a supplied type, reflects the declared static methods, and captures 
        /// the binary assembly data emitted by the jitter for the reified methods
        /// </summary>
        /// <param name="def">The generic type definition, obtained by typeof(generictype<>).GetGenericTypeDefinition()</param>
        /// <param name="arg">The type over which to close the generic type</param>
        /// <param name="captured">Callback to receive captured data</param>
        /// <param name="bufferlen">The length of the staging buffer</param>
        public static void generic(Type def, Type arg, Action<MethodInfo,INativeMemberData> captured, int bufferlen = DefaultBufferLen)
        {
            var type = def.MakeGenericType(arg);
            var methods = type.StaticMethods().ToArray();
            Span<byte> buffer = new byte[bufferlen];
            for(var i=0; i<methods.Length; i++)
            {
                var method = methods[i];
                var data = NativeReader.read(method, buffer);
                captured(method,data);
                
                buffer.Clear();
            }
        }

        static IEnumerable<MethodInfo> definitions(Type host)
            =>  from m in host.StaticMethods().OpenGeneric()
                let argcount = m.GetGenericArguments().Length
                where argcount == 1
                select m.GetGenericMethodDefinition();

        [MethodImpl(Inline)]
        static unsafe ref byte Read(byte* pByte, ref byte dst)
        {
            dst = Unsafe.Read<byte>(pByte);
            return ref dst;
        }

        internal static unsafe ulong capture(byte* pSrc, Span<byte> dst)
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

                    // if((x0 == ZED && x1 == ZED && x2 == ZED && x3 == ZED))
                    //     return (ulong)pSrcCurrent - 3;
                }                    
            }
            return (ulong)pSrcCurrent;
        }

    }
}