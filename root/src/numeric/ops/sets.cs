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

    partial class Numeric
    {
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