//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a workflow step controller
    /// </summary>
    public class StepAttribute : Attribute
    {
        public Type Control {get;}

        public StepAttribute(Type control)
        {
            Control = control;
        }

        public StepAttribute(Type control, string name)
        {
            Control = control;
        }
    }
}