//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    partial class VKinds
    {
        /// <summary>
        /// Determines whether a type is classified as an intrinsic vector
        /// </summary>
        /// <param name="t">The type to test</param>
        [Test]
        public static bool test(Type t)
        {
            var tE = t.EffectiveType();
            if(tE == null)
                return false;

            var tD = tE.IsGenericType ? tE.GetGenericTypeDefinition() : (tE.IsGenericTypeDefinition ? tE : null);
            if(tD == null)
                return false;

            return tD == typeof(Vector128<>)
                || tD == typeof(Vector256<>)
                || tD == typeof(Vector512<>);
        }

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Test]
        public static bool test(Type t, int? w)
        {
            if(!test(t))
                return false;

            if(w == null)
                return true;

            return ((int)width(t) == w);
        }

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 8-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, sbyte t)
            => ((uint)k & (uint)NumericApiKind.I8) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 8-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, byte t)
            => ((uint)k & (uint)NumericApiKind.U8) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 16-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, short t)
            => ((uint)k & (uint)NumericApiKind.I16) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 16-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, ushort t)
            => ((uint)k & (uint)NumericApiKind.U16) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 32-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, int t)
             => ((uint)k & (uint)NumericApiKind.I32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 32-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, uint t)
            => ((uint)k & (uint)NumericApiKind.U32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a singed 64-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, long t)
            => ((uint)k & (uint)NumericApiKind.I64) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has an unsigned 64-bit cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, ulong t)
            => ((uint)k & (uint)NumericApiKind.U64) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a 32-bit floating-point cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, float t)
             => ((uint)k & (uint)NumericApiKind.F32) != 0;

        /// <summary>
        /// Determines whether a vector of specified kind has a 64-bit floating-point cell type
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="t">The type to match as specified by a representative value</param>
        [MethodImpl(Inline), Test]
        public static bool test(VectorKind k, double t)
             => ((uint)k & (uint)NumericApiKind.F64) != 0;

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The vector cell type</param>
        [MethodImpl(Inline), Test]
        public static bool test(Type t, W128 w, Type tCell)
            => test(t,w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The vector cell type</param>
        [MethodImpl(Inline), Test]
        public static bool test(Type t, W256 w, Type tCell)
            => test(t,w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The vector cell type</param>
        [MethodImpl(Inline), Test]
        public static bool test(Type t, W512 w, Type tCell)
            => test(t,w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline), Test]
        public static bool test(Type t, W128 w)
            => width(t) == TypeWidth.W128;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline), Test]
        public static bool test(Type t, W256 w)
            => width(t) == TypeWidth.W256;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline), Test]
        public static bool test(Type t, W512 w)
            => width(t) == TypeWidth.W512;

        /// <summary>
        /// Determines whether a parameter is of some intrinsic vector type
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        [MethodImpl(Inline), Test]
        public static bool test(ParameterInfo p)
            => test(p.ParameterType);

        /// <summary>
        /// Determines whether a parameter accepts a 128-bit intrinsic vector
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Test]
        public static bool test(ParameterInfo p, W128 w)
            => width(p.ParameterType) == TypeWidth.W128;

        /// <summary>
        /// Determines whether a parameter accepts a 256-bit intrinsic vector
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Test]
        public static bool test(ParameterInfo p, W256 w)
            => width(p.ParameterType) == TypeWidth.W256;

        /// <summary>
        /// Determines whether a parameter accepts a 512-bit intrinsic vector
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Test]
        public static bool test(ParameterInfo p, W512 w)
            => width(p.ParameterType) == TypeWidth.W512;

        /// <summary>
        /// Returns true if a method parameter is a 128-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The argument type to match</param>
        [MethodImpl(Inline), Test]
        public static bool test(ParameterInfo p, W128 w, Type tCell)
            => test(p.ParameterType, w, tCell);

        /// <summary>
        /// Returns true if a method parameter is a 256-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The argument type to match</param>
        [MethodImpl(Inline), Test]
        public static bool test(ParameterInfo p, W256 w, Type tCell)
            => test(p.ParameterType, w, tCell);

        /// <summary>
        /// Returns true if a method parameter is a 512-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The argument type to match</param>
        [MethodImpl(Inline), Test]
        public static bool test(ParameterInfo p, W512 w, Type tCell)
            => test(p.ParameterType, w, tCell);
    }
}