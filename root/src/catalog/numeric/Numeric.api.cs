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

    using static Root;

    using NK = NumericKind;
    using TC = System.TypeCode;
    using FW = FixedWidth;
    using NI = NumericIndicator;
    using ID = NumericId;

    [ApiHost]
    public static class Numeric
    {
        /// <summary>
        /// Determines the primal kind (if any) of a parametrically-identifed type
        /// </summary>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static NumericKind kind<T>()
            where T : struct
                => kind_u<T>();

        /// <summary>
        /// Returns true if the primal source type is signed, false otherwise
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bool signed<T>()
            where T : unmanaged
            => typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long);

        /// <summary>
        /// Returns true if the specified type is an unsigned primal integral type
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bool unsigned<T>()
            where T : unmanaged
            => typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong);

        /// <summary>
        /// Returns true if the spedified type is a 32-bit or 64-bit floating point
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bool floating<T>()
            where T : unmanaged
                => typeof(T) == typeof(float) 
                || typeof(T) == typeof(double);        

        /// <summary>
        /// Determines whether a type is classified as primal numeric
        /// </summary>
        /// <param name="t">The type to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Type t)
            => t.NumericKind().IsSome();

        [MethodImpl(Inline), Op]
        public static FixedWidth width(Type t)
        {
            var k = t.NumericKind();
            if(k.IsSome())
                return (FixedWidth)(ushort)k;
            else
                return FixedWidth.None;            
        }

        /// <summary>
        /// Returns true if the source type is a primal signed type, false otherwise
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op]
        public static bool signed(Type t)
            => t == typeof(sbyte) 
            || t == typeof(short) 
            || t == typeof(int) 
            || t == typeof(long);

        /// <summary>
        /// Returns true if the source type is a primal unsigned type, false otherwise
        /// </summary>
        [MethodImpl(Inline), Op]
        public static bool unsigned(Type t)
            => t == typeof(byte) 
            || t == typeof(ushort) 
            || t == typeof(uint) 
            || t == typeof(ulong);

        /// <summary>
        /// Returns true if the source type is a primal floating point type, false otherwise
        /// </summary>
        [MethodImpl(Inline), Op]
        public static bool floating(Type t)
            => t == typeof(float) 
            || t == typeof(double);

        [Op]
        public static NumericKind from(FixedWidth width, NumericIndicator ni)
            => ni switch {
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

        [MethodImpl(Inline)]
        static TC typecode(Type t)
            => t.IsEnum ? 0 : Type.GetTypeCode(t.EffectiveType());

        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static NumericKind kind(Type t)
            => typecode(t) switch
                {
                    TC.SByte => NK.I8,
                    TC.Byte => NK.U8,
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

        [MethodImpl(Inline), Op]
        public static bool signed(object value)
            => value is sbyte || value is short || value is int || value is long;
        
        [MethodImpl(Inline), Op]
        public static bool unsigned(object value)
            => value is byte || value is ushort || value is uint || value is ulong;
        
        [MethodImpl(Inline), Op]
        public static bool floating(object value)
            => value is float || value is double;

        /// <summary>
        /// Converts a fixed width kind to an integer corresponding to the with represented by the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static int @int(FixedWidth src)
            => (int)src;

        /// <summary>
        /// Produces a canonical text representation of the source kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static string format(FixedWidth src)
            => $"{@int(src)}";

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static ISet<Type> typeset(NumericKind k)
            => typesetAcquire(k);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static ISet<NumericKind> kindset(NumericKind k)
            => kindsetAcquire(k);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match kind
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline), Op]
        public static bool @is(NumericKind k, NumericKind match)        
            => kindset(k).Contains(match);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline), Op]
        public static bool @is(NumericKind k, NumericId match)        
            => ((uint)k & (uint)match) != 0;

        [MethodImpl(Inline)]
        static NumericKind kind_u<T>()
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return NumericKind.U8;
            else if(typeof(T) == typeof(ushort))
                return NumericKind.U16;
            else if(typeof(T) == typeof(uint))
                return NumericKind.U32;
            else if(typeof(T) == typeof(ulong))
                return NumericKind.U64;
            else
                return kind_i<T>();
        }

        [MethodImpl(Inline)]
        static NumericKind kind_i<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return NumericKind.I8;
            else if(typeof(T) == typeof(short))
                return NumericKind.I16;
            else if(typeof(T) == typeof(int))
                return NumericKind.I32;
            else if(typeof(T) == typeof(long))
                return NumericKind.I64;
            else
                return kind_f<T>();
        }

        [MethodImpl(Inline)]
        static NumericKind kind_f<T>()
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return NumericKind.F32;
            else if(typeof(T) == typeof(double))
                return NumericKind.F64;
            else
                return NumericKind.None;            
        }

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

        /// <summary>
        /// Attempts to parse a numeric kind from a string in the form {width}{indicator} 
        /// </summary>
        /// <param name="src">The source text</param>
        [Op]
        public static NumericKind kind(string src)
        {
            var input = src.Trim();
            if(string.IsNullOrWhiteSpace(input))
                return 0;
            
            var indicator = (NumericIndicator)input.Last();
            if(!indicator.IsLiteral() || indicator == NumericIndicator.None)
                return 0;
            
            var width = 0u;
            if(!uint.TryParse(input.Substring(0, input.Length - 1), out width))
                return 0;
            
            var fw = (FixedWidth)width;
            if(!fw.IsLiteral())
                return 0;
            
            var kind = fw.ToNumericKind(indicator);
            if(!kind.IsLiteral())
                return 0;
                        
            return kind;                            
        }

        /// <summary>
        /// Attempts to parse a sequence of numeric kinds from a sequennce of strings in the form {width}{indicator} 
        /// </summary>
        /// <param name="src">The source text</param>
        public static IEnumerable<NumericKind> kinds(IEnumerable<string> kinds)
            => from part in kinds
               let x = part.StartsWith(OpIdentity.GenericLocator)
                    ? kind(part.Substring(1, part.Length - 1)) 
                    : kind(part)
                select x;

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