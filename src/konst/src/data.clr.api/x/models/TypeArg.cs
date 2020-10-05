//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TypeArg : ITextual
    {
        public readonly string Name;

        public readonly Type Target;

        public readonly TypeParameter Parameter;

        public readonly Type Argument;

        [MethodImpl(Inline)]
        public TypeArg(Type target, TypeParameter parameter, Type arg)
        {
            Name = arg.Name;
            Target = target;
            Parameter = parameter;
            Argument = arg;
        }

        public string Format()
            => Argument.DisplayName();

        public override string ToString()
            => Format();
    }
}