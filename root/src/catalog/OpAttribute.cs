//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    /// <summary>
    /// Identifies a formal operation for inclusing in the identity assignment and catalog system
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class OpAttribute : Attribute
    {
        public string Name {get;}

        /// <summary>
        /// Indicates whether the operation return type should be reflected in the identity
        /// </summary>
        public bool IncludeReturn {get;}

        public OpAttribute(bool @return = false)
        {
            this.Name = string.Empty;
            this.IncludeReturn = @return;
        }

        public OpAttribute(string name, bool @return = false)
        {
            this.Name = name;          
            this.IncludeReturn = @return;  
        }

        public override string ToString()
            => Name;
    }
}