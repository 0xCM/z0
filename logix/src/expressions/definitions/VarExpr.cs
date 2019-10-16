//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public sealed class VarExpr : IVarExpr
    {

        [MethodImpl(Inline)]
        public VarExpr(string name, IExpr init)
        {
            this.Name = name;
            this.Value = init;
        }

        /// <summary>
        /// The expression arity
        /// </summary>
        public ArityKind Arity => ArityKind.Unary;
        
        /// <summary>
        /// The variable name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The varible value
        /// </summary>
        public IExpr Value {get; private set;}

        [MethodImpl(Inline)]
        public void Set(IExpr value)
        {
            this.Value = value;
        }


        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();
    }


}