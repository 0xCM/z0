//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines multiplicity categories
    /// </summary>
    public enum MultiplicityKind : sbyte
    {
        Unknown = 0,

        ZeroOrOne = -1,

        One = 1,

        ZeroOrMore = 2,

        OneOrMany = 3,
    }
}