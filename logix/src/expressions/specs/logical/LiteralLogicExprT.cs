//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    /// <summary>    
    /// Defines an untyped literal expression
    /// </summary>
    public sealed class LiteralLogicExpr<T> : ILogicLiteral<T>
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public LiteralLogicExpr(bit value)
        {                
            this.Value= value;
        }            

        /// <summary>
        /// The literal value
        /// </summary>
        public bit Value {get;}
         
        public string Format()
            => $"{Value}";

        public override string ToString() 
            => Format();
    }


}