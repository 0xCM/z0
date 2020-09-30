//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public readonly struct BitStateDelegates
    {
        [Free]
        public delegate BitState UnaryOp(BitState a);

        [Free]
        public delegate BitState BinaryOp(BitState a, BitState b);

        [Free]
        public delegate BitState TernaryOp(BitState a, BitState b, BitState c);
    }
}