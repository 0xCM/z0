//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICustomFormattable
    {
        string Format();
    }

    /// <summary>
    /// Characterizes a type that formats a parametrically-specified type
    /// </summary>
    public interface IFormattable<F> : ICustomFormattable
        where F : IFormattable<F>
    {
        
    }    

    public interface ICustomFormattable<C> : ICustomFormattable
        where C : struct
    {
        string Format(C config);

        string ICustomFormattable.Format()
            => Format(default);
    }

    public interface IFormattable<F,C> : IFormattable<F>, ICustomFormattable<C>
        where F : IFormattable<F,C>
        where C : struct
    {

    }

    /// <summary>
    /// Reifies a meaningless implementation of IFormatConfig
    /// </summary>
    readonly struct DefautFormatConfig {}
}