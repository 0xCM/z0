//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using Uri = ApiDataUriPart;

    public struct ApiDataUri
    {
        Vector128<uint> Parts;

        [MethodImpl(Inline)]
        internal ApiDataUri(Vector128<uint> src)
        {
            Parts = src;
        }

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => (PartId)vcell(Parts, (byte)Uri.OwningPart);
        }

        public ClrArtifactKey RowType
        {
            [MethodImpl(Inline)]
            get => vcell(Parts,(byte)Uri.RowType);
        }
    }
}