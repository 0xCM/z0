//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Lines
    {
        [Op]
        public static bool next(ref LineReaderState state, out AsciLine<byte> dst)
        {
            dst = AsciLine<byte>.Empty;
            var line = state.Source.ReadLine();
            if(line == null)
                return false;
            var data = text.asci(line).Storage;
            state.LineCount++;

            if(Lines.number(data, out var length, out var number))
                dst = new AsciLine<byte>(number, data);
            else
                dst = new AsciLine<byte>(state.LineCount, data);

            state.Offset+=length;

            return true;
        }

        public static bool next<T>(ref LineReaderState State, Span<byte> buffer, out AsciLine<T> dst)
            where T : unmanaged
        {
            dst = AsciLine<T>.Empty;
            var _line = State.Source.ReadLine();
            if(_line == null)
                return false;

            var count = AsciSymbols.encode(_line, buffer);
            var data = slice(buffer,0,count);

            State.LineCount++;

            if(Lines.number(data, out var length, out var number))
                dst = new AsciLine<T>(number, recover<byte,T>(slice(data, (int)length)).ToArray());
            else
                dst = new AsciLine<T>(State.LineCount, recover<byte,T>(data).ToArray());

            State.Offset+=length;

            return true;
        }

    }
}