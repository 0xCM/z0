//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using Z0.Asm;

    [ApiHost]
    public readonly partial struct asm
    {

        [Op]
        public static ApiInstructionLookup deduplicate(ApiInstruction[] src, out ApiInstructionDuplication stats)
        {
            var count = (uint)src.Length;
            var lookup = new ApiInstructionLookup((int)count);
            var success = 0u;
            var fail = 0u;
            var source = sys.span(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var located = ref z.skip(source,i);
                if(lookup.TryAdd(located.IP, located))
                    success++;
                else
                    fail++;
            }

            stats = new ApiInstructionDuplication(success, fail);
            return lookup;
        }

        public static asm Service => new asm(2);

        readonly object[] state;

        [MethodImpl(Inline)]
        StringBuilder builder()
        {
            ((StringBuilder)state[1]).Clear();
            return ((StringBuilder)state[1]);
        }

        [MethodImpl(Inline)]
        static string render(StringBuilder src)
        {
            var dst = src.ToString();
            src.Clear();
            return dst;
        }

        ref object this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref state[index];
        }

        ref readonly HexFormatOptions HexConfig
        {
            [MethodImpl(Inline)]
            get => ref z.@as<object,HexFormatOptions>(this[0]);
        }

        public asm(int i)
        {
            state = new object[i];
            state[0] = HexFormatSpecs.options(zpad:false, specifier:false);
            state[1] = new StringBuilder(1024);
        }
    }
}