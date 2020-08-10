//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ToolOutcome
    {
        public readonly bool Status;

        public readonly string[] Description;

        public ToolOutcome(bool status, params string[] description)
        {
            Status = status;
            Description = description;
        }    
    }
}