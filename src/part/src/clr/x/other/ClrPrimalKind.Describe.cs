//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Root;

    partial class ClrQuery
    {
        [Op]
        public static ClrTypeSigInfo SigInfo(this ParameterInfo src)
        {
            var dst = new ClrTypeSigInfo();
            var type = src.ParameterType;
            dst.DisplayName= type.EffectiveType().DisplayName();
            dst.IsOpenGeneric = type.IsGenericType && !type.IsConstructedGenericType;
            dst.IsClosedGeneric = type.IsConstructedGenericType;
            dst.IsByRef = type.IsRef();
            dst.IsIn = src.IsIn;
            dst.IsOut = src.IsOut;
            dst.IsPointer = type.IsPointer;
            dst.Modifier = dst.IsIn ? "in " : dst.IsOut ? "out " : dst.IsByRef ? "ref " : EmptyString;
            return dst;
        }

        [Op]
        public static ClrTypeSigInfo SigInfo(this Type type)
        {
            var dst = new ClrTypeSigInfo();
            dst.DisplayName= type.EffectiveType().DisplayName();
            dst.IsOpenGeneric = type.IsGenericType && !type.IsConstructedGenericType;
            dst.IsClosedGeneric = type.IsConstructedGenericType;
            dst.IsByRef = type.IsRef();
            dst.IsIn = false;
            dst.IsOut = false;
            dst.IsPointer = type.IsPointer;
            dst.Modifier = dst.IsIn ? "in " : dst.IsOut ? "out " : dst.IsByRef ? "ref " : EmptyString;
            return dst;
        }
    }
}