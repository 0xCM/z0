//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Flags
    {
        [Op, Closures(UInt8k)]
        public static string format<E>(Flags8<E> src, bool enabledOnly = true)
            where E : unmanaged
                => _format(src,enabledOnly);

        [Op, Closures(UInt8k | UInt16k)]
        public static string format<E>(Flags16<E> src, bool enabledOnly = true)
            where E : unmanaged
                => _format(src,enabledOnly);

        [Op, Closures(UInt8k | UInt16k | UInt32k)]
        public static string format<E>(Flags32<E> src, bool enabledOnly = true)
            where E : unmanaged
                => _format(src,enabledOnly);

        [Op, Closures(UnsignedInts)]
        public static string format<E>(Flags64<E> src, bool enabledOnly = true)
            where E : unmanaged
                => _format(src,enabledOnly);

        [Op, Closures(UnsignedInts)]
        public static string format<T>(Flags<T> src)
            where T : unmanaged
                => bit.formatter<T>().Format(src.Value);

        const string RenderPattern = "{0,-48}: {1}" + Eol;

        [MethodImpl(Inline)]
        static void render(ClrField field, bit state, ITextBuffer dst, bit enabledOnly)
        {
            if(enabledOnly)
                if(state)
                    dst.AppendFormat(RenderPattern, field.Name, state);
            else
                dst.AppendFormat(RenderPattern, field.Name, state);
        }

        [MethodImpl(Inline)]
        static string _format<F,W,E>(IFlags<F,E,W> src, bool enabledOnly = true)
            where E : unmanaged
            where W : unmanaged
            where F : IFlags<F,E,W>
        {
            var fields = Clr.fields<E>();
            var count = root.min(fields.Length, src.DataWidth);
            var buffer = text.buffer();
            for(byte i=0; i<count; i++)
            {
                var field = skip(fields, i);
                var state = src[@as<ulong,W>(Pow2.pow(i))];
                render(skip(fields,i), state, buffer, enabledOnly);
            }
            return buffer.Emit();
        }
    }
}