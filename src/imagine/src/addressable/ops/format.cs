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

        [MethodImpl(Inline), Op]
        public static unsafe string format(StringRef src)
            => sys.@string(src.Address.Pointer<char>());

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(StringRef src)
            => Refs.from<char>(src.Location).Data;

        [MethodImpl(Inline), Op]
        public static int length(StringRef src)
            => (int)(hi(src)/scale<char>());

        [MethodImpl(Inline), Op]
        static ulong lo(StringRef src)
            => core.vcell(src.Location, 0);

        [MethodImpl(Inline), Op]
        static ulong hi(StringRef src)
            => core.vcell(src.Location, 1);

        public static string join(string sep, params StringRef[] refs)
        {
            var dst = text.build();
            var count = refs.Length;
            var src = core.span(refs);
            for(var i=0u; i<count; i++)
            {
                dst.Append(core.skip(refs,i).Format());
                if(i != count - 1)
                    dst.Append(sep);                    
            }
            
            return dst.ToString();
        }


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