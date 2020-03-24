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
    using ID = NumericKindId;

    partial struct NumericIdentity
    {
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [Op]
        public static Type type(NumericKind k)
            => NumericTypes.type(k);

        /// <summary>
        /// Determines the primal kind (if any) of a parametrically-identifed type
        /// </summary>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static NumericKind kind<T>()
            => NumericTypes.kind<T>();
        
        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static NumericKind kind(Type t)
            => NumericTypes.kind(t);

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [Op]
        public static NumericKind kind(TypeCode tc)
            => NumericTypes.kind(tc);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline), Op]
        public static bool contains(NumericKind k, NumericKindId match)        
            => NumericTypes.contains(k,match);

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