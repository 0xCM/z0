//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public readonly struct TypedOperatorClass : IFormattable<TypedOperatorClass>
    {
        public static Option<TypedOperatorClass> Infer(MethodInfo src)
        {
            var no = none<TypedOperatorClass>();
            var c = src.ClassifyOperator();
            if(c.IsNone())
                return no;
            var kind =  src.ReturnType;
            return Define(c,src.ReturnType);
        }

        [MethodImpl(Inline)]
        public static TypedOperatorClass Define(OperatorClass @class, Type type)
            => new TypedOperatorClass(@class, type);

        [MethodImpl(Inline)]
        TypedOperatorClass(OperatorClass @class, Type type)
        {
            this.OperatorClass = @class;
            this.OperandType = type;
        }
        
        public readonly OperatorClass OperatorClass;
        
        public readonly Type OperandType;

        public string Format()
            => "f:" +  Identity.identify(OperandType).Format().Replicate(OperatorClass.Arity() + 1).Intersperse("->").Concat();
        
        public override string ToString()
            => Format();
    }

}