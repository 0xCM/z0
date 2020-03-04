//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public interface ISemanticFormat
    {
        string Format();
    }

    public interface ISemanticFormat<T> : ISemanticFormat
    {
        string Format(T options);
    }

}