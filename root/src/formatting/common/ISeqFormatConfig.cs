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

    public interface ISeqFormatConfig : IFormatConfig
    {
        string Delimiter {get;}
    }

    public interface ISeqFormatConfig<C> : ISeqFormatConfig
        where C : ISeqFormatConfig
    {


    }
}