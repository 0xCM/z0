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
    using static CaptureTermCode;

    /// <summary>
    /// Defines basic capabilty to read native data for a jitted method
    /// </summary>
    public static unsafe class NativeReader
    {        
        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static MemberCapture read(Moniker id, MethodInfo m, Span<byte> dst)
        {            
            try
            {
                var pSrc = jit(m);
                var pSrcCurrent = pSrc;            
                var start = (ulong)pSrc;
                var result = capture(pSrc, dst);            
                var end = result.End;
                var bytesRead = (int)(end - start);
                var code = dst.Slice(0, bytesRead).ToArray();
                return MemberCapture.Define(id, m, (start, end), code, result);         
            }
            catch(Exception e)
            {
                errout(e);
                return MemberCapture.Empty;                    
            }
        }

        /// <summary>
        /// Runs the jitter on a reflected method and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static MemberCapture read(MethodInfo m, Span<byte> dst)
            => read(OpIdentity.Provider.DefineIdentity(m), m, dst);

        /// <summary>
        /// Captures native code produced by the JIT for a dynamic delegate
        /// </summary>
        /// <param name="d">The dynamic delegate</param>
        /// <param name="dst">The target buffer</param>
        public static unsafe MemberCapture read(Moniker id, DynamicDelegate d, Span<byte> dst)
        {
            var pSrc = jit(d);
            var pSrcCurrent = pSrc;
            var start = (ulong)pSrc;       
            var result =  capture(pSrc, dst);   
            var end = result.End;
            var bytesRead = (int)(end - start);
            var code = dst.Slice(0, bytesRead).ToArray();
            return MemberCapture.Define(id, d, (start, end), code, result);
        }
            
        /// <summary>
        /// Runs the jitter on a delegate and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static unsafe MemberCapture read(Moniker id, Delegate d, Span<byte> dst)
        {
            try
            {
                var pSrc = jit(d);
                var pSrcCurrent = pSrc;            
                var start = (ulong)pSrc;
                var result = capture(pSrc, dst);
                var end = result.End;
                var bytesRead = (int)(end - start);
                var code = dst.Slice(0, bytesRead).ToArray();
                return MemberCapture.Define(id, d, (start, end), code, result);
            }
            catch(Exception e)
            {
                errout(e);
                return MemberCapture.Empty;                    
            }
        }

        /// <summary>
        /// Runs the jitter on a delegate and captures the emitted binary assembly data
        /// </summary>
        /// <param name="m">The method to read</param>
        /// <param name="dst">The target buffer</param>
        public static unsafe MemberCapture read(Delegate d, Span<byte> dst)
            => read(OpIdentity.Provider.DefineIdentity(d.Method), d, dst);

        /// <summary>
        /// Closes a generic method definition over a supplied type and captures the binary assembly data emitted 
        /// by the jitter for the reified method
        /// </summary>
        /// <param name="def">The generic method definition, obtained by MethodInfo.GetGenericMethodDefinition</param>
        /// <param name="arg">The type over which to close the generic method</param>
        /// <param name="dst">The target buffer</param>
        public static MemberCapture generic(MethodInfo def, Type arg, Span<byte> dst)
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
        public static IEnumerable<MemberCapture> gmethods(Type host, Type arg)            
        {
            var buffer = new byte[NativeServices.DefaultBufferLen];     
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
        static IEnumerable<MemberCapture> gtype(Type typedef, Type arg)
        {
            var type = typedef.MakeGenericType(arg);
            var methods = type.StaticMethods().ToArray();
            var buffer = new byte[NativeServices.DefaultBufferLen];
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

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a)
            => a.x == a.y;

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a, (byte x, byte y) b)
            => a.x == a.y 
            && b.x == b.y;

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c)
            => a.x == a.y 
            && b.x == b.y 
            && c.x == c.y;

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c, (byte x, byte y) d)
            => a.x == a.y 
            && b.x == b.y 
            && c.x == c.y 
            && d.x == d.y;


        static ReadOnlySpan<byte> JmpRaxCheck => new byte[]{0x0, 0x48, 0xff, 0xe0, 0x0, 0x0, 0x19};

        static ReadOnlySpan<byte> RetZedSbb => new byte[]{0x0c, 0, 0x19};


        [MethodImpl(Inline)]
        static bit CheckJmpRax(Span<byte> lookback, out CaptureTermCode termcode, out int takeback)        
        {            
            const int ValidBytes = 4;
            termcode = lookback.StartsWith(JmpRaxCheck) ? CaptureTermCode.JMP_RAX : CaptureTermCode.None;            
            takeback = termcode != CaptureTermCode.None ? -JmpRaxCheck.Length - 1 - ValidBytes : 0;
            return termcode != CaptureTermCode.None;
        }

        [MethodImpl(Inline)]
        static bit CheckRetZedSbb(Span<byte> lookback, out CaptureTermCode termcode)        
        {
            termcode = lookback.StartsWith(RetZedSbb) ? CaptureTermCode.RET_ZED_SBB : CaptureTermCode.None;            
            return termcode != CaptureTermCode.None;
        }

        internal static NativeCaptureInfo capture(byte* pSrc, Span<byte> dst)
        {
            const byte ZED = 0;
            const byte RET = 0xc3;
            const byte INTR = 0xcc;
            const byte SBB = 0x19;
            const int Lookback_Count = 16;
 
            var maxcount = dst.Length - 1;
            var pSrcCurrent = pSrc;    
            var offset = 0;
            
            var ret_found = false;
            var ret_offset = 0ul;

            var int3_found = false;
            var int3_offset = 0ul;
            var tc = None;
            Span<byte> lookback = new byte[Lookback_Count];            
                       
            NativeCaptureInfo Capture(Span<byte> lookback, int delta)
                => NativeCaptureInfo.Define((ulong)pSrc, (ulong)((long)pSrcCurrent + delta), tc, lookback.ToArray());

            while(offset < maxcount)
            {
                byte code = 0;                
                dst[offset++] = Read(pSrcCurrent++, ref code);  
                
                var lookstart = offset < Lookback_Count ? 0 : offset - Lookback_Count;
                lookback = dst.Slice(lookstart, Lookback_Count);

                if(!ret_found)
                {
                    ret_found = (code == RET);
                    if(ret_found)
                        ret_offset = (ulong)offset;
                }

                if(!int3_found)
                {
                    int3_found = (code == RET);
                    if(int3_found)
                        int3_offset = (ulong)offset;
                }

                if(offset >= 4)
                {
                    var x0 = dst[offset - 3];
                    var x1 = dst[offset - 2];
                    var x2 = dst[offset - 1];
                    var x3 = dst[offset];
                    var end = 0ul;

                    if(match((x0,RET), (x1, SBB)))
                        tc = RET_SBB;
                    else if(match((x0, RET), (x1, INTR)))
                        tc = RET_INTR;
                    else if(match((x0, RET), (x1, INTR), (x2,INTR)))
                        tc = RET_INTRx2;
                    else if(match((x0, RET), (x1, ZED), (x2,SBB)))
                        tc = RET_ZED_SBB;
                    else if(match((x0, RET), (x1, ZED), (x2,ZED), (x3,ZED)))
                        tc = RET_ZEDx3;
                    else if(match((x0,INTR), (x1, INTR)))
                        tc = INTRx2;

                    if(tc != None)
                        return Capture(lookback, -2);
                }
            
                if(CheckJmpRax(lookback, out tc, out int takeback))
                    return Capture(lookback, takeback);

                if(offset >= Lookback_Count 
                    && (dst[offset - 6] == ZED) 
                    && (dst[offset - 5] == ZED) 
                    && (dst[offset - 4] == ZED) 
                    && (dst[offset - 3] == ZED) 
                    && (dst[offset - 2] == ZED) 
                    && (dst[offset - 1] == ZED)                     
                    && (dst[offset - 0] == ZED)                     
                    )
                {
                    var end = 0ul;
                    tc = ZEDx7_000;

                    if(ret_found)
                    {
                        end = (ulong)pSrc + ret_offset;
                        tc = ZEDx7_RET;
                    }
                    else
                        end = (ulong)pSrcCurrent - 6;
                    
                    return NativeCaptureInfo.Define((ulong)pSrc, end, tc, lookback.ToArray());
                }
            }
            return NativeCaptureInfo.Define((ulong)pSrc, (ulong)pSrcCurrent, CaptureTermCode.BUFFER_OUT, lookback.ToArray());           
        }
    }
}