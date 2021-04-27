//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct CmdVar<K>
        where K : unmanaged
    {
        public K Id {get;}

        public VarContextKind VarContext
            => VarContextKind.Workflow;

        Cell128 _Value;

        bool IsString;

        [MethodImpl(Inline)]
        public CmdVar(K id)
        {
            Id = id;
            _Value = default;
            IsString = false;
        }

        [MethodImpl(Inline)]
        public CmdVar(K id, Cell128 value)
        {
            Id = id;
            _Value = value;
            IsString = false;
        }

        [MethodImpl(Inline)]
        public CmdVar(K id, string value)
        {
            Id = id;
            _Value = @ref(value).Storage;
            IsString = true;
        }

        public Cell128 Value
        {
            [MethodImpl(Inline)]
            get => _Value;
        }

        [MethodImpl(Inline)]
        public CmdVar<K> Set(Cell128 value)
        {
            _Value = value;
            return this;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdVar<K>(K name)
            => new CmdVar<K>(name);

        [MethodImpl(Inline)]
        public string Format()
        {
            if(IsString)
                return (new StringRef(_Value)).Format();
            else
                return _Value.Format();
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdVar<K>((K id, Cell128 value) src)
            => new CmdVar<K>(src.id, src.value);

        [MethodImpl(Inline)]
        public static implicit operator CmdVar<K>(Paired<K,Cell128> src)
            => new CmdVar<K>(src.Left, src.Right);


        /// <summary>
        /// Creates a reference to a string
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        static unsafe StringRef @ref(string src)
            => new StringRef((ulong)memory.pchar(src), (uint)src.Length);

    }
}