//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public interface ICustomFormattable
    {
        string Format();

        [MethodImpl(Inline)]
        string Format(IFormatConfig config)
            => Format();

        [MethodImpl(Inline)]
        string Format<C>(C config)
            where C : IFormatConfig
                => Format();
    }

    /// <summary>
    /// Characterizes a type that provides intrinsic formatting capability
    /// </summary>
    public interface IFormattable<F> : ICustomFormattable
        where F : IFormattable<F>
    {
        
    }    
}