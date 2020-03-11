//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Security;

    using static Root;

    public readonly struct FixedDelegate
    {
        /// <summary>
        /// The operation identity
        /// </summary>
        public readonly OpIdentity Id;

        public readonly IntPtr SourceAddress;

        public readonly DynamicMethod Enclosure;

        public readonly Delegate DynamicOp;        

        [MethodImpl(Inline)]
        public static FixedDelegate Define(OpIdentity id, IntPtr src, DynamicMethod enclosure, Delegate dynop)        
            => new FixedDelegate(id,src,enclosure,dynop);

        [MethodImpl(Inline)]
        public static implicit operator Delegate(FixedDelegate src)            
            => src.DynamicOp;
            
        [MethodImpl(Inline)]
        FixedDelegate(OpIdentity id, IntPtr src, DynamicMethod enclosure, Delegate dynop)
        {
            this.Id = id;
            this.SourceAddress = src;
            this.Enclosure = enclosure;
            this.DynamicOp = dynop;
        }
    }    
}