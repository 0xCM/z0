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

    partial struct ImageTables
    {
        /// <summary>
        /// Represents the signature characteristics specified by the leading byte of signature blobs.
        /// </summary>
        /// <remarks>
        /// This header byte is present in all method definition, method reference, standalone method, field,
        /// property, and local variable signatures, but not in type specification signatures.
        /// </remarks>
        public struct SigHeader : IEquatable<SigHeader>
        {
            private readonly byte _rawValue;

            public const byte CallingConventionOrKindMask = 0x0F;

            private const byte maxCallingConvention = (byte) SignatureCallingConvention.VarArgs;

            public SigHeader (byte rawValue)
            {
                _rawValue = rawValue;
            }

            public SigHeader (SignatureKind kind, SignatureCallingConvention convention, SignatureAttributes attributes) : this ((byte) ((int) kind | (int) convention | (int) attributes))
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
                return obj is SigHeader && Equals ((SigHeader) obj);
            }

            public bool Equals (SigHeader other)
            {
                return _rawValue == other._rawValue;
            }

            public override int GetHashCode ()
            {
                return _rawValue;
            }

            public static bool operator == (SigHeader left, SigHeader right)
            {
                return left._rawValue == right._rawValue;
            }

            public static bool operator != (SigHeader left, SigHeader right)
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
    }
}