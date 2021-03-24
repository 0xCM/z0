//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using T = AsciLetterUpCode;

    /// <summary>
    /// Defines facets for the <see cref='T'/> type
    /// </summary>
    [FacetProvider(typeof(T))]
    public readonly struct AsciLetterUpCodeFacets
    {
        public const T First = T.A;

        public const T Last = T.Z;

        public const byte Count = Last - First + 1;
    }
}