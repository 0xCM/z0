//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfStepId : ITextual
    {
        /// <summary>
        /// The fully-qualified host name
        /// </summary>
        string HostName {get;}

        /// <summary>
        /// The step token
        /// </summary>
        WfToken Token {get;}
    }

    [Free]
    public interface IWfStepId<H> : IWfStepId, IComparable<H>, IEquatable<H>
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

        string IWfStepId.HostName
            => typeof(H).AssemblyQualifiedName;

        string Name
            => HostName;

        string ITextual.Format()
            => HostName;

        [MethodImpl(Inline)]
        bool IEquatable<H>.Equals(H src)
            => src.Token.Value == Token.Value;

        [MethodImpl(Inline)]
        int IComparable<H>.CompareTo(H src)
            => HostName.CompareTo(src.HostName);

        uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)alg.hash.calc(typeof(H));
        }
    }
}