//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Joins a capture service with a junction
    /// </summary>
    public interface ICaptureControl : ICaptureService, ICaptureJunction
    {

    }
}