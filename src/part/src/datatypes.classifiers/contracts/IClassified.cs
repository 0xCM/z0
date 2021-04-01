//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a subject to which a classification has been assigned
    /// </summary>
    public interface IClassified : ITextual
    {
        IClassValue Class {get;}

        string ITextual.Format()
            => Class?.Format() ?? string.Empty;
    }

    /// <summary>
    /// Characterizes a subject to which a parametric classification has been assigned
    /// </summary>
    /// <typeparam name="C">The classifier type</typeparam>
    public interface IClassified<C> : IClassified
        where C : IClassValue
    {
         new C Class {get;}

         IClassValue IClassified.Class
            => Class;
    }
}