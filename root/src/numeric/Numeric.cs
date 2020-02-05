//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections.Concurrent;

    using static RootShare;

    using NK = NumericKind;
    using TC = System.TypeCode;
    using FW = FixedWidth;
    using NI = NumericIndicator;
    using NC = NumericClass;
    using ID = NumericId;

    [OpHost]
    public static class Numeric
    {
        [Op]
        public static object convert(NumericKind dst, object src)
        {
            var tc = Type.GetTypeCode(src?.GetType());
            switch(tc)
            {
                case TC.SByte:
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
                }
                break;

                case TC.Byte:
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
                }
                break;
                case TC.Int16:
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
                }
                break;
                case TC.UInt16:
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
                }
                break;
                case TC.Int32:
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
                }
                break;
                case TC.UInt32:
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
                }
                break;
                case TC.Int64:
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
                }
                break;
                case TC.UInt64:
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
                }
                break;
                case TC.Single:
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
                }
                break;
                case TC.Double:
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
                }
                break;
            }
            return src;
        }

        [Op]
        public static NumericKind from(FixedWidth width, NumericIndicator indicator)
            => indicator switch {
                NI.Signed 
                    => width switch {                    
                        FW.W8  => NK.I8,
                        FW.W16 => NK.I16,
                        FW.W32 => NK.I32,
                        FW.W64 => NK.I64,
                        _ => NK.None
                    },
                NI.Unsigned 
                    => width switch {
                        FW.W8  => NK.U8,
                        FW.W16 => NK.U16,
                        FW.W32 => NK.U32,
                        FW.W64 => NK.U64,
                        _ => NK.None
                    },
                NI.Float 
                    => width switch {
                        FW.W32 => NK.F32,
                        FW.W64 => NK.F64,
                        _ => NK.None
                    },
                _ => NK.None
            };

        [Op]
        public static NumericKind from(FixedWidth width, NumericClass c)
            => c switch {
                NC.Signed 
                    => width switch {                    
                        FW.W8  => NK.I8,
                        FW.W16 => NK.I16,
                        FW.W32 => NK.I32,
                        FW.W64 => NK.I64,
                        _ => NK.None
                    },
                NC.Unsigned 
                    => width switch {
                        FW.W8  => NK.U8,
                        FW.W16 => NK.U16,
                        FW.W32 => NK.U32,
                        FW.W64 => NK.U64,
                        _ => NK.None
                    },
                NC.Float 
                    => width switch {
                        FW.W32 => NK.F32,
                        FW.W64 => NK.F64,
                        _ => NK.None
                    },
                _ => NK.None
            };



        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [Op]
        public static Type type(NumericKind k)
            => k switch {
                NK.U8 => typeof(byte),
                NK.I8 => typeof(sbyte),
                NK.U16 => typeof(ushort),
                NK.I16 => typeof(short),
                NK.U32 => typeof(uint),
                NK.I32 => typeof(int),
                NK.I64 => typeof(long),
                NK.U64 => typeof(ulong),
                NK.F32 => typeof(float),
                NK.F64 => typeof(double),
                _ => throw new NotSupportedException(k.ToString())
            };

        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline),Op]
        public static NumericKind kind(Type t)
            =>  t.IsEnum 
                ? NumericKind.None 
                : Type.GetTypeCode(t.EffectiveType()) 
                    switch
                    {
                        TC.Byte => NK.U8,
                        TC.SByte => NK.I8,
                        TC.Int16 => NK.I16,
                        TC.UInt16 => NK.U16,
                        TC.Int32 => NK.I32,
                        TC.UInt32 => NK.U32,
                        TC.Int64 => NK.I64,
                        TC.UInt64 => NK.U64,
                        TC.Single => NK.F32,
                        TC.Double => NK.F64,
                        _ => NK.None
                    };


        [MethodImpl(Inline),Op]
        public static bool signed(object value)
            => value is sbyte || value is short || value is int || value is long;
        
        [MethodImpl(Inline),Op]
        public static bool unsigned(object value)
            => value is byte || value is ushort || value is uint || value is ulong;
        
        [MethodImpl(Inline),Op]
        public static bool floating(object value)
            => value is float || value is double;

        /// <summary>
        /// Converts a fixed width kind to an integer corresponding to the with represented by the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline),Op]
        public static int @int(FixedWidth src)
            => (int)src;

        /// <summary>
        /// Produces a canonical text representation of the source kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline),Op]
        public static string format(FixedWidth src)
            => $"{@int(src)}";

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline),Op]
        public static ISet<Type> typeset(NumericKind k)
            => typesetAcquire(k);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline),Op]
        public static ISet<NumericKind> kindset(NumericKind k)
            => kindsetAcquire(k);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match kind
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline),Op]
        public static bool @is(NumericKind k, NumericKind match)        
            => kindset(k).Contains(match);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool @is(NumericKind k, NumericId match)        
            => ((uint)k & (uint)match) != 0;

        [Op]
        static HashSet<NumericKind> kindsetCreate(NumericKind k)       
        {
            var dst = new HashSet<NumericKind>();
            if(@is(k, ID.U8))
                dst.Add(NK.U8);

            if(@is(k, ID.I8))
                dst.Add(NK.I8);

            if(@is(k, ID.U16))
                dst.Add(NK.U16);

            if(@is(k, ID.I16))
                dst.Add(NK.I16);

            if(@is(k, ID.U32))
                dst.Add(NK.U32);

            if(@is(k, ID.I32))
                dst.Add(NK.I32);

            if(@is(k, ID.U64))
                dst.Add(NK.U64);

            if(@is(k, ID.I64))
                dst.Add(NK.I64);

            if(@is(k, ID.F32))
                dst.Add(NK.F32);

            if(@is(k, ID.F64))
                dst.Add(NK.F64);
            
            return dst;
        }

        static HashSet<Type> typesetCreate(NumericKind k)
            => kindsetAcquire(k).Select(type).ToHashSet();         

        [MethodImpl(Inline)]
        static HashSet<NumericKind> kindsetAcquire(NumericKind kind)
            => KindsetCache.GetOrAdd(kind, kindsetCreate);

        [MethodImpl(Inline)]
        static ISet<Type> typesetAcquire(NumericKind kind)
            => TypesetCache.GetOrAdd(kind,typesetCreate);            

        static ConcurrentDictionary<NumericKind, HashSet<NumericKind>> KindsetCache {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<NumericKind>>();

        static ConcurrentDictionary<NumericKind, HashSet<Type>> TypesetCache {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<Type>>();
    }
}