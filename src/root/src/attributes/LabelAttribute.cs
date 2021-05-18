//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Labels anything since the system-defined DisplayNameAttribute has ridiculously stupid target restrictions
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class LabelAttribute : Attribute
    {
        public string Label {get;}

        public LabelAttribute(string name)
            => Label = name;
    }
}