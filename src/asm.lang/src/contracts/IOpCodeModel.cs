//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IOpCodeModel
    {

    }

    public interface IOpCodeModel<T> : IOpCodeModel
        where T : unmanaged, IOpCodeModel<T>
    {

    }
}