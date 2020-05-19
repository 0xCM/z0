//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    
    partial class Cmd
    {
        [MethodImpl(Inline), Op]
        internal static byte size(in ReadOnlySpan<byte> src)
        {
            var count = 0;
            ref readonly var current = ref skip(src, 0);
            for(var i=0; i<Command.PhysicalSize; i++)
            {
                ref readonly var src8 = ref skip(current, i);
                if(src8 != 0)
                    count = i + 1;
            }
            return (byte)count;
        }


        /// <summary>
        /// Computes the minimum number of bytes required to cover the represented command
        /// </summary>
        /// <param name="src">The command</param>
        [MethodImpl(Inline), Op]
        public static byte size(in Command src)
            => size(src.Encoded);
    }
}