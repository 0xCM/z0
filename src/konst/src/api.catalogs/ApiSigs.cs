//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiSigs, true)]
    public readonly struct ApiSigs
    {
        [Op]
        public static byte[] data(Module src, ClrArtifactKey key)
            => src.ResolveSignature((int)key);

        [Op]
        public static ApiSig define(MethodInfo src)
            =>  new ApiSig(ClrArtifactKind.Method, CliSigs.resolve(src));

        [Op]
        public static ApiSig define(Type src)
            => new ApiSig(ClrArtifactKind.Type, CliSigs.resolve(src));

        [Op]
        public static ApiSig define(FieldInfo src)
            => new ApiSig(ClrArtifactKind.Field, CliSigs.resolve(src));

        [Op]
        public static ApiSig define(PartId part, Type host, MethodInfo src)
            => new ApiSig(ClrArtifactKind.Method, instance(part), CliSigs.resolve(host), @CliSigs.resolve(src));

        /// <summary>
        /// Creates a sequence of bytes conforming to the pattern [bytes(value(t:T)) {32 zero bits} ClrSig]
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        [Op, Closures(AllNumeric)]
        static CliSig instance<T>(T src)
            where T : unmanaged
        {
            var tSize = size<T>();
            var tType = typeof(T);
            var sBytes = @readonly(CliSigs.data(tType.Module, tType));
            var iBytes = bytes(src);
            var sCount = sBytes.Length;
            var iCount = size<T>();
            var count = iCount + 4 + sCount;
            var iLast = iCount - 1;
            var sFirst = iLast + 4;
            var buffer = alloc<byte>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                if(i < iLast)
                    seek(dst,i) = skip(iBytes,i);
                else if(i >= sFirst)
                    seek(dst,i) = skip(sBytes,i);
            }

            return buffer;
        }
    }
}