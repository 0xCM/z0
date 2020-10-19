//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    public interface INumericKindFacet<T>
        where T : unmanaged
    {
        NumericKind NumericKind
            => NumericKinds.kind<T>();
    }
}