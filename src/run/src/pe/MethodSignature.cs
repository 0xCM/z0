//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Collections.Immutable;

    partial struct ImageTables
    {
        /// <summary>
        /// Represents the signature characteristics specified by the leading byte of signature blobs.
        /// </summary>
        /// <remarks>
        /// This header byte is present in all method definition, method reference, standalone method, field,
        /// property, and local variable signatures, but not in type specification signatures.
        /// </remarks>
        public struct SignatureHeader : IEquatable<SignatureHeader>
        {
            private readonly byte _rawValue;

            public const byte CallingConventionOrKindMask = 0x0F;

            private const byte maxCallingConvention = (byte) SignatureCallingConvention.VarArgs;

            public SignatureHeader (byte rawValue)
            {
                _rawValue = rawValue;
            }

            public SignatureHeader (SignatureKind kind, SignatureCallingConvention convention, SignatureAttributes attributes) : this ((byte) ((int) kind | (int) convention | (int) attributes))
            { }

            public byte RawValue
            {
                get { return _rawValue; }
            }

            public SignatureCallingConvention CallingConvention
            {
                get
                {
                    int callingConventionOrKind = _rawValue & CallingConventionOrKindMask;

                    if (callingConventionOrKind > maxCallingConvention)
                    {
                        return SignatureCallingConvention.Default;
                    }

                    return (SignatureCallingConvention) callingConventionOrKind;
                }
            }

            public SignatureKind Kind
            {
                get
                {
                    int callingConventionOrKind = _rawValue & CallingConventionOrKindMask;

                    if (callingConventionOrKind <= maxCallingConvention)
                    {
                        return SignatureKind.Method;
                    }

                    return (SignatureKind) callingConventionOrKind;
                }
            }

            public SignatureAttributes Attributes
            {
                get { return (SignatureAttributes) (_rawValue & ~CallingConventionOrKindMask); }
            }

            public bool HasExplicitThis
            {
                get { return (_rawValue & (byte) SignatureAttributes.ExplicitThis) != 0; }
            }

            public bool IsInstance
            {
                get { return (_rawValue & (byte) SignatureAttributes.Instance) != 0; }
            }

            public bool IsGeneric
            {
                get { return (_rawValue & (byte) SignatureAttributes.Generic) != 0; }
            }

            public override bool Equals (object? obj)
            {
                return obj is SignatureHeader && Equals ((SignatureHeader) obj);
            }

            public bool Equals (SignatureHeader other)
            {
                return _rawValue == other._rawValue;
            }

            public override int GetHashCode ()
            {
                return _rawValue;
            }

            public static bool operator == (SignatureHeader left, SignatureHeader right)
            {
                return left._rawValue == right._rawValue;
            }

            public static bool operator != (SignatureHeader left, SignatureHeader right)
            {
                return left._rawValue != right._rawValue;
            }

            public override string ToString ()
            {
                var sb = new StringBuilder ();
                sb.Append (Kind.ToString ());

                if (Kind == SignatureKind.Method)
                {
                    sb.Append (',');
                    sb.Append (CallingConvention.ToString ());
                }

                if (Attributes != SignatureAttributes.None)
                {
                    sb.Append (',');
                    sb.Append (Attributes.ToString ());
                }

                return sb.ToString ();
            }
        }

        /// <summary>
        /// Represents a method (definition, reference, or standalone) or property signature.
        /// In the case of properties, the signature matches that of a getter with a distinguishing <see cref="SignatureHeader"/>.
        /// </summary>
        public readonly struct MethodSignature<T>
        {
            /// <summary>
            /// Represents the information in the leading byte of the signature (kind, calling convention, flags).
            /// </summary>
            public readonly SignatureHeader Header;

            /// <summary>
            /// Gets the method's return type.
            /// </summary>
            public readonly T ReturnType;

            /// <summary>
            /// Gets the number of parameters that are required. Will be equal to the length <see cref="ParameterTypes"/> of
            /// unless this signature represents the standalone call site of a vararg method, in which case the entries
            /// extra entries in <see cref="ParameterTypes"/> are the types used for the optional parameters.
            /// </summary>
            public int RequiredParameterCount { get; }

            /// <summary>
            /// Gets the number of generic type parameters of the method. Will be 0 for non-generic methods.
            /// </summary>
            public int GenericParameterCount { get; }

            /// <summary>
            /// Gets the method's parameter types.
            /// </summary>
            public ImmutableArray<T> ParameterTypes { get; }

            public MethodSignature (SignatureHeader header, T returnType, int requiredParameterCount, int genericParameterCount, ImmutableArray<T> parameterTypes)
            {
                Header = header;
                ReturnType = returnType;
                GenericParameterCount = genericParameterCount;
                RequiredParameterCount = requiredParameterCount;
                ParameterTypes = parameterTypes;
            }
        }
    }
}