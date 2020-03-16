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
    using ID = NumericKindId;

    [ApiHost("numeric.api")]
    public static class Numeric
    {
        /// <summary>
        /// Recognized unsigned integral types
        /// </summary>
        public static IEnumerable<Type> UnsignedIntegralTypes
            => items(typeof(byte), typeof(ushort),  typeof(uint), typeof(ulong));

        /// <summary>
        /// Recognized unsigned integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> UnsignedIntegralKinds
            => items(NK.U8, NK.U16, NK.U32, NK.U64);

        /// <summary>
        /// Recognized signed integral kinds
        /// </summary>
        public static IEnumerable<Type> SignedIntegralTypes
            => items(typeof(sbyte), typeof(short), typeof(int), typeof(long));
        
        /// <summary>
        /// Recognized signed integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> SignedIntegralKinds
            => items(NK.I8, NK.I16, NK.I32, NK.I64);

        /// <summary>
        /// Recognized integral types
        /// </summary>
        public static IEnumerable<Type> IntegralTypes
            => SignedIntegralTypes.Union(UnsignedIntegralTypes);

        /// <summary>
        /// Recognized integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> IntegralKinds
            => UnsignedIntegralKinds.Union(SignedIntegralKinds);

        /// <summary>
        /// recognized floating-point types
        /// </summary>
        public static IEnumerable<Type> FloatTypes
            => items(typeof(float), typeof(double));

        /// <summary>
        /// Recognized floating-point kinds
        /// </summary>
        public static IEnumerable<NumericKind> FloatKinds
            => items(NK.F32, NK.F64);

        /// <summary>
        /// Recognized numeric types
        /// </summary>
        public static IEnumerable<Type> Types
            => IntegralTypes.Union(FloatTypes);

        /// <summary>
        /// Recognized numeric kinds
        /// </summary>
        public static IEnumerable<NumericKind> Kinds
            => IntegralKinds.Union(FloatKinds);

        /// <summary>
        /// Creates a parametric numeric comparer
        /// </summary>
        /// <typeparam name="T">The numeric type to compare</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static NumericComparer<T> comparer<T>()
            where T : unmanaged
                => NumericComparer.create<T>();

        /// <summary>
        /// Creates the numeric sequence {0,1,...,count-1}
        /// </summary>
        /// <param name="count">The number of elements in the sequence</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static IEnumerable<T> range<T>(T count)
            where T : unmanaged
                => NumericRange.counted(count);

        /// <summary>
        /// Creates a numeric sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static IEnumerable<T> range<T>(T x0, T x1)
            where T : unmanaged
                => NumericRange.sequence(x0,x1);

        /// <summary>
        /// Creates a numeric sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <param name="step">The step size</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static IEnumerable<T> range<T>(T x0, T x1, T step)
            where T : unmanaged
                => NumericRange.step(x0,x1,step);

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
        ///  Attempts to parse the source string as a numeric value
        /// </summary>
        /// <param name="src">The text to parse</param>
        /// <typeparam name="T">The target numeric type</typeparam>
        public static ParseResult<T> parse<T>(string src)
            where T : unmanaged
                 => Try(() => NumericParser.parse<T>(src)).MapValueOrElse(v => ParseResult.Success<T>(src, v), () => ParseResult.Fail<T>(src));

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [Op]
        public static NumericKind kind(TypeCode tc)
        {
            switch(tc)
            {
                case TC.SByte:
                    return NK.I8;

                case TC.Byte:
                    return NK.U8;

                case TC.Int16:
                    return NK.I16;

                case TC.UInt16:
                    return NK.U16;
                
                case TC.Int32:
                    return NK.I32;

                case TC.UInt32:
                    return NK.U32;

                case TC.Int64:
                    return NK.I64;

                case TC.UInt64:
                    return NK.U64;

                case TC.Single:
                    return NK.F32;

                case TC.Double:
                    return NK.F64;
            }
            
            return NK.None;
        }

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
        [Op]
        public static Option<NumericKind> kind(Type t)
        {
            var k = t.IsEnum 
                ? NumericKind.None 
                : Type.GetTypeCode(t.EffectiveType()) 
                switch
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
            return k.IsSome() ? some(k) : none<NumericKind>();
        }

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
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static ISet<Type> typeset(NumericKind k)
            => GetTypeset(k);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static ISet<NumericKind> kindset(NumericKind k)
            => GetKindset(k);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match kind
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline), Op]
        public static bool contains(NumericKind k, NumericKind match)        
            => kindset(k).Contains(match);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline), Op]
        public static bool contains(NumericKind k, NumericKindId match)        
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

        /// <summary>
        /// Produces a canonical text representation of the source kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static string format(FixedWidth src)
            => $"{@int(src)}";

        static HashSet<Type> CreateTypeset(NumericKind k)
            => GetKindset(k).Select(type).ToHashSet();         

        [Op]
        static HashSet<NumericKind> CreateKindset(NumericKind k)       
        {
            var dst = new HashSet<NumericKind>();
            if(contains(k, ID.U8))
                dst.Add(NK.U8);

            if(contains(k, ID.I8))
                dst.Add(NK.I8);

            if(contains(k, ID.U16))
                dst.Add(NK.U16);

            if(contains(k, ID.I16))
                dst.Add(NK.I16);

            if(contains(k, ID.U32))
                dst.Add(NK.U32);

            if(contains(k, ID.I32))
                dst.Add(NK.I32);

            if(contains(k, ID.U64))
                dst.Add(NK.U64);

            if(contains(k, ID.I64))
                dst.Add(NK.I64);

            if(contains(k, ID.F32))
                dst.Add(NK.F32);

            if(contains(k, ID.F64))
                dst.Add(NK.F64);
            
            return dst;
        }


        [MethodImpl(Inline)]
        static HashSet<NumericKind> GetKindset(NumericKind kind)
            => KindsetCache.GetOrAdd(kind, CreateKindset);

        [MethodImpl(Inline)]
        static ISet<Type> GetTypeset(NumericKind kind)
            => TypesetCache.GetOrAdd(kind,CreateTypeset);            

        static ConcurrentDictionary<NumericKind, HashSet<NumericKind>> KindsetCache {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<NumericKind>>();

        static ConcurrentDictionary<NumericKind, HashSet<Type>> TypesetCache {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<Type>>();
    }
}