﻿//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    public interface IMemberValuePredicate : IMemberPredicate
    {
        object Value { get; }
    }
}