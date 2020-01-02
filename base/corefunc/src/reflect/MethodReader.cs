//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        internal const int DefaultBufferLen = 512;

        const int MaxZeroCount = 3;


        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="bufferlen">The size of the target buffer</param>
        public static MethodData read(MethodInfo m, int bufferlen = DefaultBufferLen)
            => read(m, new byte[bufferlen]);
        
        /// <summary>
        /// Runs the jitter over a named method on a type and captures the emitted binary assembly data
        /// </summary>
        /// <param name="name">The name of the method</param>
        /// <param name="bufferlen">The size of the target buffer</param>
        /// <typeparam name="T">The declaring type</typeparam>
        public static MethodData read<T>(string name, int bufferlen = DefaultBufferLen)
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
            try
            {
                var pSrc = (byte*)m.Prepare().ToPointer();            
                var pSrcCurrent = pSrc;            
                var endAddress = Capture(pSrc, dst);            
                var startAddress = (ulong)pSrc;
                var bytesRead = (int)(endAddress - startAddress);
                var code = dst.Slice(0, bytesRead).ToArray();
                return new MethodData(m, startAddress, endAddress, code);         
            }
            catch(Exception e)
            {
                error(e);
                return MethodData.Empty;                    
            }
        }

        /// <summary>
        /// Runs the jitter on a delegate and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static unsafe DelegateData read(Delegate d, Span<byte> dst)
        {
            try
            {
                var pSrc = d.Jit();
                var pSrcCurrent = pSrc;            
                var endAddress = Capture(pSrc, dst);            
                var startAddress = (ulong)pSrc;
                var bytesRead = (int)(endAddress - startAddress);
                var code = dst.Slice(0, bytesRead).ToArray();
                return new DelegateData(d, startAddress, endAddress, code);                        
            }
            catch(Exception e)
            {
                error(e);
                return DelegateData.Empty;                    
            }
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
        public static MethodData generic(MethodInfo def, Type arg, int bufferlen = DefaultBufferLen)
            => read(def.MakeGenericMethod(arg), new byte[bufferlen]);

        /// <summary>
        /// Closes a generic method definition over supplied type parameters and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        public static MethodData generic(MethodInfo def, Type[] args, int bufferlen = DefaultBufferLen)
            => read(def.MakeGenericMethod(args), new byte[bufferlen]);

        /// <summary>
        /// Closes a generic method definition over a parametric type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="bufferlen">The length of the buffer that will be allocated to receive the data</param>
        /// <typeparam name="T">The type over which to close the method</typeparam>
        public static MethodData generic<T>(MethodInfo def, int bufferlen = DefaultBufferLen)
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
        public static void generic<T>(Type host, Action<MethodInfo,MethodData> captured, int bufferlen = DefaultBufferLen)            
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
        /// Reflects over the static generic methods declared by a type that accept one type argument, closes 
        /// the methods over the supplied parametric type and captures the binary assembly data emitted
        /// by the gitter for the reified methods
        /// </summary>
        /// <param name="host">The declaring type</param>
        /// <param name="buffer">The staging buffer, cleared after each iteration</param>
        /// <typeparam name="T">The type over which to close the methods</typeparam>
        public static IEnumerable<MethodData> generic(Type host, Type arg, byte[] buffer)            
        {
            foreach(var m in definitions(host))
                yield return MethodReader.generic(m,arg, buffer);                
        }

        /// <summary>
        /// Closes a generic type definition over a supplied type, reflects the declared static methods, and captures 
        /// the binary assembly data emitted by the jitter for the reified methods
        /// </summary>
        /// <param name="def">The generic type definition, obtained by typeof(generictype<>).GetGenericTypeDefinition()</param>
        /// <param name="arg">The type over which to close the generic type</param>
        /// <param name="captured">Callback to receive captured data</param>
        /// <param name="bufferlen">The length of the staging buffer</param>
        public static void generic(Type def, Type arg, Action<MethodInfo,MethodData> captured, int bufferlen = DefaultBufferLen)
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

        static ReadOnlySpan<byte> FooterA
            => new byte[4]{0x19, 0x0, 0x0, 0x0};

        //=> new byte[4]{0x19, 0x0, 0x0, 0x0, 0x40, 0x0, 0x0, 0x0};
        static ReadOnlySpan<byte> FooterB
            => new byte[4]{0xcc, 0x00, 0x00, 0x0};

        static ReadOnlySpan<byte> FooterC
            => new byte[4]{0xcc, 0xcc, 0x00, 0x0};

        static ReadOnlySpan<byte> FooterD
            => new byte[4]{0xcc, 0xcc, 0xcc, 0x0};

        internal static unsafe ulong Capture(byte* pSrc, Span<byte> dst)
        {
            const int footerlen = 4;
            var maxcount = dst.Length;
            var offset = 0;
            var pSrcCurrent = pSrc;    
            var footers = new uint[]{FooterA.TakeUInt32(), FooterC.TakeUInt32(), FooterD.TakeUInt32(), FooterB.TakeUInt32(), 0};   
            
            while(offset < maxcount)
            {
                byte code = 0;
                dst[offset++] = Read(pSrcCurrent++, ref code);   

                if(offset >= (footerlen + 1))
                {
                    var i = (offset - 1) - footerlen;
                    var tail = dst.Slice(i,footerlen).TakeUInt32();
                    for(var j =0; j<footers.Length; j++)
                    {
                        if(tail == footers[j])
                        {
                            return ((ulong)pSrcCurrent) - (footerlen + 1);                    
                        }
                    }
                    
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