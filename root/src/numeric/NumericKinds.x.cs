//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static NumericKind;

    using NK = NumericKind;

    partial class RootX
    {
        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static int Width(this NumericKind k)
            => (ushort)k;

        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this Type t)
            => Type.GetTypeCode(t.EffectiveType()) 
            switch
            {
                TypeCode.Byte => U8,
                TypeCode.SByte => I8,
                TypeCode.Int16 => I16,
                TypeCode.UInt16 => U16,
                TypeCode.Int32 => I32,
                TypeCode.UInt32 => U32,
                TypeCode.Int64 => I64,
                TypeCode.UInt64 => U64,
                TypeCode.Single => F32,
                TypeCode.Double => F64,
                _ => None
            };

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth WidthKind(this NumericKind k)
            => (FixedWidth)k.Width();

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericKind k)
            => k != None;

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static string Keyword(this NumericKind k)
            => k switch {
                U8 => "byte",
                I8 => "sbyte",
                U16 => "ushort",
                I16 => "short",
                U32 => "uint",
                I32 => "int",
                I64 => "long",
                U64 => "ulong",
                F32 => "float",
                F64 => "double",
                 _ => throw new NotSupportedException(k.ToString())
           };

        [MethodImpl(Inline)]
        public static BoxedNumber Zero(this NumericKind kind)
            => BoxedNumber.Define(0).Convert(kind);


        /// <summary>
        /// Determines the primal identifer of a numeric kind
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]
        public static NumericId GetNumericId(this NumericKind k)
        {
            var noclass = ((uint)k << 3) >> 3;
            var nowidth = (noclass >> 16) << 16;
            return (NumericId)nowidth;            
        }

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match kind
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool Is(this NumericKind k, NumericKind match)        
            => k.GetDistinctKinds().Contains(match);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool Is(this NumericKind k, NumericId match)        
            => ((uint)k & (uint)match) != 0;

        /// <summary>
        /// Enumerates the distinct numeric kinds represented by the (bitfield) source kind
        /// </summary>
        /// <param name="k">The kind to evaluate</param>
        public static ISet<NumericKind> DistinctKinds(this NumericKind k)  
            => k.GetDistinctKinds();     

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static ISet<Type> DistinctTypes(this NumericKind k)
            => k.GetDistinctTypes();

        public static object Convert(this NumericKind dst, object src)
        {
            switch((src?.GetType() ?? typeof(void)).NumericKind())
            {
                case NK.I8:
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

                case NK.U8:
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
                case NK.I16:
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
                case NK.U16:
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
                case NK.I32:
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
                case NK.U32:
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
                case NK.I64:
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
                case NK.U64:
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
                case NK.F32:
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
                case NK.F64:
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


        static HashSet<NumericKind> CreateDistinct(NumericKind k)       
        {
            var dst = new HashSet<NumericKind>();
            if(k.Is(NumericId.U8))
                dst.Add(U8);

            if(k.Is(NumericId.I8))
                dst.Add(I8);

            if(k.Is(NumericId.U16))
                dst.Add(U16);

            if(k.Is(NumericId.I16))
                dst.Add(I16);

            if(k.Is(NumericId.U32))
                dst.Add(U32);

            if(k.Is(NumericId.I32))
                dst.Add(I32);

            if(k.Is(NumericId.U64))
                dst.Add(U64);

            if(k.Is(NumericId.I64))
                dst.Add(I64);

            if(k.Is(NumericId.F32))
                dst.Add(F32);

            if(k.Is(NumericId.F64))
                dst.Add(F64);
            return dst;
        }

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        static Type NumericType(this NumericKind k)
            => k switch {
                U8 => typeof(byte),
                I8 => typeof(sbyte),
                U16 => typeof(ushort),
                I16 => typeof(short),
                U32 => typeof(uint),
                I32 => typeof(int),
                I64 => typeof(long),
                U64 => typeof(ulong),
                F32 => typeof(float),
                F64 => typeof(double),
                _ => throw new NotSupportedException(k.ToString())
            };

        [MethodImpl(Inline)]
        static HashSet<NumericKind> GetDistinctKinds(this NumericKind kind)
            => DistinctKindCache.GetOrAdd(kind, CreateDistinct);

        static HashSet<Type> CreateDistinctTypeSet(this NumericKind k)
            => k.GetDistinctKinds().Select(x => x.NumericType()).ToHashSet();         

        [MethodImpl(Inline)]
        static ISet<Type> GetDistinctTypes(this NumericKind kind)
            => DistinctTypeCache.GetOrAdd(kind,CreateDistinctTypeSet);            

        static ConcurrentDictionary<NumericKind, HashSet<NumericKind>> DistinctKindCache {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<NumericKind>>();

        static ConcurrentDictionary<NumericKind, HashSet<Type>> DistinctTypeCache {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<Type>>();

    }
}