//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class StepAttribute : Attribute
    {
        public StepAttribute(WfStepId id)
        {
            Id = id;
            IsDescriptor = false;
        }

        public StepAttribute(WfStepId id, bool descriptor)
        {
            Id = id;
            IsDescriptor = descriptor;
        }

        public WfStepId Id {get;}

        public bool IsDescriptor {get;}
    }
}