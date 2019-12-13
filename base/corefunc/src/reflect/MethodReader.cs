//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// Defines basic capabilty to read native data for a jitted method
    /// </summary>
    public static class MethodReader
    {        
        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="bufferlen">The size of the target buffer</param>
        public static MethodData read(MethodInfo m, int bufferlen = 256)
            => read(m, new byte[bufferlen]);
        
        /// <summary>
        /// Runs the jitter over a named method on a type and captures the emitted binary assembly data
        /// </summary>
        /// <param name="name">The name of the method</param>
        /// <param name="bufferlen">The size of the target buffer</param>
        /// <typeparam name="T">The declaring type</typeparam>
        public static MethodData read<T>(string name, int bufferlen = 256)
            => read(method<T>(name),new byte[bufferlen]);

        /// <summary>
        /// Runs the jitter over a named method on a type and captures the emitted binary assembly data
        /// </summary>
        /// <param name="name">The name of the method</param>
        /// <param name="dst">The target buffer</param>
        /// <typeparam name="T">The declaring type</typeparam>
        public static MethodData read<T>(string name, Span<byte> dst)
            => read(method<T>(name), dst);

        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static unsafe MethodData read(MethodInfo m, Span<byte> dst)
        {            
            var pSrc = (byte*)m.Prepare().ToPointer();            
            var pSrcCurrent = pSrc;            
            var endAddress = Capture(pSrc, dst);            
            var startAddress = (ulong)pSrc;
            var bytesRead = (int)(endAddress - startAddress);
            return new MethodData(m, startAddress, endAddress, dst.Slice(0, bytesRead).ToArray());         
        }

        public static unsafe DelegateData read(Delegate d, Span<byte> dst)
        {
            var pSrc = d.Jit();
            var pSrcCurrent = pSrc;            
            var endAddress = Capture(pSrc, dst);            
            var startAddress = (ulong)pSrc;
            var bytesRead = (int)(endAddress - startAddress);
            return new DelegateData(d, startAddress, endAddress, dst.Slice(0, bytesRead).ToArray());                        
        }

        /// <summary>
        /// Closes a generic method definition over a supplied type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        public static MethodData generic(MethodInfo def, Type arg, Span<byte> dst)
            => read(def.MakeGenericMethod(arg), dst);

        /// <summary>
        /// Closes a generic method definition over supplied types and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        public static MethodData generic(MethodInfo def, Type[] args, Span<byte> dst)
            => read(def.MakeGenericMethod(args), dst);

        /// <summary>
        /// Closes a generic method definition over a supplied type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        public static MethodData generic(MethodInfo def, Type arg, int bufferlen = 256)
            => read(def.MakeGenericMethod(arg), new byte[bufferlen]);

        /// <summary>
        /// Closes a generic method definition over supplied type parameters and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        public static MethodData generic(MethodInfo def, Type[] args, int bufferlen = 256)
            => read(def.MakeGenericMethod(args), new byte[bufferlen]);

        /// <summary>
        /// Closes a generic method definition over a parametric type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        /// <typeparam name="T">The type over which to close the method</typeparam>
        public static MethodData generic<T>(MethodInfo def, int bufferlen = 256)
            => read(def.MakeGenericMethod(typeof(T)), new byte[bufferlen]);

        /// <summary>
        /// Closes a generic method definition over a parametric type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        /// <typeparam name="T">The type over which to close the method</typeparam>
        public static MethodData generic<T>(MethodInfo def, Span<byte> buffer)
            => read(def.MakeGenericMethod(typeof(T)), buffer);

        static IEnumerable<MethodInfo> definitions(Type host)
            =>  from m in host.StaticMethods().OpenGeneric()
                let argcount = m.GetGenericArguments().Length
                where argcount == 1
                select m.GetGenericMethodDefinition();

        /// <summary>
        /// Reflects over the static generic methods declared by a type that accept one type argument, closes 
        /// the methods over the supplied parametric type and captures the binary assembly data emitted
        /// by the gitter for the reified methods
        /// </summary>
        /// <param name="host">The declaring type</param>
        /// <param name="captured">Callback to receive captured data</param>
        /// <param name="bufferlen">The length of the staging buffer</param>
        /// <typeparam name="T">The type over which to close the methods</typeparam>
        public static void generic<T>(Type host, Action<MethodInfo,MethodData> captured, int bufferlen = 256)            
            => iter(definitions(host), m => captured(m, MethodReader.generic<T>(m, bufferlen)));

        /// <summary>
        /// Reflects over the static generic methods declared by a type that accept one type argument, closes 
        /// the methods over the supplied parametric type and captures the binary assembly data emitted
        /// by the gitter for the reified methods
        /// </summary>
        /// <param name="host">The declaring type</param>
        /// <param name="buffer">The staging buffer, cleared after each iteration</param>
        /// <typeparam name="T">The type over which to close the methods</typeparam>
        public static IEnumerable<MethodData> generic<T>(Type host, byte[] buffer)            
        {
            foreach(var m in definitions(host))
                yield return MethodReader.generic<T>(m, buffer);                
        }

        /// <summary>
        /// Closes a generic type definition over a supplied type, reflects the declared static methods, and captures 
        /// the binary assembly data emitted by the jitter for the reified methods
        /// </summary>
        /// <param name="def">The generic type definition, obtained by typeof(generictype<>).GetGenericTypeDefinition()</param>
        /// <param name="arg">The type over which to close the generic type</param>
        /// <param name="captured">Callback to receive captured data</param>
        /// <param name="bufferlen">The length of the staging buffer</param>
        public static void generic(Type def, Type arg, Action<MethodInfo,MethodData> captured, int bufferlen = 256)
        {
            var type = def.MakeGenericType(arg);
            var methods = type.StaticMethods().ToArray();
            Span<byte> buffer = new byte[bufferlen];
            for(var i=0; i<methods.Length; i++)
            {
                var method = methods[i];
                var data = MethodReader.read(method, buffer);
                captured(method,data);
                
                buffer.Clear();
            }
        }

        // Determined by inspection to detect the end of a method; seems to work
        static ReadOnlySpan<byte> Footer
            => new byte[8]{0x19, 0x0, 0x0, 0x0, 0x40, 0x0, 0x0, 0x0};

        internal static unsafe ulong Capture(byte* pSrc, Span<byte> dst)
        {
            var maxcount = dst.Length;
            var offset = 0;
            var pSrcCurrent = pSrc;    
            var footer = Footer.TakeUInt64();        
            while(offset < maxcount)
            {
                Read(pSrcCurrent++, ref dst[offset++]);

                if(offset >= 9)
                {
                    var i = (offset - 1) - 8;
                    if(dst.Slice(i,8).TakeUInt64() == footer)
                        return ((ulong)pSrcCurrent) - 9;                        
                }                    
            }
            return (ulong)pSrcCurrent;
        }

        [MethodImpl(Inline)]
        static unsafe ref byte Read(byte* pByte, ref byte dst)
        {
            dst = Unsafe.Read<byte>(pByte);
            return ref dst;
        }
    }

}