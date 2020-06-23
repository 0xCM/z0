//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface TCheckNumeric : 
        TCheckGeneric, 
        TCheckSpans, 
        TCheckClose,
        ICheckPrimalSeq
    {
    }
}