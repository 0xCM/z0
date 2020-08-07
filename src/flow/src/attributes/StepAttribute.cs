//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class StepAttribute : Attribute
    {
        public StepAttribute(bool descriptor = false)
        {
            Id = default;
            IsDescriptor = descriptor;
        }

        public StepAttribute(WfStepKind id)
        {
            Id = id;
            IsDescriptor = false;
        }

        public StepAttribute(WfStepKind id, bool descriptor)
        {
            Id = id;
            IsDescriptor = descriptor;
        }

        public WfStepKind Id {get;}

        public bool IsDescriptor {get;}
    }
}