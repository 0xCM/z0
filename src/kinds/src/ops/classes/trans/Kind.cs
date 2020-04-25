//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using Id = OpKindId;

    /// <summary>
    /// Identifies transcental operation kinds
    /// </summary>
    public enum TranscendentalKind : ulong
    {
        None = 0,

        Log10 = Id.Log10,

        Ln = Id.Ln,

        Log = Id.Log
    }

}