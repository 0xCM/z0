//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// A succinct type signature
    /// </summary>
    public struct TypeSig
    {
        public string DisplayName;

        public string Modifier;

        public bool IsOpenGeneric;

        public bool IsClosedGeneric;

        public bool IsByRef;

        public bool IsIn;

        public bool IsOut;

        public bool IsPointer;

        public static TypeSig from(Type src)
            => new TypeSig(
                src.DisplayName(),
                src.IsConstructedGenericType,
                src.IsGenericType && !src.IsConstructedGenericType,
                src.IsByRef,
                false,
                false,
                src.IsPointer);

        public static TypeSig from(ParameterInfo src)
        {
            var type = src.ParameterType;
            var name = type.EffectiveType().DisplayName();
            return new TypeSig(name,
                type.IsConstructedGenericType,
                type.IsGenericType && !type.IsConstructedGenericType,
                type.IsRef(),
                src.IsIn,
                src.IsOut,
                type.IsPointer);
        }

        internal TypeSig(string DisplayName, bool IsOpenGeneric, bool IsClosedGeneric, bool IsByRef, bool IsIn, bool IsOut, bool IsPointer)
        {
            this.DisplayName = DisplayName;
            this.IsOpenGeneric = IsOpenGeneric;
            this.IsClosedGeneric = IsClosedGeneric;
            this.IsByRef = IsByRef;
            this.IsIn = IsIn;
            this.IsOut = IsOut;
            this.IsPointer = IsPointer;
            Modifier = IsIn ? "in " : IsOut ? "out " : IsByRef ? "ref " : EmptyString;
        }

        public string Format()
            => $"{Modifier}{DisplayName}";

        public override string ToString()
            => Format();
    }
}