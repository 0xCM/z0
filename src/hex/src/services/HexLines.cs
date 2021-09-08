//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct HexLines
    {
        [MethodImpl(Inline), Op]
        public static HexLines Service()
            => new HexLines(DefaultConfig);

        [MethodImpl(Inline), Op]
        public static HexLines Service(HexLineConfig config)
            => new HexLines(config);

        readonly HexLineConfig Config;

        static HexLineConfig DefaultConfig => new HexLineConfig(bpl: 32, labels: true, delimiter: Chars.Space, zeropad: true);

        public HexLines(HexLineConfig config)
        {
            Config = config;
        }

        [Op]
        public uint Emit(ReadOnlySpan<byte> src, StreamWriter dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;

            var line = text.buffer();
            var address = Address32.Zero;
            var offset = 1;
            var restart = true;
            var last = count - 1;
            var i=0u;
            var bpl = Config.BytesPerLine;

            while(i++ <= last)
            {
                address = (Address32)(i - 1);
                ref readonly var b = ref skip(src,i);
                if(restart)
                {
                    line.Append(string.Format("{0} ", address.Format()));
                    restart = false;
                }

                line.Append(string.Format("{0} ", HexFormat.format<W8,byte>(b)));

                if(offset != 0 && (offset % bpl == 0))
                {
                    dst.WriteLine(line.Emit());
                    restart = true;
                }

                offset++;
            }

            if(Config.ZeroPad)
            {
                var fill = bpl - (count % bpl);
                for(var q=0; q<fill; q++)
                {
                    line.Append("00");
                    if(q != fill - 1)
                        line.Append(" ");
                }
            }
            dst.WriteLine(line.Emit());
            return count;
        }
    }
}