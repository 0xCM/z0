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

    [ApiHost]
    public readonly partial struct asm
    {
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
        
        ref readonly HexFormatConfig HexConfig
        {
            [MethodImpl(Inline)]
            get => ref z.@as<object,HexFormatConfig>(this[0]);
        }

        public asm(int i)
        {
            state = new object[i];
            state[0] = HexFormat.configure(zpad:false, specifier:false);
            state[1] = new StringBuilder(1024);
        }
    }
}