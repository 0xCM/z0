//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct CheckPrimal : TCheckPrimal
    {
        public static TCheckPrimal Checker => default(CheckPrimal);
    }
}