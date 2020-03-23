//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public interface ICustomFormattable
    {
        string Format();

    }

    public interface IConfiguredFormattable : ICustomFormattable
    {
        string Format(IFormatConfig config);        
    }

    /// <summary>
    /// Characterizes a type that formats a parametrically-specified type
    /// </summary>
    public interface IFormattable<F> : ICustomFormattable
        where F : IFormattable<F>
    {
        
    }    

    public interface IFormattable<F,C> : IFormattable<F>, IConfiguredFormattable
        where F : IFormattable<F,C>
    {
        string Format(C config);

        string IConfiguredFormattable.Format(IFormatConfig config)
            => Format((C)config);
    }

}