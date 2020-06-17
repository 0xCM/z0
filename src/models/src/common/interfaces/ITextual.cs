//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITextual
    {
        string Format();
    }

    /// <summary>
    /// Characterizes a type that formats a parametrically-specified type
    /// </summary>
    public interface ITextual<F> : ITextual
        where F : ITextual<F>
    {
        
    }    

    public interface ITextual<F,C> : ITextual<F>
        where F : ITextual<F,C>
        where C : struct
    {
        string Format(C config);

        string ITextual.Format()
            => Format(default);
    }    
}