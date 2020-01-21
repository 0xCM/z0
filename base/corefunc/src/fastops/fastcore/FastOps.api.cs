//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static zfunc;


    public static class FastOps
    {
        public static OpSpec specify(MethodInfo method)
        {            
            var dst = specinit(method);
            Span<byte> buffer = new byte[NativeReader.DefaultBufferLen];
            dst.Id = OpIdentity.Provider.Define(dst.Method);
            method.CustomAttribute<OpAttribute>()
                .OnSome(z => z.Name.OnSome(n => dst.Name = n))
                .OnNone(() => dst.Name = dst.Method.Name);
            dst.Label = dst.Method.Signature().Format();
            return dst;
        }

        public static OpSpec specify(MethodInfo method, Moniker m, Span<byte> buffer)
        {            
            var dst = specinit(method);
            dst.Id = m;
            method.CustomAttribute<OpAttribute>()
                .OnSome(z => z.Name.OnSome(n => dst.Name = n))
                .OnNone(() => dst.Name = dst.Method.Name);
            dst.Label = dst.Method.Signature().Format();
            return dst;
        }


        static OpSpec specinit(MethodInfo method, params Type[] args)
        {
            var dst = new OpSpec();

            if(method.IsConstructedGenericMethod)
            {
                dst.Method = method;
                dst.TypeArgs = method.GetGenericArguments();
            }
            else if(method.IsGenericMethodDefinition)
            {
                dst.Method = method.MakeGenericMethod(args);
                dst.TypeArgs = args;
            }
            else if(method.IsGenericMethod)
            {
                var def = method.GetGenericMethodDefinition();
                dst.Method = def.MakeGenericMethod(args);
                dst.TypeArgs = args;
            }
            else
            {
                dst.Method = method;
                dst.TypeArgs = new Type[]{};
            }
            return dst;
        }

        /// <summary>
        /// Determines whether a method defines a formalized operation
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool test(MethodInfo m)
            => m.Attributed<OpAttribute>();

        /// <summary>
        /// Gets the name of a method to which an Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string opname(MethodInfo m )
            => m.CustomAttribute<OpAttribute>().MapValueOrElse(a => a.Name.IsBlank() ? m.Name : a.Name, () => m.Name);

        public static DirectOpInfo direct(string name, MethodInfo method)
            => new DirectOpInfo(OpIdentity.Provider.Define(method), name,method);        

        /// <summary>
        /// Selects the public members of a type that are identified as formalized operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<MethodInfo> methods(Type host)
            => host.Methods().Public().Attributed<OpAttribute>();

        /// <summary>
        /// Extracts fastop metadata from a host type for non-generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<DirectOpInfo> direct(Type host)
            => methods(host).NonGeneric().Select(m => direct(m.FastOpName(),m));

        public static IEnumerable<DirectOpInfo> direct(IEnumerable<Type> hosts)
            => hosts.SelectMany(direct);

        public static GenericOpInfo generics(string name, MethodInfo method, IEnumerable<PrimalKind> kinds)
            => new GenericOpInfo(OpIdentity.Provider.Define(method), name, method,kinds);

        /// <summary>
        /// Extracts fastop metadata from a host type for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<GenericOpInfo> generics(Type host) 
            => from m in  methods(host).OpenGeneric()
                select generics(m.FastOpName(), m.GetGenericMethodDefinition(), kinds(m));

        public static IEnumerable<GenericOpInfo> generics(IEnumerable<Type> hosts)
            => hosts.SelectMany(h => h.FastOpGenericMethods());


        public static OpClosure closure(Moniker id, PrimalKind k, MethodInfo m)
            => new OpClosure(id, k, m);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosure> closures(GenericOpInfo op)
            => from k in op.Kinds
                let definition = op.Method
                let id = OpIdentity.Provider.Define(definition, k)
                let closed = definition.MakeGenericMethod(k.ToPrimalType())
                select closure(id, k, closed);            


        /// <summary>
        /// Determines whether a method is classified as a blocked op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool blocked(MethodInfo m)
            => m.Attributed<BlockedOpAttribute>();

        /// <summary>
        /// Determines whether a method is classified as a natural op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool natural(MethodInfo m)
            => m.Attributed<NatOpAttribute>();

        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool spanned(MethodInfo m)
            => m.Attributed<SpanOpAttribute>();

        static IEnumerable<PrimalKind> memberkinds(MemberInfo m)
            => m.CustomAttribute<PrimalClosuresAttribute>().MapValueOrElse(a => a.SystemPrimitive.DistinctKinds(), () => items<PrimalKind>());

        static IEnumerable<PrimalKind> kinds(MethodInfo m)
            => memberkinds(m);

        static IEnumerable<PrimalKind> kinds(Type t)
            => memberkinds(t);
    }
}