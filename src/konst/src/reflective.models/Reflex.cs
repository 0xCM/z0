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

    using static Konst;

    [ApiHost]
    public readonly partial struct Reflex
    {
        public static IEnumerable<MethodInfo> DirectApiMethods(IApiHost src)
            => from m in src.HostType.DeclaredMethods().NonGeneric()
                where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                select m;

        public static IEnumerable<MethodInfo> GenericApiMethods(IApiHost src)
                => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                    where m.Tagged<OpAttribute>()
                    && m.Tagged<ClosuresAttribute>()
                    && !m.AcceptsImmediate()
                    select m;

        /// <summary>
        /// Computes a method's numeric closures, predicated on available metadata
        /// </summary>
        /// <param name="m">The source method</param>
        public static NumericKind[] NumericClosureKinds(MethodInfo m)
            => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Numeric
                let spec = (NumericKind)tag.Spec
                select spec.DistinctKinds().ToArray()).ValueOrElse(() => sys.empty<NumericKind>());

        public static Type[] NumericClosureTypes(MethodInfo m)
            => from c in NumericClosureKinds(m)
               let t = c.SystemType()
               where t != typeof(void)
               select t;

        /// <summary>
        /// Computes a types's numeric closures, predicated on available metadata
        /// </summary>
        /// <param name="t">The source type</param>
        public static NumericKind[] NumericClosureKinds(Type t)
            => (from tag in t.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Numeric
                let spec = (NumericKind)tag.Spec
                select spec.DistinctKinds().ToArray()).ValueOrElse(() => sys.empty<NumericKind>());

        /// <summary>
        /// Computes a method's natural closures, predicated on available metadata
        /// </summary>
        /// <param name="m">The source method</param>
        public static Type[] NaturalClosureTypes(MethodInfo m)
            => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Natural
                let spec = (NatClosureKind)tag.Spec
                select NativeNaturals.FindTypes(spec).ToArray()).ValueOrElse(() => sys.empty<Type>());

        const BindingFlags BF = ReflectionFlags.BF_All;

        [MethodImpl(Inline), Op]
        public static Reflected reflected(IWfShell wf)
            => new Reflected(wf);

        public static Assembly EntryAssembly
        {
            [MethodImpl(Inline), Op]
            get => sys.EntryAssembly;
        }

        public static Assembly ThisAssembly
        {
            [MethodImpl(Inline), Op]
            get => sys.ThisAssembly;
        }
    }
}