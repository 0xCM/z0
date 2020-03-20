//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Identifies format configurations
    /// </summary>
    public interface IFormatConfig
    {
        
    }

    public interface IFormatConfig<C> : IFormatConfig
        where C : struct, IFormatConfig<C>
    {

        
    }

    /// <summary>
    /// Reifies a meaningless implementation of IFormatConfig
    /// </summary>
    readonly struct DefautFormatConfig : IFormatConfig {}
    
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

        [MethodImpl(Inline)]
        string IConfiguredFormattable.Format(IFormatConfig config)
            => Format((C)config);
    }

}