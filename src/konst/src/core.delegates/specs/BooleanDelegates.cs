//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public readonly struct BooleanDelegates
    {
        [Free]
        public delegate bool UnaryOp(bool a);

        [Free]
        public delegate bool BinaryOp(bool a, bool b);

        [Free]
        public delegate bool TernaryOp(bool a, bool b);
    }
}