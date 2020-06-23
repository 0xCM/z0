//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CheckInvariant : TCheckInvariant
    {
        public static TCheckInvariant Checker => default(CheckInvariant);
    }

}