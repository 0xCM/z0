//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    [ApiDataType]
    public readonly struct LocatedValues
    {
        [MethodImpl(Inline)]
        public static Vector512<ulong> pack(ulong @offset)
        {
            var slots = LocatedValues.init(@offset);
            return (slots.Locations, slots.Values);
        }

        [MethodImpl(Inline)]
        public static LocatedValues init(ulong @base)
            => new LocatedValues(@base);
        
        readonly ulong Slot0;

        readonly ulong Slot1;        

        readonly ulong Slot2;        

        readonly ulong Slot3;        


        [MethodImpl(Inline)]
        public LocatedValues(ulong @base)
        {
            Slot0 = @base*1;
            Slot1 = @base*2;
            Slot2 = @base*4;
            Slot3 = @base*8;    
                
        }

        public Vector256<ulong> Locations
        {
            [MethodImpl(Inline)]
            get => vparts(w256, Location0, Location1, Location2, Location3);
        }

        public Vector256<ulong> Values
        {
            [MethodImpl(Inline)]
            get => vload(w256, @as<LocatedValues,ulong>(this));
        }

        ulong Location0
        {
            [MethodImpl(Inline)]
            get => locate(Slot0);
        }

        ulong Location1
        {
            [MethodImpl(Inline)]
            get => locate(Slot1);
        }

        ulong Location2
        {
            [MethodImpl(Inline)]
            get => locate(Slot2);
        }

        ulong Location3
        {
            [MethodImpl(Inline)]
            get => locate(Slot3);
        }
    }
}