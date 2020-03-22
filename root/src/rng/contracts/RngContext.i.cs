//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    
    /// <summary>
    /// A context that carries an RNG state
    /// </summary>
    public interface IRngContext : IPolyrandProvider, IAppContext
    {   
           
    }
}