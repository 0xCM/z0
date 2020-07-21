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

    using static Konst;
    using static UriDelimiters;

    using NK = NumericKind;
    using ID = NumericTypeId;

    public partial class Identify
    {        
        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static HashSet<Type> typeset(NumericKind k)
            => GetNumericTypeSet(k);

        /// <summary>
        /// Specifies the primal types identified by a <see cref='NumericKind' />
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static HashSet<NumericKind> kindset(NumericKind k)
            => GetNumericKindSet(k);

        /// <summary>
        /// Defines a primal identity if the source type represents a recognized primitive; otherwise,
        /// returns <see cref='PrimalIdentity.Empty'/>
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static PrimalIdentity primal(Type src)
            => src.IsSystemDefined() ? 
               (NumericKinds.test(src)
               ? PrimalIdentity.Define(src.NumericKind(), src.SystemKeyword())
               : PrimalIdentity.Define(src.SystemKeyword())
               )
               : PrimalIdentity.Empty;

        /// <summary>
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="imm8">The source immediate</param>
        public static string Imm8Suffix(byte imm8)            
            => $"{IDI.SuffixSep}{IDI.Imm}{imm8}";

        /// <summary>
        /// Defines the name of an api member predicated on a tag, if present, or the metadata-defined name if not
        /// </summary>
        /// <param name="m">The source method</param>
        public static string ApiMemberName(MethodInfo m)
        {
            var attrib = m.Tag<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;
            else
                return attrib.Value.GroupName;
        }

        [MethodImpl(Inline)]   
        public static PartId OwningPart(Type host)
            => host.Assembly.Id();

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        [MethodImpl(Inline)]   
        public static string OwningPartText(Type host)
            => OwningPart(host).Format();

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string TestCaseText(Type host, IFunc f)
            => $"{Identify.OwningPartText(host)}{PathSep}{host.Name}{PathSep}{f.Id}";

        /// <summary>
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        public static string HostUriText(Type host)
            => $"{Identify.OwningPartText(host)}{PathSep}{host.Name}";

        static ConcurrentDictionary<NumericKind, HashSet<NumericKind>> NumericKindSets {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<NumericKind>>();

        static ConcurrentDictionary<NumericKind, HashSet<Type>> NumericTypeSets {get;}       
            = new ConcurrentDictionary<NumericKind, HashSet<Type>>();                 

        static HashSet<Type> CreateTypeSet(NumericKind k)
            => GetNumericKindSet(k).Select(NumericKinds.type).ToHashSet();         

        static HashSet<NumericKind> CreateKindSet(NumericKind k)       
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
        static HashSet<NumericKind> GetNumericKindSet(NumericKind kind)
            => NumericKindSets.GetOrAdd(kind, CreateKindSet);

        [MethodImpl(Inline)]
        static HashSet<Type> GetNumericTypeSet(NumericKind kind)
            => NumericTypeSets.GetOrAdd(kind, CreateTypeSet); 
    }
}