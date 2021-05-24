//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using T = AsciLetterUp;

    /// <summary>
    /// Defines facets for the <see cref='T'/> type
    /// </summary>
    [FacetProvider(typeof(T))]
    public readonly struct AsciLetterUpFacets
    {
        public const T First = T.A;

        public const T Last = T.Z;
    }
}