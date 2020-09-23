//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiKeyId;

    public enum IntrinsicApiKey : ushort
    {
        CVTSS2SI = Id.Intrinsic + 1,

        CVTSD2SI,
    }

}