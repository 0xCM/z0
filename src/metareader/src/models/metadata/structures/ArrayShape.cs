//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;

    public readonly partial struct MdR
    {        
        /// <summary>
        /// Represents the shape of an array type.
        /// </summary>
        public readonly struct ArrayShape
        {
            /// <summary>
            /// Gets the number of dimensions in the array.
            /// </summary>
            public int Rank { get; }

            /// <summary>
            /// Gets the sizes of each dimension. Length may be smaller than rank, in which case the trailing dimensions have unspecified sizes.
            /// </summary>
            public int[] Sizes { get; }

            /// <summary>
            /// Gets the lower-bounds of each dimension. Length may be smaller than rank, in which case the trailing dimensions have unspecified lower bounds.
            /// </summary>
            public int[] LowerBounds { get; }

            public ArrayShape(int rank, int[] sizes, int[] lowerBounds)
            {
                Rank = rank;
                Sizes = sizes;
                LowerBounds = lowerBounds;
            }
        }        

        public readonly struct CustomAttributeNamedArgument<T>
        {
            public readonly string Name;
            
            public readonly CustomAttributeNamedArgumentKind Kind;
            
            public readonly T Type;
            
            public readonly object Value;

            public CustomAttributeNamedArgument(string? name, CustomAttributeNamedArgumentKind kind, T type, object? value)
            {
                Name = name;
                Kind = kind;
                Type = type;
                Value = value;
            }
        }

        public readonly struct CustomAttributeTypedArgument<T>
        {
            public readonly T Type;

            public readonly object Value;

            public CustomAttributeTypedArgument(T type, object value)
            {
                Type = type;
                Value = value;
            }
        }    

        public readonly struct CustomAttributeValue<TType>
        {
            public CustomAttributeTypedArgument<TType>[] FixedArguments { get; }

            public CustomAttributeNamedArgument<TType>[] NamedArguments { get; }

            public CustomAttributeValue(CustomAttributeTypedArgument<TType>[] fixedArguments, CustomAttributeNamedArgument<TType>[] namedArguments)
            {
                FixedArguments = fixedArguments;
                NamedArguments = namedArguments;
            }
        }
    }
}