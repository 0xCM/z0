//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Identifies operations of the form source -> target:string
    /// </summary>
    public class FormatterAttribute : OpAttribute
    {

    }

    /// <summary>
    /// Identifies operations of the form source -> target:IRenderBuffer
    /// </summary>
    public class RenderFunctionAttribute : OpAttribute
    {
        public RenderFunctionAttribute()
            : base()
        {

        }
    }
}