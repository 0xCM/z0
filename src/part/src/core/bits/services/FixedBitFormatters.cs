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

    public readonly struct FixedBitFormatters
    {
        public static FixedBitFormatters create(Index<IFixedBitFormatter> src)
            => new FixedBitFormatters(src);

        readonly Index<IFixedBitFormatter> _Formatters;

        [MethodImpl(Inline)]
        public FixedBitFormatters(Index<IFixedBitFormatter> formatters)
        {
            _Formatters = formatters;
        }

        public IFixedBitFormatter<T> Formatter<T>()
            where T : struct
        {
            var src = _Formatters.View;
            var count = _Formatters.Count;
            var target = typeof(T);
            if(Formatter(target, out var formatter))
                return (IFixedBitFormatter<T>)formatter;
            else
            return
                new FixedBitFormatter<T>(width<T>());
        }

        public bool Formatter(Type target, out IFixedBitFormatter dst)
        {
            var src = _Formatters.View;
            var count = _Formatters.Count;
            for(var i=0; i<count; i++)
            {
                var formatter = skip(src,i);
                if(formatter.TargetType == target)
                {
                    dst = formatter;
                    return true;
                }

            }
            dst = default;
            return false;
        }
    }
}