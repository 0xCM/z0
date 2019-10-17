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

    public interface ILiteral : IExpr
    {
        
    }

    public interface ILiteral<T> : ILiteral, IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The value of the literal
        /// </summary>
        T Value {get;}                
    }

    public interface IBitLiteralExpr : ILogicExpr, ILiteral<bit>
    {

    }


}