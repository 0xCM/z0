//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiSigs
    {
        public interface ITypeParameter
        {
            ushort Position {get;}

            Name Name {get;}

            TypeSig Closure => TypeSig.Empty;

            bool IsClosed => Closure.IsNonEmpty;

            bool IsOpen => Closure.IsEmpty;
        }

        public interface IClosedParameter : ITypeParameter
        {
            bool ITypeParameter.IsClosed
                => true;
        }

        public interface IOpenParameter : ITypeParameter
        {
            bool ITypeParameter.IsClosed
                => false;
        }
    }
}