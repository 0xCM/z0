//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct CaptureState
    {
        [MethodImpl(Inline)]
        public static implicit operator CaptureState((int offset, long location, byte value) src)
            => Define(src.offset, src.location, src.value);

        [MethodImpl(Inline)]
        public static CaptureState Define(int offset, long location, byte value)
            => new CaptureState(offset,location,value);
        
        [MethodImpl(Inline)]
        CaptureState(int offset, long location, byte value)
        {
            this.Offset = offset - 1;
            this.Location = location - 1;
            this.Data = value;
        }

        public readonly int Offset;

        public readonly long Location;

        public readonly byte Data;

        [MethodImpl(Inline)]
        public void Deconstruct(out int offset, out long location, out byte value)        
        {
            offset = Offset;
            location = Location;
            value = Data;
        }

        public override string ToString() 
            => concat(Offset.FormatAsmHex(4), space(), Location.FormatAsmHex(14), space(), Data.FormatHex());
    }
}