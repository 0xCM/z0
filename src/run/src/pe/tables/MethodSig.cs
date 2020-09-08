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
        /// Represents a method (definition, reference, or standalone) or property signature.
        /// In the case of properties, the signature matches that of a getter with a distinguishing <see cref="SigHeader"/>.
        /// </summary>
        public readonly struct MethodSig<T>
        {
            /// <summary>
            /// Represents the information in the leading byte of the signature (kind, calling convention, flags).
            /// </summary>
            public readonly SigHeader Header;

            /// <summary>
            /// Gets the method's return type.
            /// </summary>
            public readonly T ReturnType;

            /// <summary>
            /// Gets the number of parameters that are required. Will be equal to the length <see cref="ParameterTypes"/> of
            /// unless this signature represents the standalone call site of a vararg method, in which case the entries
            /// extra entries in <see cref="ParameterTypes"/> are the types used for the optional parameters.
            /// </summary>
            public int RequiredParameterCount {get;}

            /// <summary>
            /// Gets the number of generic type parameters of the method. Will be 0 for non-generic methods.
            /// </summary>
            public int GenericParameterCount {get;}

            /// <summary>
            /// Gets the method's parameter types.
            /// </summary>
            public T[] ParameterTypes {get;}

            public MethodSig(SigHeader header, T returnType, int requiredParameterCount, int genericParameterCount, T[] parameterTypes)
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