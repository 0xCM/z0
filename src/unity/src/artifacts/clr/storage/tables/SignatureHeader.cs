//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Diagnostics;

    using SH = ClrStorage.SigHeaderCode;
    using CA = ClrStorage.CustomAttributeCode;

    partial struct ClrStorage
    {
        public readonly struct SignatureHeader
        {
            public const byte DefaultCall = 0x00;

            public const byte CCall = 0x01;

            public const byte StdCall = 0x02;

            public const byte ThisCall = 0x03;

            public const byte FastCall = 0x04;

            public const byte VarArgCall = 0x05;

            public const byte Field = 0x06;

            public const byte LocalVar = 0x07;

            public const byte Property = 0x08;

            public const byte GenericInstance = 0x0A;

            public const byte Max = 0x0C;

            public const byte CallingConventionMask = 0x0F;

            public const byte HasThis = 0x20;

            public const byte ExplicitThis = 0x40;

            public const byte Generic = 0x10;

            public const byte SignatureHeaderMask = 0x7F;

            public static bool IsMethodSignature(byte src) {
                return ((SH)src & SH.CallingConventionMask) <= SH.VarArgCall;
            }
            public static bool IsVarArgCallSignature(
                byte src
            ) {
                return ((SH)src & SH.CallingConventionMask) == SH.VarArgCall;
            }
            public static bool IsFieldSignature(
                byte src
            ) {
                return ((SH)src & SH.CallingConventionMask) == SH.Field;
            }
            public static bool IsLocalVarSignature(
                byte src
            ) {
                return ((SH)src & SH.CallingConventionMask) == SH.LocalVar;
            }
            public static bool IsPropertySignature(
                byte src
            ) {
                return ((SH)src & SH.CallingConventionMask) == SH.Property;
            }
            public static bool IsGenericInstanceSignature(
                byte src
            ) {
                return ((SH)src & SH.CallingConventionMask) == SH.GenericInstance;
            }
            public static bool IsExplicitThis(
                byte src
            ) {
                return ((SH)src & SH.ExplicitThis) == SH.ExplicitThis;
            }
            public static bool IsGeneric(byte src) {
                return ((SH)src & SH.Generic) == SH.Generic;
            }
            }


    }
}