//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public class TypeArgument : SigArtifact
    {
        public static TypeArgument Define(Type target, TypeParameter param, Type arg)
            => new TypeArgument(target, param, arg);

        TypeArgument(Type target, TypeParameter parameter, Type arg)
            : base(arg.Name)
        {
            this.Target = target;
            this.Parameter = parameter;
            this.Argument = arg;
        }

        public Type Target {get;}

        public TypeParameter Parameter {get;}

        public Type Argument {get;}

        public override string ToString() 
            => Argument.DisplayName();
    }
}