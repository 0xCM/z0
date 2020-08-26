//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class StepAttribute : Attribute
    {
        public Type Host {get;}
        
        public string StepName {get;}            
        
        public StepAttribute(bool descriptor = false)
        {
        
        }

        public StepAttribute(Type host, string name = null)
        {
            Host = host;
            StepName =  name ?? host.Name;
        }
        
        public StepAttribute(object id)
        {
        
        }

        public StepAttribute(object id, bool descriptor)
        {
        
        }
    }
}