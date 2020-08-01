//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    /// <summary>
    /// Describes a script command parameter
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class ScriptCommandParameterAttribute : Attribute
    {
        public ScriptCommandParameterAttribute(string description, string ParameterName = null)
        {
            this.Description = description;
            this.ParameterName = ParameterName ?? string.Empty;
            
        }

        /// <summary>
        /// Describes the purpose of the parameter
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The name of the parameter, if specified
        /// </summary>
        public string ParameterName { get; }
    }
}