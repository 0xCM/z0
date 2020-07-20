//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
     using System;

    /// <summary>
    /// Applied to a command specification to identify and describe it
    /// </summary>
    public class CmdPrototypeAttribute : Attribute
    {
        public CmdPrototypeAttribute(string prototype)
        {
            Prototype = prototype;
        }
        
        /// <summary>
        /// The name of the command, if different from the name of the type that represents it
        /// </summary>
        public StringRef Prototype {get;}

       
        public override string ToString()
            => Prototype;
    }
}