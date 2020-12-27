//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Datatype]
    public readonly struct WfStepId : IWfStepId
    {
        public ClrToken HostKey {get;}

        public string HostName {get;}

        public string HostIdentifier
            => HostName.LeftOfFirst(Chars.Comma).RightOfLast(Chars.Dot);

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(Type control)
            => new WfStepId(control);

        [MethodImpl(Inline)]
        public WfStepId(Type control)
        {
            HostName = control.AssemblyQualifiedName;
            HostKey = control.MetadataToken;
        }

        /// <summary>
        /// The step token
        /// </summary>
        public WfToken Token
        {
            [MethodImpl(Inline)]
            get => WfToken.create(this);
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
            => HostName.CompareTo(src.HostName);

        [MethodImpl(Inline)]
        public string Format()
            => HostIdentifier;

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
            => new WfStepId(typeof(void));
    }
}