//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiClass;

    [ApiClass]
    public enum UnaryBitLogicApiClass : ushort
    {
        None = 0,

        Not = Id.Not,
    }
}