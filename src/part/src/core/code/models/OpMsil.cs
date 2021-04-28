//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct OpMsil
    {
        public CliToken Token {get;}

        /// <summary>
        /// The operation identity
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The code's base address
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The Cli signature
        /// </summary>
        public CliSig CliSig {get;}

        /// <summary>
        /// The encoded cil
        /// </summary>
        public BinaryCode MsilCode {get;}

        /// <summary>
        /// The method implementation attributes
        /// </summary>
        public MethodImplAttributes ImplSpec {get;}

        [MethodImpl(Inline)]
        public OpMsil(CliToken id, MemoryAddress @base, OpUri uri, CliSig sig, BinaryCode data, MethodImplAttributes impl)
        {
            Token = id;
            BaseAddress = @base;
            Uri = uri;
            MsilCode = data;
            CliSig = sig;
            MsilCode = data;
            ImplSpec = impl;
        }
    }
}