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

    public interface ICustomFormattable
    {
        string Format();

    }

    public interface IConfiguredCustomFormattable : ICustomFormattable
    {
        string Format(IFormatConfig config);        

    }

    public interface IConfiguredCustomFormattable<C> : IConfiguredCustomFormattable
    {
        string Format(C config);

        [MethodImpl(Inline)]
        string IConfiguredCustomFormattable.Format(IFormatConfig config)
            => Format((C)config);
    }

    /// <summary>
    /// Characterizes a type that provides intrinsic formatting capability
    /// </summary>
    public interface IFormattable<F> : ICustomFormattable
    {
        
    }    
}