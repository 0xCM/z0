//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IEncodedCommand
    {
        /// <summary>
        /// The encoded command
        /// </summary>
        ReadOnlySpan<byte> Encoding {get;}

        byte EncodingSize {get;}

    }
    
    public interface IEncodedCommand<F> : IEncodedCommand
        where F: struct, IEncodedCommand<F>
    {

    }
}