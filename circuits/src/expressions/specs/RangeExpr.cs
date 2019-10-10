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

    partial class Bitwise
    {
        /// <summary>
        /// Defines a contiguous sequence of scalar values
        /// </summary>
        /// <typeparam name="T">The scalar type</typeparam>
        public readonly struct RangeExpr<T> : IScalarExpr<T>
            where T : unmanaged
        {
            public RangeExpr(T min, T max)
            {
                this.Min = min;
                this.Max = max;
            }
            
            public readonly T Min;


            public readonly T Max;

            public ExprArity Arity => ExprArity.Binary;     
        }

    }

}