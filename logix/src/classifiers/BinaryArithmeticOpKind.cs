//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Classsifies (supported) arithmetic operators
    /// </summary>
    public enum BinaryArithmeticOpKind : uint
    {
        Add = Pow2.T00,

        Sub = Pow2.T01,


    }

}