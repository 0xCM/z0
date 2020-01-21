//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    public readonly struct MemoryAddress
    {
        public static MemoryAddress Define(ulong absolute, ulong root = 0)
            => new MemoryAddress(absolute, root);
            
        MemoryAddress(ulong absolute, ulong root)
        {
            this.AbsoluteLocation = absolute;
            this.RelativeLocation = root == 0 ? (ushort?)null : (ushort)(absolute - root);
        }
        
        public readonly ulong AbsoluteLocation;

        public readonly ushort? RelativeLocation;
    
        public string Format()
            => Format(this);

        public override string ToString()
            => Format();         

        [MethodImpl(Inline)]
        static string Format(MemoryAddress src)
            => src.RelativeLocation.MapValueOrElse(x => x.FormatSmallHex(true), () => src.AbsoluteLocation.FormatHex(false,true,false,false));

    }
}