//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Core;

    public static class FixedAsm
    {
        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static AsmCode ParseAsm(OpIdentity id, string data)
            => AsmCode.Define(id, MemoryExtract.Define(HexParser.parsebytes(data).ToArray()));

        [MethodImpl(Inline)]
        public static FixedAsm<T> Parse<T>(OpIdentity id, string data)
            where T : unmanaged, IFixed
                => ParseAsm(id,data).ToFixed<T>();
        
        [MethodImpl(Inline)]
        public static FixedAsm<T> ToFixed<T>(this AsmCode src)
            where T : unmanaged, IFixed
                => new FixedAsm<T>(src);
    }

    public readonly struct FixedAsm<T>
        where T : unmanaged, IFixed
    {

        [MethodImpl(Inline)]
        internal FixedAsm(in AsmCode code)
        {
            this.Code = code;
        }

        public readonly AsmCode Code;        

        /// <summary>
        /// The identifying moniker
        /// </summary>
        public OpIdentity Id
            => Code.Id;

        /// <summary>
        /// The encoded asm bytes
        /// </summary>
        public MemoryExtract Encoded
        {
            [MethodImpl(Inline)]
            get => Code.Data;
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Code.Length;
        }

        public string Format(int idpad = 0)
            => Code.Format(idpad);

        public override string ToString()
            => Format();
    }
}