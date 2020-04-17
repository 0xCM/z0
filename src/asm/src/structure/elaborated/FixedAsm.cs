//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class FixedAsm
    {
        [MethodImpl(Inline)]
        public static FixedAsm<T> Parse<T>(OpIdentity id, string data)
            where T : unmanaged, IFixed
                => ApiBits.Parse(id,data).ToFixed<T>();
        
        [MethodImpl(Inline)]
        public static FixedAsm<T> ToFixed<T>(this ApiBits src)
            where T : unmanaged, IFixed
                => new FixedAsm<T>(src);
    }

    public readonly struct FixedAsm<T>
        where T : unmanaged, IFixed
    {

        [MethodImpl(Inline)]
        internal FixedAsm(in ApiBits code)
        {
            this.Code = code;
        }

        public readonly ApiBits Code;        

        /// <summary>
        /// The identifying moniker
        /// </summary>
        public OpIdentity Id
            => Code.Id;

        /// <summary>
        /// The encoded asm bytes
        /// </summary>
        public Addressable Encoded
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