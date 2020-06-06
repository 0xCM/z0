//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes something with a label
    /// </summary>
    public interface ILabeled
    {
        string TypeName {get;}
    }

    public interface ITypeLabel<T> : ILabeled
    {
        string ILabeled.TypeName => LabelAttribute.TargetLabel<T>();
    }
}