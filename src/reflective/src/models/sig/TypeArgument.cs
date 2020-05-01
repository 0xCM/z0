//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public readonly struct TypeArgument : ITextual<TypeArgument>
    {
        public string Name {get;}
        public Type Target {get;}

        public TypeParameter Parameter {get;}

        public Type Argument {get;}

        internal TypeArgument(Type target, TypeParameter parameter, Type arg)
        {
            this.Name = arg.Name;
            this.Target = target;
            this.Parameter = parameter;
            this.Argument = arg;
        }
        
        public string Format()
            => Argument.DisplayName();

        public override string ToString() 
            => Format();
    }
}