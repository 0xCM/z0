//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Events
{
    using System;
    using System.Collections.Generic;

    // This is a convenience class to make code around event metadata look nicer.
    // It's more obvious to see EventMetadata than Dictionary<string, object> everywhere.
    public class EventMetadata : Dictionary<string, object>
    {
        public EventMetadata()
        {
        }

        public EventMetadata(Dictionary<string, object> metadata)
            : base(metadata)
        {
        }
    }
}