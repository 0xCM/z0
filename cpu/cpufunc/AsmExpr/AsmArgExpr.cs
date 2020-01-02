//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class AsmArgExpr : AsmExpr
    {
        public AsmArgExpr(int index, IAsmExpr val)
        {
            this.ArgIdx = index;
            this.ArgVal = val;
        }

        /// <summary>
        /// The 0-based position of the argment relative to other argments 
        /// </summary>
        public int ArgIdx {get;}

        /// <summary>
        /// The argment value
        /// </summary>
        public IAsmExpr ArgVal {get;}
    }


}