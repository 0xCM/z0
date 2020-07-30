//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

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