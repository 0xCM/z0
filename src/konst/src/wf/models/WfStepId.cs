//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct WfStepId :
        IComparable<WfStepId>,
        IEquatable<WfStepId>,
        INamed<WfStepId>,
        ITextual
    {
        /// <summary>
        /// The step token
        /// </summary>
        public WfToken Token {get;}

        /// <summary>
        /// The step name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The host type
        /// </summary>
        public Type Host {get;}

        [MethodImpl(Inline)]
        public WfStepId(Type host, string name, WfToken token)
        {
            Host = host;
            Token = token;
            Name = host.Name;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Token.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Token.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public bool Equals(WfStepId src)
            => Token.Value == src.Token.Value;

        [MethodImpl(Inline)]
        public int CompareTo(WfStepId src)
            => Name.CompareTo(src.Name);

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => z.hash(Token);
        }

        public override int GetHashCode()
            => (int)Hashed;


        public override bool Equals(object src)
            => src is WfStepId i && Equals(i);

        public override string ToString()
            => Format();

        public static WfStepId Empty
            => AB.step(typeof(void));
    }
}