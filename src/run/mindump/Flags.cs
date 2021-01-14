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

    public readonly struct Flags
    {
        [MethodImpl(Inline)]
        public static Flags8<E> flags8<E>(E e)
            where E : unmanaged, Enum
                => new Flags8<E>(e);

        public static string format<E>(Flags8<E> src, bool enabledOnly = true)
            where E : unmanaged, Enum
        {
            var fields = Clr.fields<E>();
            var count = root.min(fields.Length, Flags8<E>.Width);
            var buffer = Buffers.text();
            for(byte i=0; i<count; i++)
            {
                var state = src[(Pow2x8)i];
                render(skip(fields,i), state, buffer, enabledOnly);

            }
            return buffer.Emit();
        }

        public static string format<E>(Flags64<E> src, bool enabledOnly = true)
            where E : unmanaged, Enum
        {
            var fields = Clr.fields<E>();
            var count = root.min(fields.Length, Flags64<E>.Width);
            var buffer = Buffers.text();
            for(byte i=0; i<count; i++)
            {
                var field = skip(fields,i);
                // var state = src[(Pow2x64)Pow2.pow(i)];
                // render(skip(fields,i), state, buffer, enabledOnly);
            }
            return buffer.Emit();
        }

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
    }
}