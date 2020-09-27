//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
            
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class RegisterAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets optional name override
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets register type and flags
        /// </summary>
        public RegisterType RegisterType { get; }

        public RegisterAttribute(RegisterType registerType)
        {
            RegisterType = registerType;
        }
    }
}