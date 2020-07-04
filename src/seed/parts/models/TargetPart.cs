//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public readonly struct TargetPart
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        public TargetPart(PartId src, PartId dst)
        {
            Data = (ulong)((uint)src) | (((ulong)(uint)dst) << 32);
        }

        public PartId Source    
        {
            [MethodImpl(Inline)]
            get => (PartId)((uint)Data);
        }

        public PartId Target
        {
            [MethodImpl(Inline)]
            get => (PartId)(Data >> 32);
        } 

        [MethodImpl(Inline)]
        public string Format() 
            => $"{Source} -> {Target}";
        
        public override string ToString() 
            => Format();
    }
}