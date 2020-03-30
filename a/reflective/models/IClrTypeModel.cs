//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public interface IClrTypeModel : IClrArtifact<Type>
    {
        string IArtifactModel.Name
            => Subject.Name;

        bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Subject == typeof(void);
        }
    }

    public interface IClrTypeModel<T> : IClrTypeModel
        where T : struct, IClrTypeModel<T>
    {

    }
}