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
    /// Defines an ordered sequence of argment expressions
    /// </summary>
    public class AsmArgList : AsmExpr
    {
        public AsmArgList(params AsmArgExpr[] args)
        {
            this.Members = args;
        }
        
        public AsmArgExpr[] Members {get;}

    }

}