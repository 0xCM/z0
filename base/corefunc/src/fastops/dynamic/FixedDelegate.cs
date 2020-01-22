//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Emit;
    
    using static zfunc;

    public readonly struct FixedDelegate
    {
        public static FixedDelegate Define(Moniker id, IntPtr src, DynamicMethod enclosure, Delegate dynop)        
            => new FixedDelegate(id,src,enclosure,dynop);

        public static implicit operator Delegate(FixedDelegate src)            
            => src.DynamicOp;
            
        FixedDelegate(Moniker id, IntPtr src, DynamicMethod enclosure, Delegate dynop)
        {
            this.Id = id;
            this.SourceAddress = src;
            this.Enclosure = enclosure;
            this.DynamicOp = dynop;
        }

        public readonly Moniker Id;

        public readonly IntPtr SourceAddress;

        public readonly DynamicMethod Enclosure;

        public readonly Delegate DynamicOp;        
    }
}