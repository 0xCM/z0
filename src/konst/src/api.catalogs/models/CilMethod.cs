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

    public readonly struct CilMethod
    {
        public ClrToken Id {get;}

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
        public CliSig Signature {get;}

        /// <summary>
        /// The encoded cil
        /// </summary>
        public BinaryCode Encoded {get;}

        /// <summary>
        /// The method implementation attributes
        /// </summary>
        public MethodImplAttributes ImplSpec {get;}

        [MethodImpl(Inline)]
        public CilMethod(ClrToken id, MemoryAddress @base, OpUri name, CliSig sig, BinaryCode data, MethodImplAttributes impl)
        {
            Id = id;
            BaseAddress = @base;
            Signature = sig;
            Uri = name;
            Encoded = data;
            ImplSpec = impl;
        }
    }
}