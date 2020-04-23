//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static Seed;
    using static UriDelimiters;

    using NK = NumericKind;
    using ID = NumericTypeId;

    public partial class Identify
    {        
        public static ITypeIdentityProvider provider(Type src, Func<Type,ITypeIdentityProvider> fallback)
            => TypeIdentityProviders.GetOrAdd(src.EffectiveType(), fallback);

       /// <summary>
        /// 
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeWidth w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeWidth w1, ITypeWidth w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");

        /// <summary>
        /// Defines a numeric resource identity predicated on natural bitwidth
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// Defines a numeric resource identity predicated on two natural bitwidths
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");   
         
        /// <summary>
        /// Defines a segmented type identity predicated on type width numeric kind specifications
        /// </summary>
        /// <param name="name">The type name</param>
        /// <param name="wk">The width kind</param>
        /// <param name="nk">The numeric kind</param>
        [MethodImpl(Inline)]
        public static TypeIdentity segmented(string name, TypeWidth wk, NumericKind nk)
            => TypeIdentity.Define($"{name}{wk.FormatValue()}x{nk.Format()}");

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static ISet<Type> types(NumericKind k)
            => GetTypeset(k);

        [MethodImpl(Inline)]
        public static PrimalIdentity primal(Type t)
            => t.IsSystemDefined() ? 
               (NumericKinds.test(t)
               ? PrimalIdentity.Define(t.NumericKind(), t.SystemKeyword())
               : PrimalIdentity.Define(t.SystemKeyword())
               )
               : PrimalIdentity.Empty;

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static ISet<NumericKind> kinds(NumericKind k)
            => GetKindset(k);

        /// <summary>
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="immval">The source value</param>
        public static string Imm8(byte immval)            
            => $"{IDI.SuffixSep}{IDI.Imm}{immval}";

        public static string Name(MethodInfo m)
        {
            var attrib = m.Tag<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;

            var attribVal = attrib.Value;              
            return !string.IsNullOrWhiteSpace(attribVal.Name) ? attribVal.Name : m.Name;                
        }

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        [MethodImpl(Inline)]   
        public static string Owner(Type host)
            => host.Assembly.Id().Format();

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string TestCase(Type host, ISFunc f)
            => $"{Identify.Owner(host)}{PathSep}{host.Name}{PathSep}{f.Id}";

        /// <summary>
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly
        /// and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        public static string HostUri(Type host)
            => $"{Identify.Owner(host)}{PathSep}{host.Name}";


        static ConcurrentDictionary<NumericKind, HashSet<NumericKind>> KindsetCache {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<NumericKind>>();

        static ConcurrentDictionary<NumericKind, HashSet<Type>> TypesetCache {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<Type>>();                 

        static ConcurrentDictionary<Type, ITypeIdentityProvider> TypeIdentityProviders {get;}
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();


        static HashSet<Type> CreateTypeset(NumericKind k)
            => GetKindset(k).Select(NumericKinds.type).ToHashSet();         

        static HashSet<NumericKind> CreateKindset(NumericKind k)       
        {
            var dst = new HashSet<NumericKind>();
            if(NumericKinds.contains(k, ID.U8))
                dst.Add(NK.U8);

            if(NumericKinds.contains(k, ID.I8))
                dst.Add(NK.I8);

            if(NumericKinds.contains(k, ID.U16))
                dst.Add(NK.U16);

            if(NumericKinds.contains(k, ID.I16))
                dst.Add(NK.I16);

            if(NumericKinds.contains(k, ID.U32))
                dst.Add(NK.U32);

            if(NumericKinds.contains(k, ID.I32))
                dst.Add(NK.I32);

            if(NumericKinds.contains(k, ID.U64))
                dst.Add(NK.U64);

            if(NumericKinds.contains(k, ID.I64))
                dst.Add(NK.I64);

            if(NumericKinds.contains(k, ID.F32))
                dst.Add(NK.F32);

            if(NumericKinds.contains(k, ID.F64))
                dst.Add(NK.F64);
            
            return dst;
        }

        [MethodImpl(Inline)]
        static HashSet<NumericKind> GetKindset(NumericKind kind)
            => KindsetCache.GetOrAdd(kind, CreateKindset);

        [MethodImpl(Inline)]
        static ISet<Type> GetTypeset(NumericKind kind)
            => TypesetCache.GetOrAdd(kind,CreateTypeset); 
    }
}