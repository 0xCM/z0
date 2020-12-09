//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate bit BinaryPredicate<T>(T a, T b);

    [Free]
    public delegate bool BinaryPredicate8<T>(T a, T b);
}