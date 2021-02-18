//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = TextRules.Format;

    public readonly struct PropertyFormat : ITextual
    {
        public Name Name {get;}

        public dynamic Value {get;}

        public sbyte Pad {get;}

        [MethodImpl(Inline)]
        internal PropertyFormat(Name name, dynamic value, sbyte pad)
        {
            Name = name;
            Value = value;
            Pad = pad;
        }

        public string Format(char sep)
            => api.format(this, sep);

        public string Format()
            => Format(RP.PropertySep);

        public override string ToString()
            => Format();
    }

    public readonly struct PropertyFormat<T> : ITextual
    {
        public Name Name {get;}

        public T Value {get;}

        public sbyte Pad {get;}

        [MethodImpl(Inline)]
        public PropertyFormat(Name name, T value, sbyte pad)
        {
            Name = name;
            Value = value;
            Pad = pad;
        }

        [MethodImpl(Inline)]
        public PropertyFormat(Name name, T value)
        {
            Name = name;
            Value = value;
            Pad = RP.PropertyPad;
        }

        public string Format(char sep)
            => api.format(this, sep);

         public string Format()
            => Format(RP.PropertySep);

        public override string ToString()
            => Format();
        [MethodImpl(Inline)]
        public static implicit operator PropertyFormat<T>((string name, T value) src)
            => new PropertyFormat<T>(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator PropertyFormat<T>((string name, T value, int pad) src)
            => new PropertyFormat<T>(src.name, src.value, (sbyte)src.pad);

        [MethodImpl(Inline)]
        public static implicit operator PropertyFormat(PropertyFormat<T> src)
            => new PropertyFormat(src.Name, src.Value, src.Pad);
    }
}