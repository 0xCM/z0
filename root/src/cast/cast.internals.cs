//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using NK = NumericKind;

    using static Root;
    using static As;

    [ApiHost("cast.internals", ApiHostKind.Direct)]
    static class CastInternals
    {
        [MethodImpl(Inline), Op]
        public static double to64f(sbyte src)        
            => src;

        [MethodImpl(Inline), Op]
        public static double to64f(byte src)        
            => src;
        
        [MethodImpl(Inline), Op]
        public static double to64f(short src)        
            => src;

        [MethodImpl(Inline), Op]
        public static double to64f(ushort src)        
            => src;

        [MethodImpl(Inline), Op]
        public static double to64f(int src)        
            => src;

        [MethodImpl(Inline), Op]
        public static double to64f(uint src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static double to64f(long src)        
            => src;

        [MethodImpl(Inline), Op]
        public static double to64f(ulong src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static uint to32u(float src)        
            => (uint)((long)src);

        [MethodImpl(Inline), Op]
        public static double to64f(float src)        
            => src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(float src)        
            => (ulong)((long)src);

        [MethodImpl(Inline), Op]
        public static sbyte to8i(double src)
            => (sbyte)to32i(src);

        [MethodImpl(Inline), Op]
        public static byte to8u(double src)
            => (byte)to32u(src);

        [MethodImpl(Inline), Op]
        public static short to16i(double src)
            => (sbyte)to32i(src);

        [MethodImpl(Inline), Op]
        public static ushort to16u(double src)
            => (ushort)to32u(src);

        [MethodImpl(Inline), Op]
        public static int to32i(double src)
            => (int)src; 

        [MethodImpl(Inline), Op]
        public static uint to32u(double src)
            => (uint)((long)src);

        [MethodImpl(Inline), Op]
        public static long to64i(double src)
            => (long)src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(double src)
            => (ulong)((long)src);
 
        [Op]
        public static object from8i(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(sbyte)src;
                case NK.I8:
                    return (sbyte)(sbyte)src;
                case NK.I16:
                    return (short)(sbyte)src;
                case NK.U16:
                    return (ushort)(sbyte)src;
                case NK.I32:
                    return (int)(sbyte)src;
                case NK.U32:
                    return (uint)(sbyte)src;
                case NK.I64:
                    return (long)(sbyte)src;
                case NK.U64:
                    return (ulong)(sbyte)src;
                case NK.F32:
                    return (float)(sbyte)src;
                case NK.F64:
                    return (double)(sbyte)src;
            }
            return src;
        }

        [Op]
        public static object from8u(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(byte)src;
                case NK.I8:
                    return (sbyte)(byte)src;
                case NK.I16:
                    return (short)(byte)src;
                case NK.U16:
                    return (ushort)(byte)src;
                case NK.I32:
                    return(int)(byte)src;
                case NK.U32:
                    return (uint)(byte)src;
                case NK.I64:
                    return (long)(byte)src;
                case NK.U64:
                    return (ulong)(byte)src;
                case NK.F32:
                    return (float)(byte)src;
                case NK.F64:
                    return (double)(byte)src;
            }
            return src;
        }

        [Op]
        public static object from16i(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(short)src;
                case NK.I8:
                    return (sbyte)(short)src;
                case NK.I16:
                    return (short)(short)src;
                case NK.U16:
                    return (ushort)(short)src;
                case NK.I32:
                    return (int)(short)src;
                case NK.U32:
                    return (uint)(short)src;
                case NK.I64:
                    return (long)(short)src;
                case NK.U64:
                    return (ulong)(short)src;
                case NK.F32:
                    return (float)(short)src;
                case NK.F64:
                    return (double)(short)src;
            }
            return src;
        }

        [Op]
        public static object from16u(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(ushort)src;
                case NK.I8:
                    return (sbyte)(ushort)src;
                case NK.I16:
                    return (short)(ushort)src;
                case NK.U16:
                    return (ushort)(ushort)src;
                case NK.I32:
                    return (int)(ushort)src;
                case NK.U32:
                    return (uint)(ushort)src;
                case NK.I64:
                    return (long)(ushort)src;
                case NK.U64:
                    return (ulong)(ushort)src;
                case NK.F32:
                    return (float)(ushort)src;
                case NK.F64:
                    return (double)(ushort)src;
            }
            return src;
        }

        [Op]
        public static object from32i(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(int)src;
                case NK.I8:
                    return (sbyte)(int)src;
                case NK.I16:
                    return (short)(int)src;
                case NK.U16:
                    return (ushort)(int)src;
                case NK.I32:
                    return (int)(int)src;
                case NK.U32:
                    return (uint)(int)src;
                case NK.I64:
                    return (long)(int)src;
                case NK.U64:
                    return (ulong)(int)src;
                case NK.F32:
                    return (float)(int)src;
                case NK.F64:
                    return (double)(int)src;
            }
            return src;
        }

        [Op]
        public static object from32u(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(uint)src;
                case NK.I8:
                    return (sbyte)(uint)src;
                case NK.I16:
                    return (short)(uint)src;
                case NK.U16:
                    return (ushort)(uint)src;
                case NK.I32:
                    return (int)(uint)src;
                case NK.U32:
                    return (uint)(uint)src;
                case NK.I64:
                    return (long)(uint)src;
                case NK.U64:
                    return (ulong)(uint)src;
                case NK.F32:
                    return (float)(uint)src;
                case NK.F64:
                    return (double)(uint)src;
            }
            return src;
        }

        [Op]
        public static object from64i(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(long)src;
                case NK.I8:
                    return (sbyte)(long)src;
                case NK.I16:
                    return (short)(long)src;
                case NK.U16:
                    return (ushort)(long)src;
                case NK.I32:
                    return (int)(long)src;
                case NK.U32:
                    return (uint)(long)src;
                case NK.I64:
                    return (long)(long)src;
                case NK.U64:
                    return (ulong)(long)src;
                case NK.F32:
                    return (float)(long)src;
                case NK.F64:
                    return (double)(long)src;
            }
            return src;
        }

        [Op]
        public static object from64u(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(ulong)src;
                case NK.I8:
                    return (sbyte)(ulong)src;
                case NK.I16:
                    return (short)(ulong)src;
                case NK.U16:
                    return (ushort)(ulong)src;
                case NK.I32:
                    return (int)(ulong)src;
                case NK.U32:
                    return (uint)(ulong)src;
                case NK.I64:
                    return (long)(ulong)src;
                case NK.U64:
                    return (ulong)(ulong)src;
                case NK.F32:
                    return (float)(ulong)src;
                case NK.F64:
                    return (double)(ulong)src;
            }
            return src;
        }

        [Op]
        public static object from32f(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(float)src;
                case NK.I8:
                    return (sbyte)(float)src;
                case NK.I16:
                    return (short)(float)src;
                case NK.U16:
                    return (ushort)(float)src;
                case NK.I32:
                    return (int)(float)src;
                case NK.U32:
                    return (uint)(float)src;
                case NK.I64:
                    return (long)(float)src;
                case NK.U64:
                    return (ulong)(float)src;
                case NK.F32:
                    return (float)(float)src;
                case NK.F64:
                    return (double)(float)src;
            }
            return src;
        }

        [Op]
        public static object from64f(NumericKind dst, object src)
        {
            switch(dst)
            {
                case NK.U8:
                    return (byte)(double)src;
                case NK.I8:
                    return (sbyte)(double)src;
                case NK.I16:
                    return (short)(double)src;
                case NK.U16:
                    return (ushort)(double)src;
                case NK.I32:
                    return (int)(double)src;
                case NK.U32:
                    return (uint)(double)src;
                case NK.I64:
                    return (long)(double)src;
                case NK.U64:
                    return (ulong)(double)src;
                case NK.F32:
                    return (float)(double)src;
                case NK.F64:
                    return (double)(double)src;
            }
            return src;
        }
  
        public static T unhandled<S,T>(S src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            errors.Throw($"The conversion {typeof(S).Name} -> {typeof(T).Name} needed for the value {src} doesn't exist", caller,file,line);
            return default;
        }
    }
}