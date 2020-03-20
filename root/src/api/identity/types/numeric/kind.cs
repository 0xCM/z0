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
    using ID = NumericKindId;

    partial struct NumericIdentity
    {
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
        /// Determines the primal kind (if any) of a parametrically-identifed type
        /// </summary>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static NumericKind kind<T>()
            where T : struct
                => kind_u<T>();

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
        ///  Attempts to parse the source string as a numeric value
        /// </summary>
        /// <param name="src">The text to parse</param>
        /// <typeparam name="T">The target numeric type</typeparam>
        public static ParseResult<T> parse<T>(string src)
            where T : unmanaged
                 => Try(() => Numeric.parse<T>(src)).MapValueOrElse(v => ParseResult.Success<T>(src, v), () => ParseResult.Fail<T>(src));

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
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline), Op]
        public static bool contains(NumericKind k, NumericKindId match)        
            => ((uint)k & (uint)match) != 0;


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


        static HashSet<Type> CreateTypeset(NumericKind k)
            => GetKindset(k).Select(NumericIdentity.type).ToHashSet();         

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