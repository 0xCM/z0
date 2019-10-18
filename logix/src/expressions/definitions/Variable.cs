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

    public sealed class LogicVariable : IlogicVariable
    {

        [MethodImpl(Inline)]
        public LogicVariable(string name, ILogicExpr init)
        {
            this.Name = name;
            this.Value = init;
        }

        [MethodImpl(Inline)]
        public LogicVariable(string name, bit init)
        {
            this.Name = name;
            this.Value = new BitLiteralExpr(init);
        }

        /// <summary>
        /// The variable name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The varible value
        /// </summary>
        public ILogicExpr Value {get; private set;}

        IExpr IVariable.Value 
            => Value;

        [MethodImpl(Inline)]
        public void Set(ILogicExpr value)
        {
            this.Value = value;
        }

        [MethodImpl(Inline)]
        public void Set(bit value)
        {
            this.Value = new BitLiteralExpr(value);
        }


        [MethodImpl(Inline)]
        public void Set(IExpr value)
            => Value = (ILogicExpr)value;

        public string Format()
            => Format(true);

        public string Format(bool withValue)
            => $"v_{Name}" + (withValue ? $" := {Value}" : string.Empty);
        
        public override string ToString()
            => Format();

    }


}