//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace System.Reflection.Emit
{
    using System;
    using System.Reflection;

    partial class DispatchProxyGenerator
    {
        class PackedArgs
        {
            internal const int DispatchProxyPosition = 0;

            internal const int DeclaringTypePosition = 1;

            internal const int MethodTokenPosition = 2;

            internal const int ArgsPosition = 3;

            internal const int GenericTypesPosition = 4;

            internal const int ReturnValuePosition = 5;

            internal static readonly Type[] PackedTypes = new Type[] {
                typeof(object), typeof(Type), typeof(int), typeof(object[]), typeof(Type[]), typeof(object)};

            private readonly object?[] _args;

            internal PackedArgs()
                : this(new object[PackedTypes.Length]) { }

            internal PackedArgs(object?[] args) { _args = args; }

            internal DispatchProxy? DispatchProxy
            {
                 get => (DispatchProxy?)_args[DispatchProxyPosition];
            }

            internal Type? DeclaringType { get { return (Type?)_args[DeclaringTypePosition]; } }

            internal int MethodToken { get { return (int)_args[MethodTokenPosition]!; } }

            internal object[]? Args { get { return (object[]?)_args[ArgsPosition]; } }

            internal Type[]? GenericTypes { get { return (Type[]?)_args[GenericTypesPosition]; } }

            internal object? ReturnValue { /*get { return args[ReturnValuePosition]; }*/ set { _args[ReturnValuePosition] = value; } }
        }
    }
}