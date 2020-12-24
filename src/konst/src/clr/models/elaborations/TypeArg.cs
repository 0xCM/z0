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
        public string Name {get;}

        public Type Target {get;}

        public TypeParamInfo Parameter {get;}

        public Type Argument {get;}

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