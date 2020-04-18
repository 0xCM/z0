//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    public sealed class DistinctFacet : SelectionFacet<DistinctFacet,bool>
    {
        public DistinctFacet(bool Enabled = true)
            : base("Distinct", Enabled)
        {

        }

    }



}