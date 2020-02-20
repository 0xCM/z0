//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class FixedAsm
    {
        [MethodImpl(Inline)]
        public static FixedAsm<T> Parse<T>(OpIdentity id, string data)
            where T : unmanaged, IFixed
                => AsmCode.Parse(id,data).ToFixed<T>();
        
        [MethodImpl(Inline)]
        public static FixedAsm<T> ToFixed<T>(this AsmCode src)
            where T : unmanaged, IFixed
                => new FixedAsm<T>(src);
    }

    public readonly struct FixedAsm<T>
        where T : unmanaged, IFixed
    {

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
        public byte[] Encoded
        {
            [MethodImpl(Inline)]
            get => Code.Encoded;
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