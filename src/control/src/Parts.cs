//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using P = Z0.Parts;

    public readonly struct PartSelection : IContentedIndex<IPart>
    {
        public static PartSelection Selected => default(PartSelection);
        
        IPart[] IContented<IPart[]>.Content
            => new IPart[]{
                P.GMath.Resolved,  
               };
    }
}