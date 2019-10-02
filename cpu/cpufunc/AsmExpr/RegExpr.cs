//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Identifies a register
    /// </summary>
    public class RegExpr : AsmExpr
    {



    }

    public abstract class RegExpr<T> : RegExpr
        where T : Enum
    {
        public T Kind {get;}

        protected RegExpr(T Kind)
        {
            this.Kind = Kind;
        }
    }

}