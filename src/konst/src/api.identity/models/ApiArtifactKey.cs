//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.Intrinsics;

    using static Part;
    public readonly struct ApiArtifactKey : ITextual
    {
        const byte KeyIndex = 2;

        const byte PartIndex = 0;

        const string IdentifierPattern = "{0}_{1}_{2}_{3}";

        const string ArtifactPattern = "metadata://{0}/{1}/{2}/{3}";

        /// <summary>
        /// Creates a <see cref='ApiArtifactKey'/> that identifies a specified method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline), Op]
        public static ApiArtifactKey define(MethodInfo src)
        {
            var host = src.DeclaringType;
            return new ApiArtifactKey(cpu.vparts(w128, (uint)host.Assembly.Id(), (uint)host.MetadataToken, (uint)src.KindId(), (uint)src.MetadataToken));
        }

        [MethodImpl(Inline), Op]
        public static ApiClass kind(in ApiArtifactKey src)
            => (ApiClass)cpu.vcell(src.Data, KeyIndex);

        [MethodImpl(Inline), Op]
        public static PartId part(in ApiArtifactKey src)
            => (PartId)cpu.vcell(src.Data, PartIndex);

        [MethodImpl(Inline), Op]
        public static bool eq(in ApiArtifactKey a,in ApiArtifactKey b)
            => a.Data.Equals(b.Data);

        [MethodImpl(Inline), Op]
        public static string identifier(ApiClass src)
            => string.Format("{0}", src != 0 ? src.Format() : "unkinded");

        [MethodImpl(Inline), Op]
        public static string identifier(PartId src)
            => src.Format();

        [Op]
        public static string identifier(in ApiArtifactKey src)
            => string.Format(IdentifierPattern, identifier(src.Part), identifier(src.KindKey), src.HostId, src.OperationId);

        [Op]
        public static string format(in ApiArtifactKey src)
            => string.Format(ArtifactPattern, identifier(src.Part), identifier(src.KindKey), src.HostId, src.OperationId);

        internal const byte HostIndex = 1;

        internal const byte OpIndex = 3;

        internal readonly Vector128<uint> Data;

        [MethodImpl(Inline)]
        public ApiArtifactKey(Vector128<uint> src)
            => Data = src;

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => part(this);
        }

        public ClrToken HostId
        {
            [MethodImpl(Inline)]
            get => cpu.vcell(Data, HostIndex);
        }

        public ApiClass KindKey
        {
            [MethodImpl(Inline)]
            get => kind(this);
        }

        public ClrToken OperationId
        {
            [MethodImpl(Inline)]
            get => cpu.vcell(Data, OpIndex);
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => identifier(this);
        }

        [MethodImpl(Inline)]
        public bool Equals(ApiArtifactKey src)
            => eq(this,src);

        public override string ToString()
            => Format();

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => cpu.vnonz(Data);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => !cpu.vnonz(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactKey(MethodInfo src)
            => define(src);

        public static ApiArtifactKey Empty => default;
    }
}