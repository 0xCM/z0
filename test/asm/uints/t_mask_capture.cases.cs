//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    static class MaskCases
    {
        static T central<T>(N8 f, N2 d)
            where T : unmanaged
                => BitMasks.central<T>(f,d);

        static T central<T>(N8 f, N4 d)
            where T : unmanaged
                => BitMasks.central<T>(f,d);

        static T central<T>(N8 f, N6 d)
            where T : unmanaged
                => BitMasks.central<T>(f,d);

        [MethodImpl(Inline), NumericClosures(UnsignedInts), Naturals(4,6,8,10,12,14,16,18,32,64)]
        static T lsb<N,T>(N w, N2 f, N1 d, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMasks.lsb<N,T>(w, f, d);

        public static IEnumerable<MethodInfo> NumericMethods
            => typeof(MaskCases).DeclaredStaticMethods().OpenGeneric(1);

        static IEnumerable<MethodInfo> NaturalDefs
            => typeof(MaskCases).DeclaredStaticMethods().OpenGeneric(2).GenericDefinitions();

        public static IEnumerable<MethodInfo> NaturalClosures
            => from def in NaturalDefs
                let attrib = def.Tag<NaturalsAttribute>().Require()
                from number in attrib.Values
                let n = NativeNaturals.FindType(number).Require()
                from t in NumericArgs
                let m = def.MakeGenericMethod(n,t)
                select m;

        public static IEnumerable<MethodInfo> NumericMethodDefs
            => NumericMethods.Select(m => m.GetGenericMethodDefinition());

        public static Type[] NaturalArgs
            => Root.array(typeof(N4), typeof(N6), typeof(N8), typeof(N10), typeof(N12));

        public static Type[] NumericArgs
            => Root.array(typeof(byte), typeof(ushort), typeof(uint), typeof(ulong));
    }

}