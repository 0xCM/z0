//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Clr
    {
        [Op]
        public static ClrTypeSigInfo siginfo(Type type)
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