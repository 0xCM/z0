//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;

    partial struct Addressable
    {
        [MethodImpl(Inline), Op]
        public static string format(RelAddress<W32,W16,uint,ushort> src)
            => src.Format();

        [MethodImpl(Inline), Op]
        public static string format(RelAddress<W32,W32,uint,uint> src)
            => src.Format();

        // public string Format()
        //     => text.join(" ", Slot0, Slot1, Slot2);

        // public string Format(bool diagnostic)
        //     => text.concat(
        //         nameof(Slot0), " := ", Slot0.Address, text.bracket(Slot0.Length), Space, text.embrace(Slot0.Text),
        //         nameof(Slot1), " := ", Slot1.Address, text.bracket(Slot1.Length), Space, text.embrace(Slot1.Text),
        //         nameof(Slot2), " := ", Slot2.Address, text.bracket(Slot2.Length), Space, text.embrace(Slot2.Text)
        //         );            

    }
}