//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class TopFacet : SelectionFacet<TopFacet,int>
    {
        public TopFacet(int Count)
            : base("Top", Count)
        {
        
        }      
    }

}