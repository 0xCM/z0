//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// A succinct type signature
    /// </summary>
    public struct ClrTypeSigInfo
    {
        public string DisplayName;

        public string Modifier;

        public bool IsOpenGeneric;

        public bool IsClosedGeneric;

        public bool IsByRef;

        public bool IsIn;

        public bool IsOut;

        public bool IsPointer;

        public string Format()
            => $"{Modifier}{DisplayName}";

        public override string ToString()
            => Format();
    }
}