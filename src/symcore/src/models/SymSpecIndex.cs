//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Codifies the implicityly defined ordering over the <see cref='SymSpecKind'/> domain
    /// </summary>
    public enum SymSpecIndex : byte
    {
        Index = 0,

        Kind = 1,

        Name = 2,

        Expression = 3,

        Value = 4,

        Description = 5,

        ValueKind = 6,
    }
}