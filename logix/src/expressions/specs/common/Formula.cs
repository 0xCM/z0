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
    /// Represents an expression of the form identifier := expression
    /// </summary>
    public class Formula : IFormula
    {
        public Formula(string name, IExpr encoding)
        {
            this.Name = name;
            this.Encoding = encoding;
        }
        
        public string Name {get;}

        public IExpr Encoding {get;}

        public string Format()
            => $"{Name} := {Encoding.Format()}";
    }

    /// <summary>
    /// Represents an expression of the form identifier := expression[T]
    /// </summary>
    public sealed class Formula<T> : Formula, IFormula<T>
        where T : unmanaged
    {
        public Formula(string name, IExpr<T> encoding)
            : base(name,encoding)
        {
            this.Encoding = encoding;
        }
        public new IExpr<T> Encoding {get;}
    }

}