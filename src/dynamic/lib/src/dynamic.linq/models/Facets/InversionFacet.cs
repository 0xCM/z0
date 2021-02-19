//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct DynamicFacet
    {
        public sealed class InversionFacet : SelectionFacet<InversionFacet, bool>
        {
            public InversionFacet(bool Enabled = true)
                : base("Invert", Enabled)
            {

            }
        }
    }
}