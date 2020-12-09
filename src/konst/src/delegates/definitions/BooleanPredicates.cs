//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public readonly struct BooleanPredicates
    {
        [Free]
        public delegate bool TernaryPredicate<T>(T a, T b, T c);
    }
}
