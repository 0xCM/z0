//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    
    public class RuntimePart<P>
        where P : Part<P>, IPart<P>, new()    
    {        
        protected PartBox Box;

        [MethodImpl(Inline)]
        public RuntimePart(PartBox data)
            => Box = data;
    }                        
}