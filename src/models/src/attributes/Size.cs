//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines the size, in bytes, of the target element
    /// </summary>
    public class SizeAttribute : Attribute
    {        
        public SizeAttribute(uint size)
        {
            Size = size;
        }

        /// <summary>
        /// The number of bytes occupied by an instance of the targeted element
        /// </summary>
        public ByteSize Size {get;}
    }
}