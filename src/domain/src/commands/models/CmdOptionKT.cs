//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using api = Cmd;

    [StructLayout(LayoutKind.Sequential)]
    public struct CmdOptionData<K,T>
    {
        public K OptionKind;

        public T OptionValue;
    }

    public readonly struct CmdOption<K,T> : ICmdOptionData<CmdOption<K,T>,K,T>
        where K : unmanaged
    {
        public K Kind {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public CmdOption(K kind, T value)
        {
            Kind = kind;
            Value = value;
        }

        public asci32 Name
        {
            [MethodImpl(Inline)]
            get => api.name(this);
        }

        public CmdOptionData<K,T> Data
        {
            [MethodImpl(Inline)]
            get => api.data(this);
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdOption<K,T>((K kind, T value) src)
            => new CmdOption<K,T>(src.kind, src.value);

        [MethodImpl(Inline)]
        public static implicit operator CmdOptionData<K,T>(CmdOption<K,T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator CmdOption<K,T>(Paired<K,T> src)
            => new CmdOption<K,T>(src.Left, src.Right);
    }
}