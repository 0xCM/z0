//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiOpId;

    /// <summary>
    /// Identifies transcental operation kinds
    /// </summary>
    public enum TranscendentalApiKey : ushort
    {
        None = 0,

        Log10 = Id.Log10,

        Ln = Id.Ln,

        Log = Id.Log
    }
}