//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TypeArg : ITextual
    {
        public readonly string Name;

        public readonly Type Target;

        public readonly TypeParamInfo Parameter;

        public readonly Type Argument;

        [MethodImpl(Inline)]
        public TypeArg(Type target, TypeParamInfo parameter, Type arg)
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