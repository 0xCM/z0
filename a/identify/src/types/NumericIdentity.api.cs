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

    using NK = NumericKind;
    using ID = NumericTypeId;

    partial class Identify
    {
        public static TypeIdentity EnumType(Type src)        
            => src.IsEnum ? EnumIdentity.Define(src.Name, src.GetEnumUnderlyingType().NumericKind()) : EnumIdentity.Empty;

        public static EnumIdentity EnumType(string name, NumericKind basetype)
            => EnumIdentity.Define(name, basetype);

        [MethodImpl(Inline)]
        public static PrimalIdentity Primal(Type t)
            => t.IsSystemDefined() ? 
               (NumericTypeOps.IsNumeric(t)
               ? PrimalIdentity.Define(t.NumericKind(), t.SystemKeyword())
               : PrimalIdentity.Define(t.SystemKeyword())
               )
               : PrimalIdentity.Empty;

        /// <summary>
        /// Attempts to parse a numeric kind from a string in the form {width}{indicator} 
        /// </summary>
        /// <param name="src">The source text</param>
        public static NumericKind Numeric(string src)
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
        /// Attempts to parse a sequence of numeric kinds from a sequence of strings in the form {width}{indicator} 
        /// </summary>
        /// <param name="src">The source text</param>
        public static IEnumerable<NumericKind> Numeric(IEnumerable<string> kinds)
            => from part in kinds
               let x = part.StartsWith(OpIdentity.GenericLocator)
                    ? Identify.Numeric(part.Substring(1, part.Length - 1)) 
                    : Identify.Numeric(part)
                select x;        

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static ISet<Type> TypeSet(NumericKind k)
            => GetTypeset(k);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static ISet<NumericKind> KindSet(NumericKind k)
            => GetKindset(k);

        static HashSet<Type> CreateTypeset(NumericKind k)
            => GetKindset(k).Select(NumericTypes.type).ToHashSet();         

        static HashSet<NumericKind> CreateKindset(NumericKind k)       
        {
            var dst = new HashSet<NumericKind>();
            if(NumericTypes.contains(k, ID.U8))
                dst.Add(NK.U8);

            if(NumericTypes.contains(k, ID.I8))
                dst.Add(NK.I8);

            if(NumericTypes.contains(k, ID.U16))
                dst.Add(NK.U16);

            if(NumericTypes.contains(k, ID.I16))
                dst.Add(NK.I16);

            if(NumericTypes.contains(k, ID.U32))
                dst.Add(NK.U32);

            if(NumericTypes.contains(k, ID.I32))
                dst.Add(NK.I32);

            if(NumericTypes.contains(k, ID.U64))
                dst.Add(NK.U64);

            if(NumericTypes.contains(k, ID.I64))
                dst.Add(NK.I64);

            if(NumericTypes.contains(k, ID.F32))
                dst.Add(NK.F32);

            if(NumericTypes.contains(k, ID.F64))
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