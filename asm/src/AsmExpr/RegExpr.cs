//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IRegExpr : IAsmExpr
    {

    }

    /// <summary>
    /// Identifies a register
    /// </summary>
    public class RegExpr : AsmExpr, IRegExpr
    {



    }

    public interface IRegExpr<T> : IRegExpr
        where T : unmanaged, Enum
    {
        
        T Kind {get;}

    }   

    public abstract class RegExpr<T> :  RegExpr, IRegExpr<T>
        where T : unmanaged, Enum
    {
        public T Kind {get;}

        protected RegExpr(T Kind)
        {
            this.Kind = Kind;
        }
    }

}