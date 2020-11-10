//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace System.Reflection.Emit
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;

    using DP = DispatcherProxies;

    using Z0;

    [ApiHost(ApiNames.DispatcherProxy, true)]
    public readonly struct DispatcherProxies
    {
        [Op]
        internal static Type[] ParamTypes(ParameterInfo[] src, bool noByRef)
        {
            var types = new Type[src.Length];
            for (int i = 0; i<src.Length; i++)
            {
                types[i] = src[i].ParameterType;
                if (noByRef && types[i].IsByRef)
                    types[i] = types[i].GetElementType()!;
            }
            return types;
        }

        // TypeCode does not exist in ProjectK or ProjectN.
        // This lookup method was copied from PortableLibraryThunks\Internal\PortableLibraryThunks\System\TypeThunks.cs
        // but returns the integer value equivalent to its TypeCode enum.
        [Op]
        internal static int GetTypeCode(Type? type)
        {
            if (type == null)
                return 0;   // TypeCode.Empty;

            if (type == typeof(bool))
                return 3;   // TypeCode.Boolean;

            if (type == typeof(char))
                return 4;   // TypeCode.Char;

            if (type == typeof(sbyte))
                return 5;   // TypeCode.SByte;

            if (type == typeof(byte))
                return 6;   // TypeCode.Byte;

            if (type == typeof(short))
                return 7;   // TypeCode.Int16;

            if (type == typeof(ushort))
                return 8;   // TypeCode.UInt16;

            if (type == typeof(int))
                return 9;   // TypeCode.Int32;

            if (type == typeof(uint))
                return 10;  // TypeCode.UInt32;

            if (type == typeof(long))
                return 11;  // TypeCode.Int64;

            if (type == typeof(ulong))
                return 12;  // TypeCode.UInt64;

            if (type == typeof(float))
                return 13;  // TypeCode.Single;

            if (type == typeof(double))
                return 14;  // TypeCode.Double;

            if (type == typeof(decimal))
                return 15;  // TypeCode.Decimal;

            if (type == typeof(DateTime))
                return 16;  // TypeCode.DateTime;

            if (type == typeof(string))
                return 18;  // TypeCode.String;

            if (type.GetTypeInfo().IsEnum)
                return GetTypeCode(Enum.GetUnderlyingType(type));

            return 1;   // TypeCode.Object;
        }

        [Op]
        internal static void Convert(ILGenerator il, Type source, Type target, bool isAddress)
        {
            Debug.Assert(!target.IsByRef);
            if (target == source)
                return;

            var sourceTypeInfo = source.GetTypeInfo();
            var targetTypeInfo = target.GetTypeInfo();

            if (source.IsByRef)
            {
                Debug.Assert(!isAddress);
                Type argType = source.GetElementType()!;
                Ldind(il, argType);
                Convert(il, argType, target, isAddress);
                return;
            }
            if (targetTypeInfo.IsValueType)
            {
                if (sourceTypeInfo.IsValueType)
                {
                    var opCode = DP.conv()[DP.GetTypeCode(target)];
                    Debug.Assert(!opCode.Equals(OpCodes.Nop));
                    il.Emit(opCode);
                }
                else
                {
                    Debug.Assert(sourceTypeInfo.IsAssignableFrom(targetTypeInfo));
                    il.Emit(OpCodes.Unbox, target);
                    if (!isAddress)
                        Ldind(il, target);
                }
            }
            else if (targetTypeInfo.IsAssignableFrom(sourceTypeInfo))
            {
                if (sourceTypeInfo.IsValueType || source.IsGenericParameter)
                {
                    if (isAddress)
                        Ldind(il, source);
                    il.Emit(OpCodes.Box, source);
                }
            }
            else
            {
                Debug.Assert(sourceTypeInfo.IsAssignableFrom(targetTypeInfo) || targetTypeInfo.IsInterface || sourceTypeInfo.IsInterface);
                if (target.IsGenericParameter)
                    il.Emit(OpCodes.Unbox_Any, target);
                else
                    il.Emit(OpCodes.Castclass, target);
            }
        }

        [Op]
        internal static void Ldind(ILGenerator il, Type type)
        {
            OpCode opCode = DP.ldind()[DP.GetTypeCode(type)];
            if (!opCode.Equals(OpCodes.Nop))
                il.Emit(opCode);
            else
                il.Emit(OpCodes.Ldobj, type);
        }

        [Op]
        internal static void Stind(ILGenerator il, Type type)
        {
            OpCode opCode = DP.stind()[DP.GetTypeCode(type)];
            if (!opCode.Equals(OpCodes.Nop))
                il.Emit(opCode);
            else
                il.Emit(OpCodes.Stobj, type);
        }

        [Op]
        public static  bool equals(MethodInfo? left, MethodInfo? right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (left == null)
                return right == null;
            else if (right == null)
                return false;

            // This assembly should work in netstandard1.3,
            // so we cannot use MemberInfo.MetadataToken here.
            // Therefore, it compares honestly referring ECMA-335 I.8.6.1.6 Signature Matching.
            if (!Equals(left.DeclaringType, right.DeclaringType))
                return false;

            if (!Equals(left.ReturnType, right.ReturnType))
                return false;

            if (left.CallingConvention != right.CallingConvention)
                return false;

            if (left.IsStatic != right.IsStatic)
                return false;

            if (left.Name != right.Name)
                return false;

            var leftGenericParameters = left.GetGenericArguments();
            var rightGenericParameters = right.GetGenericArguments();
            if (leftGenericParameters.Length != rightGenericParameters.Length)
                return false;

            for (int i = 0; i < leftGenericParameters.Length; i++)
            {
                if (!Equals(leftGenericParameters[i], rightGenericParameters[i]))
                    return false;
            }

            var leftParameters = left.GetParameters();
            var rightParameters = right.GetParameters();
            if (leftParameters.Length != rightParameters.Length)
                return false;

            for (int i = 0; i < leftParameters.Length; i++)
            {
                if (!Equals(leftParameters[i].ParameterType, rightParameters[i].ParameterType))
                    return false;
            }

            return true;
        }

        [Op]
        public static int hash(MethodInfo obj)
        {
            if (obj == null)
                return 0;

            Debug.Assert(obj.DeclaringType != null);
            int hashCode = obj.DeclaringType!.GetHashCode();
            hashCode ^= obj.Name.GetHashCode();
            foreach (ParameterInfo parameter in obj.GetParameters())
            {
                hashCode ^= parameter.ParameterType.GetHashCode();
            }

            return hashCode;
        }

        [Op]
        internal static OpCode[] conv()
            => s_convOpCodes;

        [Op]
        internal static OpCode[] ldind()
            => s_ldindOpCodes;

        [Op]
        internal static OpCode[] stind()
            => s_stindOpCodes;

        static readonly OpCode[] s_convOpCodes = new OpCode[] {
            OpCodes.Nop, //Empty = 0,
            OpCodes.Nop, //Object = 1,
            OpCodes.Nop, //DBNull = 2,
            OpCodes.Conv_I1, //Boolean = 3,
            OpCodes.Conv_I2, //Char = 4,
            OpCodes.Conv_I1, //SByte = 5,
            OpCodes.Conv_U1, //Byte = 6,
            OpCodes.Conv_I2, //Int16 = 7,
            OpCodes.Conv_U2, //UInt16 = 8,
            OpCodes.Conv_I4, //Int32 = 9,
            OpCodes.Conv_U4, //UInt32 = 10,
            OpCodes.Conv_I8, //Int64 = 11,
            OpCodes.Conv_U8, //UInt64 = 12,
            OpCodes.Conv_R4, //Single = 13,
            OpCodes.Conv_R8, //Double = 14,
            OpCodes.Nop, //Decimal = 15,
            OpCodes.Nop, //DateTime = 16,
            OpCodes.Nop, //17
            OpCodes.Nop, //String = 18,
        };

        static readonly OpCode[] s_ldindOpCodes = new OpCode[] {
            OpCodes.Nop, //Empty = 0,
            OpCodes.Nop, //Object = 1,
            OpCodes.Nop, //DBNull = 2,
            OpCodes.Ldind_I1, //Boolean = 3,
            OpCodes.Ldind_I2, //Char = 4,
            OpCodes.Ldind_I1, //SByte = 5,
            OpCodes.Ldind_U1, //Byte = 6,
            OpCodes.Ldind_I2, //Int16 = 7,
            OpCodes.Ldind_U2, //UInt16 = 8,
            OpCodes.Ldind_I4, //Int32 = 9,
            OpCodes.Ldind_U4, //UInt32 = 10,
            OpCodes.Ldind_I8, //Int64 = 11,
            OpCodes.Ldind_I8, //UInt64 = 12,
            OpCodes.Ldind_R4, //Single = 13,
            OpCodes.Ldind_R8, //Double = 14,
            OpCodes.Nop, //Decimal = 15,
            OpCodes.Nop, //DateTime = 16,
            OpCodes.Nop, //17
            OpCodes.Ldind_Ref, //String = 18,
        };

        static readonly OpCode[] s_stindOpCodes = new OpCode[] {
            OpCodes.Nop, //Empty = 0,
            OpCodes.Nop, //Object = 1,
            OpCodes.Nop, //DBNull = 2,
            OpCodes.Stind_I1, //Boolean = 3,
            OpCodes.Stind_I2, //Char = 4,
            OpCodes.Stind_I1, //SByte = 5,
            OpCodes.Stind_I1, //Byte = 6,
            OpCodes.Stind_I2, //Int16 = 7,
            OpCodes.Stind_I2, //UInt16 = 8,
            OpCodes.Stind_I4, //Int32 = 9,
            OpCodes.Stind_I4, //UInt32 = 10,
            OpCodes.Stind_I8, //Int64 = 11,
            OpCodes.Stind_I8, //UInt64 = 12,
            OpCodes.Stind_R4, //Single = 13,
            OpCodes.Stind_R8, //Double = 14,
            OpCodes.Nop, //Decimal = 15,
            OpCodes.Nop, //DateTime = 16,
            OpCodes.Nop, //17
            OpCodes.Stind_Ref, //String = 18,
        };
    }
}