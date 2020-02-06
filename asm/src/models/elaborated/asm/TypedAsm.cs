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

    partial class AsmExtend
    {
        [MethodImpl(Inline)]
        public static TypedAsm<T> Typed<T>(this AsmCode src)
            where T : unmanaged
                => new TypedAsm<T>(src);

    }

    public readonly struct TypedAsm<T>
        where T : unmanaged
    {
        readonly AsmCode Code;

        public OpIdentity Id
            => Code.Id;

        public MemoryRange Origin
            => Code.Origin;

        public string Label
            => Code.Label;
         
        public ReadOnlySpan<byte> Data
            => Code.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator AsmCode(TypedAsm<T> src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(TypedAsm<T> src)
            => src.Data;
        
        [MethodImpl(Inline)]
        public TypedAsm(AsmCode src)
        {
            this.Code = src;
        }

        [MethodImpl(Inline)]
        public TypedAsm(OpIdentity id, MemoryRange origin, string label, byte[] data)
        {
            Code = AsmCode.Define(id, origin,label,data);
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsEmpty;
        }

        [MethodImpl(Inline)]
        public TypedAsm<S> As<S>()
            where S : unmanaged
                => new TypedAsm<S>(Code);
    
        public AsmCode Untyped  
        {
            [MethodImpl(Inline)]
            get => Code;
        }

        public string Format()
            => Code.Format();
    }

}