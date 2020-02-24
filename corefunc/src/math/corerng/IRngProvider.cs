//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    public interface IRngProvider
    {
        /// <summary>
        /// The provided random number generator
        /// </summary>
        IPolyrand Random {get;}
        
    }

}