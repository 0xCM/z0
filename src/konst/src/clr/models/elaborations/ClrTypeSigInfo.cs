//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;

    /// <summary>
    /// A succinct type signature
    /// </summary>
    public struct ClrTypeSigInfo
    {
        public string DisplayName;

        public string Modifier;

        public bool IsOpenGeneric;

        public bool IsClosedGeneric;

        public bool IsByRef;

        public bool IsIn;

        public bool IsOut;

        public bool IsPointer;

        public static ClrTypeSigInfo from(ParameterInfo src)
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

        public static ClrTypeSigInfo from(Type type)
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

        public string Format()
            => $"{Modifier}{DisplayName}";

        public override string ToString()
            => Format();
    }
}