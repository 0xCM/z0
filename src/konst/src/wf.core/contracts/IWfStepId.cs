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

    public interface IWfStepId : ITextual, INamed
    {
        /// <summary>
        /// The step token
        /// </summary>
        WfToken Token {get;}
    }

    public interface IWfStepId<H> : IWfStepId, IComparable<H>, IEquatable<H>, INamed<H>
        where H : struct, IWfStepId<H>
    {
        /// <summary>
        /// The step token
        /// </summary>
        WfToken IWfStepId.Token
        {
            [MethodImpl(Inline)]
            get => new WfToken((ulong)typeof(H).MetadataToken);
        }

        string INamed.Name
            => typeof(H).Name;

        string ITextual.Format()
            => Name;


        [MethodImpl(Inline)]
        bool IEquatable<H>.Equals(H src)
            => src.Token.Value == Token.Value;

        [MethodImpl(Inline)]
        int IComparable<H>.CompareTo(H src)
            => Name.CompareTo(src.Name);

        uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)hash(typeof(H));
        }
    }
}