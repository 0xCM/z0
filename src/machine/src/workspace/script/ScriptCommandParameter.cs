//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Represents a parameter referenced in a <see cref="ScriptCommand"/>
    /// </summary>
    public class ScriptCommandParameter 
    {
        public ParameterInfo ClrParameter {get;}

        public string ParameterName {get;}

        public string Description {get;}

        public ScriptCommandParameter(ParameterInfo ClrParameter, string Description, string ParameterName = null)
        {
            this.ClrParameter = ClrParameter;
            this.Description = Description;
            this.ParameterName = ParameterName ?? ClrParameter.Name;
        }


        public override string ToString() 
            => text.concat(
                $"{ParameterName} : {ClrParameter.ParameterType.Name}",
                (text.blank(Description) ? String.Empty : $" - {Description}")
            );
    }
}