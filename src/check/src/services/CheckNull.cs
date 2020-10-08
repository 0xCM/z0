//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CheckNull : TCheckNull
    {
        public static TCheckNull Checker => default(CheckNull);
    }
}