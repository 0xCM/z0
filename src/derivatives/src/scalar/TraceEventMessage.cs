//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.Scalar
{
    using System;

    public class TraceEventMessage
    {
        public string EventName { get; set; }

        public Guid ActivityId { get; set; }

        public Guid ParentActivityId { get; set; }

        public EventLevel Level { get; set; }

        public Keywords Keywords { get; set; }

        public EventOpcode Opcode { get; set; }

        public string Payload { get; set; }
    }
}
